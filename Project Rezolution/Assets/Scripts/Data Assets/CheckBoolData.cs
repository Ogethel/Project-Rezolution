using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoolData : MonoBehaviour
{
    public BoolData boolDataObj;

    private void Update()
    {
        if (boolDataObj.value)
        {
            //do true work
            Debug.Log("True");
        }
        else
        {
            //do false work
        }
    }
}
