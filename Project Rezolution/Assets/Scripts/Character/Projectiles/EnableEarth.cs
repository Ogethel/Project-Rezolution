using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEarth : MonoBehaviour
{
    private SpawnReflectProjectile earthScript;
    public GameObject spellPoint;

    private void Start()
    {
        earthScript = spellPoint.GetComponent<SpawnReflectProjectile>();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            earthScript.HaveEarth();
        }
    }
}
