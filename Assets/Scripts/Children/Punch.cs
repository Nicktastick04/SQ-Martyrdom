using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    private Player1_Parent Parent;

    // Start is called before the first frame update
    void Start()
    {
        Parent = GameObject.FindObjectOfType<Player1_Parent>();
    }

    public IEnumerator PunchCo()
    {
        //Parent.animator.SetBool("punching",true);
        Parent.currentState = PlayerState.punch;
        yield return null;
        //Parent.animator.SetBool("punching", false);
        yield return new WaitForSeconds(0.5f);
    }
}
