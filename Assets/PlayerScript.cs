﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float upForce = 100f;

	Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Jump")){
			Debug.Log("up");
			rigidBody.AddForce(Vector3.up*upForce);
		}
	}
}