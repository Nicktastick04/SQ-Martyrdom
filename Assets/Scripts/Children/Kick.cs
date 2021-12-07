using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    private Player1_Parent Parent;
    // Start is called before the first frame update
    void Start()
    {
        Parent = GameObject.FindObjectOfType<Player1_Parent>();
    }

    public IEnumerator KickCo()
    {
        //Parent.animator.SetBool("punching",true);
        Parent.currentState = PlayerState.kick;
        yield return null;
        //Parent.animator.SetBool("punching", false);
        yield return new WaitForSeconds(0.5f);
        if (Parent.currentState == PlayerState.kick)
            Parent.currentState = PlayerState.walk;
    }
}
