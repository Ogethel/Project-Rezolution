using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsSystemTest : MonoBehaviour
{
    /*OntriggerEnter(collider other)
     * What happens with it triggers
     * define variable
     */

    public UnityEvent EnterEvent, ExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        EnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        ExitEvent.Invoke();
    }

}
