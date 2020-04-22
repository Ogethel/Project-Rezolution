using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTeleporter : MonoBehaviour
{
    public GameObject teleportToo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Warp")
        {
            GameObject newSpawn = other.gameObject;
            ChangeRespawnPoint(newSpawn);
        }
    }

    public void ChangeRespawnPoint(GameObject newSpawn)
    {
        teleportToo = newSpawn;

        GetComponent<CharacterController>().enabled = false;
        gameObject.transform.position = teleportToo.transform.position;
        GetComponent<CharacterController>().enabled = true;
        
    }

}