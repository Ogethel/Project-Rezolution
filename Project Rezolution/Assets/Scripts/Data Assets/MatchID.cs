using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class MatchID : MonoBehaviour
{
    public List<NameID> nameIDList;
    public NameID ID;
    public UnityEvent OnMatch, NoMatch;
    public bool MatchMade { private get; set; }

    private void OnTriggerEnter(Collider other)
    {
        //Fixed
        var doWorkObj = other.GetComponent<DoWork>();
        var otherNameID = doWorkObj.nameIdObj;
        foreach (var nameId in nameIDList)
        {
           
            if (nameId == otherNameID)
            {
                
            }

        }
        //Baisc:
        var otherId = other.GetComponent<MatchID>();
        if (otherId == null) return;
        
        if (otherId.ID == ID || otherId.MatchMade)
        {
            OnMatch.Invoke();
        }
        else
        {
            NoMatch.Invoke();
        }
    }
}