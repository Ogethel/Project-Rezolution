using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Transform destination;
    public Transform playerT;
    //public Transform playerT;
    public float destinationX, destinationY, destinationZ;
    //public float playerX, playerY, playerZ;
    //public Vector3 playerV;

    public void Awake()
    {
        //playerT = GetComponent<Transform>();
        destination = GetComponent<Transform>();
        destinationX = destination.position.x;
        Debug.Log("destinationX");
        destinationY = destination.position.y;
        Debug.Log("destinationY");
        destinationZ = destination.position.z;
        Debug.Log("destinationZ");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            //other.transform.position = destination.position;
            //Vector3 playerT = new Vector3(destinationX, destinationY, destinationZ);
            //other.transform.position = new Vector3(destinationX, destinationY, destinationZ);
            Vector3 newPos = new Vector3(destinationX, destinationY, destinationZ);
            Debug.Log(newPos);
            col.gameObject.transform.position = newPos;
        }
        
    }
}
