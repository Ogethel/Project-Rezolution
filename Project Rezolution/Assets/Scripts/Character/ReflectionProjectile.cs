using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionProjectile : MonoBehaviour
{
    public LayerMask collisionMask;

    public GameObject refProjectile;
    public Transform projectile;
    private float speed = 30;
    private float rotSpeed = 800;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //projectile.Rotate(Vector3.up * Time.deltaTime * rotSpeed);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + .05f,collisionMask))
        {
            Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflectDir.z, reflectDir.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
        }
        Object.Destroy(refProjectile, 2.0f);
    }
}
