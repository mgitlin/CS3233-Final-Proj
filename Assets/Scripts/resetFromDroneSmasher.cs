using UnityEngine;
using System.Collections;

public class resetFromDroneSmasher : MonoBehaviour {
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
		Debug.Log(GameController.moves.ToString());
		if (col.gameObject.name == "Drone") {
			//col.gameObject.transform.Translate(resetValx,resetValy,resetValz);
			if(GameController.moveX == "left" || GameController.moveZ == "backward") {
				col.gameObject.transform.Translate(resetValx,0,0);

			}
			if(GameController.moveZ == "forward" || GameController.moveX == "right") {
				col.gameObject.transform.Translate(0,0,resetValz);
			}
			/*
			if(col.gameObject.transform.position.x > 152f && col.gameObject.transform.position.z > 133f) {
				col.gameObject.transform.Translate(0,0,resetValz);
			} else {
				col.gameObject.transform.Translate(resetValx,0,2);
			}*/
		}
	}
}
