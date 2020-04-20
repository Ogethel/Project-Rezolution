using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterPad : MonoBehaviour
{
    public int code;
    float disableTimer = 0;

    private void Update()
    {
        if (disableTimer > 0)
        {
            disableTimer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && disableTimer <= 0)
        {
            Debug.Log("true");
            foreach(TeleporterPad tp in FindObjectsOfType<TeleporterPad>())
            {
                Debug.Log("true1");
                if (tp.code==code && tp != this)
                {
                    Debug.Log("true2");
                    tp.disableTimer = 2;
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    Debug.Log(position);
                    collider.gameObject.transform.position = position;
                }

            }
        }
    }
}
