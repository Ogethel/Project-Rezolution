using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSpells : MonoBehaviour
{
    public LayerMask collisionMask;
    public ParticleSystem onDestroy;
    public GameObject refProjectile;

    public float speed = 30f;
    public float timer = 2f;
    public bool timerActive;

    private void Start()
    {
        timerActive = false;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + .05f, collisionMask))
        {
            Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflectDir.z, reflectDir.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
        }
        if (timerActive == false)
        {
            DestroyTimer();
        }
        if (timerActive == true)
        {
            timer = timer - Time.deltaTime;
            if (timer <= 0f)
            {
                Instantiate(onDestroy, refProjectile.transform.position, refProjectile.transform.rotation);
                Destroy(refProjectile);
            }
        }
    }

    private void DestroyTimer()
    {
        timerActive = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 14)
        {
            Instantiate(onDestroy, refProjectile.transform.position, refProjectile.transform.rotation);
            Destroy(refProjectile);
        }
    }
}
