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
    private SpotDodge dodge1;
    private HSpotDodge dodge2;

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

        dodge1 = GameObject.FindObjectOfType<SpotDodge>();
        dodge2 = GameObject.FindObjectOfType<HSpotDodge>();

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

        if (Input.GetButtonDown("Punch") && currentState != PlayerState.kick && currentState != PlayerState.projectile && currentState != PlayerState.spotdodge && currentState != PlayerState.Hspotdodge)
        {
            StopAllCoroutines();
            StartCoroutine(attack1.PunchCo());
        }

        if (Input.GetButtonDown("Kick") && currentState != PlayerState.kick && currentState != PlayerState.projectile && currentState != PlayerState.spotdodge && currentState != PlayerState.Hspotdodge)
        {
            StopAllCoroutines();
            StartCoroutine(attack2.KickCo());
        }

        if (Input.GetButtonDown("Projectile") && currentState != PlayerState.kick && currentState != PlayerState.punch && currentState != PlayerState.Fdash && currentState != PlayerState.Bdash && currentState != PlayerState.projectile && currentState != PlayerState.spotdodge && currentState != PlayerState.Hspotdodge)
            StartCoroutine(attack3.ProjectileCo());

        if (Input.GetButtonDown("FDash") && currentState != PlayerState.kick && currentState != PlayerState.punch && currentState != PlayerState.Fdash && currentState != PlayerState.Bdash && currentState != PlayerState.projectile && currentState != PlayerState.spotdodge && currentState != PlayerState.Hspotdodge)
            StartCoroutine(dash1.FDashCo());

        if (Input.GetButtonDown("BDash") && currentState != PlayerState.kick && currentState != PlayerState.punch && currentState != PlayerState.Fdash && currentState != PlayerState.Bdash && currentState != PlayerState.projectile && currentState != PlayerState.spotdodge && currentState != PlayerState.Hspotdodge)
            StartCoroutine(dash2.BDashCo());

        if (Input.GetButtonDown("SpotDodge") && currentState != PlayerState.kick && currentState != PlayerState.punch && currentState != PlayerState.Fdash && currentState != PlayerState.Bdash && currentState != PlayerState.projectile && currentState != PlayerState.spotdodge && currentState != PlayerState.Hspotdodge)
            StartCoroutine(dodge1.SpotDodgeCo());

        if (Input.GetButtonDown("HSpotDodge") && currentState != PlayerState.kick && currentState != PlayerState.punch && currentState != PlayerState.Fdash && currentState != PlayerState.Bdash && currentState != PlayerState.Hspotdodge)
        {
            StartCoroutine(dodge2.HSpotDodgeCo());
        }
    }
}
