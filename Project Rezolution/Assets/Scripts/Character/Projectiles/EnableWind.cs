using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableWind : MonoBehaviour
{
    private SpawnReflectProjectile windScript;
    public GameObject spellPoint;

    private void Start()
    {
        windScript = spellPoint.GetComponent<SpawnReflectProjectile>();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            windScript.HaveWind();
        }
    }
}
