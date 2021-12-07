﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Spawner : MonoBehaviour
{
    private Player1_Parent Parent;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        Parent = GameObject.FindObjectOfType<Player1_Parent>();
    }

    public IEnumerator ProjectileCo()
    {
        Parent.currentState = PlayerState.projectile;
        Instantiate(projectile, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1.4f);
        Parent.currentState = PlayerState.walk;
    }
}
