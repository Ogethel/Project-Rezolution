using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Collection : ScriptableObject
{
    public List<Collectable> collectablesList;
    public int currentCollectableNum;

    public void AddToCollection(Collectable collecatbleObj)
    {
        if (collectablesList.Contains(collecatbleObj))
        {
            return;
            collectablesList.Add(collecatbleObj);
        }
        
    }

    public void RemoveFromCollection(Collectable collecatbleObj)
    {
        for (int i = 0; i < collectablesList.Count; i++)
        {
            Collectable obj = collectablesList[i];
            if (obj == collecatbleObj)
            {
                collectablesList.Remove(collecatbleObj);
            }
        }
    }


    public void ClearCollection()
    {
        collectablesList.Clear();
    } 

    public void UseCurrentItem()
    {
        if (collectablesList.Capacity > 0)
        {
            collectablesList[currentCollectableNum].Use();
        }
    }

    public void IncrementCurrentNum()
    {
        if (currentCollectableNum < collectablesList.Count + 1)
        {
            currentCollectableNum++;
        }
        else
        {
            currentCollectableNum = 0;
        }
    }
}
