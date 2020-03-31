using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoDamage : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject effect;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Instantiate(effect, objToDestroy.transform.position, objToDestroy.transform.rotation);
            Destroy(objToDestroy);
        }
    }
}

