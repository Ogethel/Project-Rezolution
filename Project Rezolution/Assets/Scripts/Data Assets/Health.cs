using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : ScriptableObject
{

    public float value = 1f;


    public FloatData healthData;
    //public FloatData damagerData;
    public FloatData[] damagerList;

    public void ChangeHealth(FloatData incomingDamager)
    {
        foreach (var damager in damagerList)
        {
            if (damager == incomingDamager)
            {
                healthData.UpdateValue(damager.Value);
            }
        }
    }

    /*
    //Previous Variations:
    
    public void StartDamage()
    {
        healthData.SetValue(damagerData);
    }

    Should be UpdateValue
    public void UpdateValue(float f)
    {
        value += f;
    }

    public void ChangeValue(float f)
    {
        value = f;
    }

    public void AddValue(float f)
    {
        value += f;
    }

    public void SubtractValue(float f)
    {
        value -= f;
    }
    */
}
