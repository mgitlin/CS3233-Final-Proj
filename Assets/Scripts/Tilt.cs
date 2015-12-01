using UnityEngine;
using System.Collections;

public class Tilt : MonoBehaviour {
	public float turnSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey( KeyCode.P ) ) {
			transform.Rotate(0f, 0f, -1 * turnSpeed * Time.deltaTime);
		}
		//if ( Input.GetKey( GameController.rightKey ) ) {
		if ( Input.GetKey( KeyCode.L) ) {
			transform.Rotate(0f, 0f, turnSpeed * Time.deltaTime);
		}

	}
}
