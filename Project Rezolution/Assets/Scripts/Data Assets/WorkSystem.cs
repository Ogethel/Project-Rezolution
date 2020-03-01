using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class WorkSystem : ScriptableObject
{
    public NameID NameIDObj {get; set;}
    public UnityEvent workEvent;

    public abstract void Work();
}
