﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Movement : MonoBehaviour
{
    public Vector3 position;
    public CharacterController controller;

    public float moveSpeed = 10f, gravity = 9.81f, JumpSpeed = 30f;
    private int jumpCount;
    public int jumpCountMax = 2;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (isGrounded && jumpCount <= jumpCountMax)
        {
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            velocity.y = Mathf.Sqrt(JumpSpeed * -2f * gravity);
            jumpCount++;
        }

        position.Set(Input.GetAxis("Horizontal") * moveSpeed, velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(position * Time.deltaTime);

        if (position != Vector3.zero)
        {
            controller.transform.forward = position;
        }
    }
}

