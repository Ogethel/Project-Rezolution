using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncherController : MonoBehaviour
{
    public bool isFiring;
    public bool isPunching;

    public ProjectileController knife;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
               
                if (shotCounter <= 0)
                {
                    shotCounter = timeBetweenShots;
                    ProjectileController newBullet = Instantiate(knife, firePoint.position, firePoint.rotation) as ProjectileController;
                    newBullet.speed = bulletSpeed;
                    Object.Destroy(newBullet, 2.0f); // should destroy instantiated Projectile after 2s
                }
                else
                {
                    shotCounter = 0;
                }
            }
        }
    }
}
