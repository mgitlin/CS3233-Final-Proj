using UnityEngine;
using System.Collections;

public class Spinners : MonoBehaviour {
	public float spinRate = 1080f;
	Quaternion originalLocalRotation;

	// Use this for initialization
	void Start () {
		originalLocalRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localRotation = Quaternion.Euler(0f, spinRate * Time.time, 0f);
	}
}
