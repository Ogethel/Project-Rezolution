﻿using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Systems/Float Math")]
public class FloatMathSystem : WorkSystem
{
    public FloatData dataObj;
    private FloatData fromNameId;
    
    public override void Work()
    {
        fromNameId = NameIDObj as FloatData;
        workEvent.Invoke();
    }
    
    public void UpdateValue ()
    {
        dataObj.UpdateValue(fromNameId.Value);
    }
    
    public void ChangeValue ()
    {
        dataObj.Value = fromNameId.Value;
    }
    
    /*
    public void IncrementValue ()
    {
        dataObj.IncrementValue();
    }
    */
}