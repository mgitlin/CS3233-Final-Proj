﻿using UnityEngine;
using System.Collections;

public class ResetPlayerAfterHit : MonoBehaviour {
	public float resetVal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Drone") {
			col.gameObject.transform.Translate(0,0,resetVal);
		}
	}
}
