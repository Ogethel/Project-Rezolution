using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_BrakeysCamera : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform camInput;
    public Transform playerBody;
    public float mouseY = -45f;

    float xRotation = 0f;


    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
      
        //xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation + mouseY, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
