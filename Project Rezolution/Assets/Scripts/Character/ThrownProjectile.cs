using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownProjectile : MonoBehaviour
{
    public float damage = .2f;
    public float throwingRate = .65f;

    public GameObject startPosition;
    public Rigidbody thrownProjectile;

    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0) && timer >= throwingRate)
        {
            var forward = GameObject.Find("startPosition").transform.position;
            ThrowProjectile();
        }
        
    }

    protected virtual void ThrowProjectile()
    {
        timer = 0f;

        Rigidbody clone;
        //clone = Instantiate(ThrownProjectile, transform.position, transform.rotation);

    }
}
