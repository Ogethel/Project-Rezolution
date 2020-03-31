using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;
    private void Start()
    {
        GameEventsInteractibles.current.onDoorwayTriggerEnter += OnDoorwayOpen;
        GameEventsInteractibles.current.onDoorwayTriggerExit += OnDoorwayClose;
    }

    private void OnDoorwayOpen(int id)
    {
        if (id == this.id)
        {
            LeanTween.moveLocalY(gameObject, 19.36f, 1f).setEaseOutQuad();
        }
    }

    private void OnDoorwayClose(int id)
    {
        if (id == this.id)
        {
            LeanTween.moveLocalY(gameObject, 17.36f, 1f).setEaseOutQuad();
        }
    }

    private void OnDestroy()
    {
        GameEventsInteractibles.current.onDoorwayTriggerEnter -= OnDoorwayOpen;
        GameEventsInteractibles.current.onDoorwayTriggerExit -= OnDoorwayClose;
    }
}

