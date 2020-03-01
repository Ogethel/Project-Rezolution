using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float speed;
    private Rigidbody rBody;
    public GameObject knife;
    public LayerMask ground;
    public GameObject launchPoint;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //rBody.AddForce(transform.forward * speed);
        //knife.transform.position = knife.transform.forward * 2;
        rBody.velocity = transform.forward * speed; // * transform.forward knife.transform.forward
        Object.Destroy(knife, 2.0f); // should destroy instantiated Projectile after 2s

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == ground)
        {
            Object.Destroy(knife, 2.0f);
        }
    }
}
