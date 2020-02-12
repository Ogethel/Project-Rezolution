using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_BrakeysCamera : MonoBehaviour
{
    public float mouseSensitivityX = 100f;
    public float mouseSensitivityY = 100f;
    public Transform camInput;
    public Transform playerBody;
    public float mouseYLock = -45f;

    float xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;
      
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -15f, 5f);

        transform.localRotation = Quaternion.Euler(xRotation + mouseYLock, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
