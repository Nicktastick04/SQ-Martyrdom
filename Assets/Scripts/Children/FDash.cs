﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FDash : MonoBehaviour
{
    private Player1_Parent Parent;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Parent = GameObject.FindObjectOfType<Player1_Parent>();
    }

    public IEnumerator FDashCo()
    {
        Parent.currentState = PlayerState.Fdash;
        Parent.rigidbody.AddForce(transform.right * speed);
        yield return null;
        //
        yield return new WaitForSeconds(0.1f);
        Parent.rigidbody.AddForce(transform.right * -speed);
        if (Parent.currentState == PlayerState.Fdash)
            Parent.currentState = PlayerState.walk;
    }
}
