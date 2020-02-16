using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : MonoBehaviour
{
    public List<NameID> NameIds;
    private NameID otherIDObj;

    public List<DoWorkAnthony> DoWorks;

    private void OnTriggerEnter(Collider other)
    {
        otherIDObj = other.GetComponent<BehaviorID>().nameIDObj;
        CheckID();
    }

    private void CheckID()
    {
        foreach (var obj in NameIds)
        {
            if (obj == otherIDObj)
            {
                foreach (var job in DoWorks)
                {
                    job.Work();
                }
                //do work
                //Do work is defined in other scripts. The Job of this script is to just make matches
            }
        }
    }
}
