using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsEnabled : MonoBehaviour
{
    public bool haveWind, haveFire, haveIce, haveEarth;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wind")
        {
            haveWind = true;
            Debug.Log("Wind was Hit");
        }
        if (other.gameObject.tag == "Fire")
        {
            haveFire = true;
        }
        if (other.gameObject.tag == "Ice")
        {
            haveIce = true;
        }
        if (other.gameObject.tag == "Earth")
        {
            haveEarth = true;
        }
    }


}
