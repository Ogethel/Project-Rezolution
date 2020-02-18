﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IconicDesignStudios.Controller
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(IDS_RBPlayer_Inputs))]

    public class Movement : MonoBehaviour
    {
        #region Variables
        [Header("Required Components")]
        private IDS_RBPlayer_Inputs input;
        public CharacterController controller;

        [Header("Player Variables")]
        public Vector3 position;
        public float moveSpeed = 10f, gravity = 9.81f, JumpSpeed = 30f;
        private int jumpCount;
        public int jumpCountMax = 2;

        [Header("Grounded Variables")]
        public Transform groundCheck;
        public float groundDistance = 0.4f;
        public LayerMask groundMask;
        Vector3 velocity;
        bool isGrounded;

        [Header("Aim Direction Properties")]
        public Transform aimDirTransform;

        [Header("Reticle Properties")]
        public Transform reticleTransform;

        #endregion

        private void Start()
        {
            controller = GetComponent<CharacterController>();
            input = GetComponent<IDS_RBPlayer_Inputs>();
        }

        void Update()
        {
            float horMovement = Input.GetAxisRaw("Horizontal");
            float vertMovement = Input.GetAxisRaw("Vertical");

            //if (position != Vector3.zero)
            if (position.x != 0 || position.z != 0)
            {
                //controller.transform.forward = position;
                controller.transform.forward = new Vector3(position.x, 0, position.z);
            }

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

            if (controller && input)
            {
                HandleReticle();
                HandleAimDir();
            }

            //transform.Translate(transform.right * horMovement * Time.deltaTime * moveSpeed);
            //transform.Translate(transform.forward * vertMovement * Time.deltaTime * moveSpeed);

            position.Set(Input.GetAxis("Horizontal") * moveSpeed, velocity.y, Input.GetAxis("Vertical") * moveSpeed);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(position * Time.deltaTime);

            /*Vector3 moveDirection = new Vector3(horMovement, 0, vertMovement);
            //if (moveDirection != Vector3.zero)
            {
                //Quaternion newRotation = Quaternion.LookRotation(moveDirection);
                //controller.transform.rotation = Quaternion.Slerp(controller.transform.rotation, newRotation, Time.deltaTime * 8);
            }
            */
        }

        protected virtual void HandleAimDir()
        {
            if (aimDirTransform)
            {
                Vector3 aimLookDir = input.ReticalPosition - aimDirTransform.position;
                aimLookDir.y = 0f;
                aimDirTransform.rotation = Quaternion.LookRotation(aimLookDir);
            }
        }

        protected virtual void HandleReticle()
        {
            if (reticleTransform)
            {
                reticleTransform.position = input.ReticalPosition;
            }
        }
    }
}

