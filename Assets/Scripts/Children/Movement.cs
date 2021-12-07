using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Player1_Parent Parent;
    private float movementInputDirection;
    public float movementSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Parent = GameObject.FindObjectOfType<Player1_Parent>();
    }

    void Update()
    {
        CheckInput();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Parent.currentState == PlayerState.walk)
            ApplyMovement();
    }

    public void CheckInput()
    {
        movementInputDirection = Input.GetAxisRaw("Horizontal");
    }

    private void ApplyMovement()
    {
        Parent.rigidbody.velocity = new Vector2(movementSpeed * movementInputDirection, Parent.rigidbody.velocity.y);
    }
}