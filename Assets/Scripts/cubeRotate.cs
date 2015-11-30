using UnityEngine;
using System.Collections;

public class cubeRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, 20*Time.deltaTime);
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Drone") {
			col.gameObject.transform.Translate(0,0,5);
		}
	}
}