using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject me;


   public void Die()
    {
        Destroy(me);
    }
}
