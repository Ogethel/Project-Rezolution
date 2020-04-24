using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFire : MonoBehaviour
{
    private SpawnReflectProjectile fireScript;
    public GameObject spellPoint;

    private void Start()
    {
        fireScript = spellPoint.GetComponent<SpawnReflectProjectile>();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            fireScript.HaveFire();
        }
    }
}
