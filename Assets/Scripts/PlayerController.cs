using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 0.1f;
	public float turnSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey( GameController.forwardKey ) ) {
			transform.position += transform.forward * moveSpeed;
		}
		if ( Input.GetKey( GameController.leftKey ) ) {
			transform.position = transform.position + new Vector3( -moveSpeed, 0f, 0f);
		}
		if ( Input.GetKey( GameController.rightKey ) ) {
			transform.position = transform.position + new Vector3( moveSpeed, 0f, 0f);
		}
		if ( Input.GetKey( GameController.backKey ) ) {
			transform.position += -transform.forward * moveSpeed;
		}
		if ( Input.GetKey( GameController.upKey ) ) {
			transform.position += transform.up * moveSpeed;
		}
		if ( Input.GetKey( GameController.downKey ) ) {
			transform.position += -transform.up * moveSpeed;
		}
	}
}
