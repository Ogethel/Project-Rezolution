using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownProjectile : MonoBehaviour
{
    public float damage = .2f;
    public float throwingRate = .65f;

    public GameObject orignObject;
    public Vector3 startPosition;
    public Quaternion playerRotation;
    public GameObject thrownProjectile;

    float timer;

   
    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0)/* && timer >= throwingRate*/)
        {
            //startPosition = orignObject.GetComponent<Transform>();
            //var forward = GameObject.Find("startPosition").transform.position;
            ThrowProjectile();
        }
        
    }

    protected virtual void ThrowProjectile()
    {
        //timer = 0f;

        Instantiate(thrownProjectile, startPosition, playerRotation);
        Debug.Log("Throw");

        //clone = Instantiate(ThrownProjectile, transform.position, transform.rotation);

    }
}
