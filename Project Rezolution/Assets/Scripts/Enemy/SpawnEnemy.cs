using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform spawner;
    public Vector3 instancePos;
    public GameObject enemy;
    public ParticleSystem particle;

    private void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Player":
                Instantiate(enemy, instancePos, spawner.rotation);
                break;
        }
    }
}
