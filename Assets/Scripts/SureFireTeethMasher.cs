using UnityEngine;
using System.Collections;

public class SureFireTeethMasher : MonoBehaviour {
	public string direction = "y";
	public float extend = .3f;
	public float retract = .1f;
	public float maxChange = 5f;
	public GameObject topTeeth;
	public GameObject bottomTeeth;
	Vector3 topTeethOrigin;
	Vector3 bottomTeethOrigin;
	Vector3 curtopTeethPos;
	Vector3 curbottomTeethPos;
	float newYMove;
	bool reset = true;
	float waitTime;
	float curTime;
	
	Vector3 originPos;
	
	// Use this for initialization
	void Start () {
		topTeethOrigin = topTeeth.transform.position;
		bottomTeethOrigin = bottomTeeth.transform.position;
		curTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		curtopTeethPos = topTeeth.transform.position;
		curbottomTeethPos = bottomTeeth.transform.position;
		curTime += Time.deltaTime;
		//Debug.log(); 
		if(curbottomTeethPos.y - bottomTeethOrigin.y < maxChange && reset == true && curTime > waitTime) {
			bottomTeeth.transform.position += bottomTeeth.transform.up * extend;
		}else if(curbottomTeethPos.y > bottomTeethOrigin.y && curTime > waitTime){
			reset = false;
			bottomTeeth.transform.position -= bottomTeeth.transform.up * retract;
		} else {
			reset = true;
			curTime = 0f;
			waitTime = Random.Range(0f, 1f);
		}
		if(topTeethOrigin.y - curtopTeethPos.y < maxChange && reset == true && curTime > waitTime) {
			topTeeth.transform.position -= topTeeth.transform.up * extend;
		}else if(curbottomTeethPos.y < topTeethOrigin.y && curTime > waitTime){
			reset = false;
			topTeeth.transform.position += topTeeth.transform.up * retract;
		}

	}
	
}

/*
		if(direction.ToLower() == "-y") {
			if(transform.position.y - originPos.y > -maxChange && reset == true && curTime > waitTime) {
				transform.position -= transform.up * extend;
			}else if(transform.position.y < originPos.y && curTime > waitTime){
				reset = false;
				//newYMove = originPos.y -  
				transform.position += transform.up * retract;
			} else if(curTime > waitTime) {
				reset = true;
				curTime = 0f;
				waitTime = GameController.waitTime;
			}
		}
		
		if(direction.ToLower() == "x") {
			if(transform.position.x - originPos.x < maxChange && reset == true && curTime > waitTime) {
				transform.position += new Vector3(extend, 0f, 0f);
			}else if(transform.position.x > originPos.x && curTime > waitTime){
				reset = false;
				transform.position += new Vector3(-retract, 0f, 0f);
			} else if(curTime > waitTime) {
				reset = true;
				curTime = 0f;
			}
		}
		if(direction.ToLower() == "-x") {
			if(transform.position.x - originPos.x < maxChange && reset == true && curTime > waitTime) {
				transform.position += new Vector3(extend, 0f, 0f);
			}else if(transform.position.x > originPos.x && curTime > waitTime){
				reset = false;
				transform.position += new Vector3(-retract, 0f, 0f);
			} else if(curTime > waitTime) {
				reset = true;
				curTime = 0f;
			}
		}
		if(direction.ToLower() == "z") {
			if(transform.position.z - originPos.z < maxChange && reset == true && curTime > waitTime) {
				transform.position += new Vector3(0f, 0f, extend);
			}else if(transform.position.z > originPos.z && curTime > waitTime){
				reset = false;
				transform.position += new Vector3(0f, 0f, -retract);
			} else if(curTime > waitTime) {
				reset = true;
				curTime = 0f;
			}
		}
	}*/
