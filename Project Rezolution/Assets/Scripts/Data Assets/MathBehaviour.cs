using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathBehaviour : MonoBehaviour
{
    public FloatData dataObj;
    //public FloatData damagerData;
    public FloatData[] floatDataList;
    public NameID otherNameID;

    private void OnTriggerEnter(Collider other)
    {
        otherNameID = other.GetComponent<BehaviorID>().nameIDObj;
        ChangeValue();
    }

    public void ChangeValue()
    {
        foreach (var data in floatDataList)
        {

            if (data == otherNameID)
            {
                dataObj.UpdateValue(data.Value);
            }
        }
    }

}
