using UnityEngine;
using System.Collections;

public class SpikeMover : MonoBehaviour {
	public string direction = "y";
	public float extend = .3f;
	public float retract = .1f;
	public float maxChange = 5f;
	bool reset = true;
	float waitTime;
	float curTime;

	Vector3 originPos;

	// Use this for initialization
	void Start () {
		originPos = transform.position;
		curTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		curTime += Time.deltaTime;
		//Debug.log();
		if(direction.ToLower() == "y") {
			if(transform.position.y - originPos.y < maxChange && reset == true && curTime > waitTime) {
				transform.position += new Vector3(0f, extend, 0f);
			}else if(transform.position.y > originPos.y && curTime > waitTime){
				reset = false;
				transform.position += new Vector3(0f, -retract, 0f);
			} else if(curTime > waitTime) {
				reset = true;
				curTime = 0f;
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
	}
}
