using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnReflectProjectile : MonoBehaviour
{
    public GameObject projectileFire;
    public GameObject projectileIce;

    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectileFire, transform.position, transform.rotation);
        }
    }
}
