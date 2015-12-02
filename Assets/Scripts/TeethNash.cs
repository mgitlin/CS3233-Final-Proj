using UnityEngine;
using System.Collections;

public class TeethNash : MonoBehaviour {
	public GameObject upperTeeth;
	public GameObject lowerTeeth;
	public string direction = "y";
	public float extend = .3f;
	public float retract = .1f;
	public float maxChange = 5f;
	float newYMove;
	bool reset = true;
	float waitTime;
	float curTime;
	
	Vector3 lowerOriginPos;
	Vector3 upperOriginPos;
	
	// Use this for initialization
	void Start () {
		lowerOriginPos = upperTeeth.transform.position;
		upperOriginPos = lowerTeeth.transform.position;
		curTime = 0f;
		waitTime = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		curTime += Time.deltaTime;
		//Debug.log();
		if(curTime > waitTime) {
			if(lowerTeeth.transform.position.y - lowerOriginPos.y < maxChange && reset == true) {
				lowerTeeth.transform.position += new Vector3(0f, extend, 0f);
			} else if(transform.position.y > lowerOriginPos.y){
				reset = false;
				//newYMove = originPos.y -  
				lowerTeeth.transform.position += new Vector3(0f, -retract, 0f);
			} else if(upperTeeth.transform.position.y - upperOriginPos.y > -maxChange && reset == true) {
				upperTeeth.transform.position += new Vector3(0f, -extend, 0f);
			} else if(upperTeeth.transform.position.y < upperOriginPos.y){
				reset = false;
				//newYMove = originPos.y -  
				upperTeeth.transform.position += new Vector3(0f, retract, 0f);
			} else {
				reset = true;
				curTime = 0f;
				waitTime = Random.Range(0, 2f);
			}
		}

		/*
		if(curTime > waitTime) {
			curTime = 0f;
			waitTime = Random.Range(0, 2);
		}*/
		
	}
}

