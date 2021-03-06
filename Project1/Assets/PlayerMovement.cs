﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    public float movementSpeed = 40f;
    float horizontalMove = 0f;
    bool Jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * movementSpeed;
        Debug.Log(Input.GetAxisRaw("Horizontal"));

        if(Input.GetButtonDown("Jump"))
        {
            Jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, Jump);
        Jump = false;
 
    }
}
