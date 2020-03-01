using System.Collections.Generic;
using System;

public class MatchidBehaviour : IDBehavior
{
   [Serializable]
   public struct possibleMatches
    {
        public NameID nameIDObj;
        public DoWork workObj;
    }

    public List<possibleMatches> workIdlist;
    /*
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
    */
}
