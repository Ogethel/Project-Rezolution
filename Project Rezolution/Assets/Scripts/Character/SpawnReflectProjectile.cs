using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnReflectProjectile : MonoBehaviour
{
    public GameObject projectile;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
