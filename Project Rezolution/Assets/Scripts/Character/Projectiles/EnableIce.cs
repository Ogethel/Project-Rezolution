using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableIce : MonoBehaviour
{
    private SpawnReflectProjectile iceScript;
    public GameObject spellPoint;

    private void Start()
    {
        iceScript = spellPoint.GetComponent<SpawnReflectProjectile>();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            iceScript.HaveIce();
        }
    }
}
