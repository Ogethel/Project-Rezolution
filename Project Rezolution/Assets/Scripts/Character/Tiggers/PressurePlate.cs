using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject enableObject;
    public GameObject disableObject;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "PushBlock")
        {
            enableObject.SetActive(true);
            disableObject.SetActive(false);
        }
            
    }
}
