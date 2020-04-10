using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullFab : MonoBehaviour
{
	public float speed = 100f;
	public Rigidbody2D rigidBod;
	
	void Start ()
	{
		rigidBod.velocity = transform.right * speed;
	}

	private void OnTriggerEnter (Collider hitInfo)
	{
		Debug.Log(hitInfo.name);
		Destroy(gameObject);
	}
}
