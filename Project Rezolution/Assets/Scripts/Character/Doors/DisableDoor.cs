using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableDoor : MonoBehaviour
{
    public GameObject disabledObject;

    private void OnTriggerEnter(Collider other)
    {
        disabledObject.SetActive(false);
    }
}
