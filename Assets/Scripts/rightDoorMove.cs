﻿using UnityEngine;
using System.Collections;

public class rightDoorMove : MonoBehaviour {
	bool collided = false;
	int speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (collided == true) {
			transform.Translate(0, Time.deltaTime*speed, 0);
		}
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Drone1") {
			collided = true;
		}
	}
}
