using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSpotDodge : MonoBehaviour
{
    private Player1_Parent Parent;
    // Start is called before the first frame update
    void Start()
    {
        Parent = GameObject.FindObjectOfType<Player1_Parent>();
    }

    public IEnumerator HSpotDodgeCo()
    {
        //animator.SetBool("dodge", true);
        Parent.currentState = PlayerState.Hspotdodge;
        yield return null;
        //animator.SetBool("dodge", false);
        yield return new WaitForSeconds(0.3f);
        Parent.currentState = PlayerState.walk;
    }
}
