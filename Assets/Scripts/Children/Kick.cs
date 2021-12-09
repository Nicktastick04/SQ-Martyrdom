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
        this.Parent.rigidbody.velocity = Vector3.zero;
        Parent.animator.SetBool("punching", false);
        Parent.animator.SetBool("kicking",true);
        Parent.currentState = PlayerState.kick;
        yield return new WaitForSeconds(0.5f);
        Parent.animator.SetBool("kicking", false);
        yield return null;
        Parent.currentState = PlayerState.walk;
    }
}
