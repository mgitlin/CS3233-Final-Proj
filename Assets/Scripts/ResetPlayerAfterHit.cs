using UnityEngine;
using System.Collections;

public class ResetPlayerAfterHit : MonoBehaviour {
	public float resetValx;
	public float resetValy;
	public float resetValz;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Drone") {
			col.gameObject.transform.Translate(resetValx,resetValy,resetValz);
		}
	}
}
