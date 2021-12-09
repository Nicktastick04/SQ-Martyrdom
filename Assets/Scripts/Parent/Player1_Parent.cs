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
    private Kick attack2;
    private Projectile_Spawner attack3;
    private FDash dash1;
    private BDash dash2;

    private Health_Controller health;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        attack1 = GameObject.FindObjectOfType<Punch>();
        attack2 = GameObject.FindObjectOfType<Kick>();
        attack3 = GameObject.FindObjectOfType<Projectile_Spawner>();

        dash1 = GameObject.FindObjectOfType<FDash>();
        dash2 = GameObject.FindObjectOfType<BDash>();

        health = GameObject.FindObjectOfType<Health_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        /* switch ()
         {
             case Punch:

                 break;
         }*/

        if (Input.GetButtonDown("Punch") && currentState != PlayerState.kick)
        {
            StopAllCoroutines();
            StartCoroutine(attack1.PunchCo());
        }

        if (Input.GetButtonDown("Kick") && currentState != PlayerState.kick)
        {
            StopAllCoroutines();
            StartCoroutine(attack2.KickCo());
        }

        if (Input.GetButtonDown("Projectile") && currentState != PlayerState.kick && currentState != PlayerState.punch)
            StartCoroutine(attack3.ProjectileCo());

        if (Input.GetButtonDown("FDash"))
            StartCoroutine(dash1.FDashCo());

        if (Input.GetButtonDown("BDash"))
            StartCoroutine(dash2.BDashCo());
    }
}
