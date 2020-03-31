﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other)
    {
        GameEventsInteractibles.current.DoorwayTriggerEnter(id);
    }

    private void OnTriggerExit(Collider other)
    {
        GameEventsInteractibles.current.DoorwayTriggerExit(id);
    }
}
