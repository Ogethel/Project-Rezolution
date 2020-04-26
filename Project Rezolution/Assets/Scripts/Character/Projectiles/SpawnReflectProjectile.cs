using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnReflectProjectile : MonoBehaviour
{
    public GameObject basicAttack, projectileWind, projectileFire, projectileIce, projectileEarth;
    public float timeShots;
    public bool basicActive, windActive, fireActive, iceActive, earthActive;

    public bool haveWind, haveFire, haveIce, haveEarth;

    private void Start()
    {
        basicActive = true;

    }

    public void HaveWind()
    {
        haveWind = true;
    }
    public void HaveFire()
    {
        haveFire = true;
    }
   
    public void HaveIce()
    {
        haveIce = true;
    }
    public void HaveEarth()
    {
        haveEarth = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            basicActive = true;
            windActive = false;
            fireActive = false;
            iceActive = false;
            earthActive = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && haveWind)
        {
            basicActive = false;
            windActive = true;
            fireActive = false;
            iceActive = false;
            earthActive = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && haveFire)
        {
            basicActive = false;
            windActive = false;
            fireActive = true;
            iceActive = false;
            earthActive = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && haveIce)
        {
            basicActive = false;
            windActive = false;
            fireActive = false;
            iceActive = true;
            earthActive = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && haveEarth)
        {
            basicActive = false;
            windActive = false;
            fireActive = false;
            iceActive = false;
            earthActive = true;
        }

        timeShots = timeShots - Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            if (basicActive && timeShots <= 0f)
            {
                Instantiate(basicAttack, transform.position, transform.rotation);
                timeShots = .5f;
            }
            if (windActive && timeShots <= 0f)
            {
                Instantiate(projectileWind, transform.position, transform.rotation);
                timeShots = .1f;
            }
            if (fireActive && timeShots <= 0f)
            {
                Instantiate(projectileFire, transform.position, transform.rotation);
                timeShots = .3f;
            }
            if (iceActive && timeShots <= 0f)
            {
                Instantiate(projectileIce, transform.position, transform.rotation);
                timeShots = .3f;
            }
            if (earthActive && timeShots <= 0f)
            {
                Instantiate(projectileEarth, transform.position, transform.rotation);
                timeShots = .55f;
            }
        }
    }
}
