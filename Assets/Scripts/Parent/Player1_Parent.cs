using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    walk,
    punch,
    kick,
    projectile,
    uppercut,
    spotdodge,
    Hspotdodge,
    Fdash,
    Bdash,
    block,
    hit
}

public class Player1_Parent : MonoBehaviour
{
    public PlayerState currentState;
    public Rigidbody2D rigidbody;
    public Animator animator;
    private Punch attack1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        attack1 = GameObject.FindObjectOfType<Punch>();
    }

    // Update is called once per frame
    void Update()
    {
        /* switch ()
         {
             case Punch:

                 break;
         }*/

        if (Input.GetButtonDown("Punch"))
            StartCoroutine(attack1.PunchCo());
    }
}
