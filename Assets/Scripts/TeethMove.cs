using UnityEngine;
using System.Collections;

public class TeethMove : MonoBehaviour {
	
	public float maxSpeed = 3;
	
	private Vector3 startPosition;
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed)*0.55f, transform.position.z);
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Drone") {
			col.gameObject.transform.Translate(0,0,-1);
		}
	}
}
