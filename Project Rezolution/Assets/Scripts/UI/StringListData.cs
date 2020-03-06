using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringListObj;
    public int currentListNumber;

    public string ReturnCurrentLine()
    {
        return stringListObj[currentListNumber];

    }

    public void ResetToZero()
    {
        currentListNumber = 0;
    }

    public void IncrementLineNumber()
    {
        if (currentListNumber < stringListObj.Count-1)
        {
            currentListNumber++;
        }
        else
        {
            currentListNumber = 0;
        }
    }

}
