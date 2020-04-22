using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDoor : MonoBehaviour
{
    public GameObject enableObject;

    private void OnTriggerEnter(Collider other)
    {
        enableObject.SetActive(true);
    }
}
