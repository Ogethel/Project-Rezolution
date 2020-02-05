using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDBehavior : MonoBehaviour
{
    public List<IDName> IDNameList;
    public UnityEvent EnterEvent, ExitEvent;

    public void EnteredTrigger()
    {
        //EnterEvent.Invoke;
    }

    public void ExitedTrigger()
    {
        //ExitEvent.Invoke;
    }
   
}
