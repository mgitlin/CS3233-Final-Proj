using UnityEngine;
using System.Collections;

public class MovingWall : MonoBehaviour {

	Vector3 startPos;
	float shakeStrength;
	float curTime;
	float waitTime;
	
	// Use this for initialization
	void Start () {
		startPos = transform.position; // remember where we started
		curTime = 0;
		float shakeStrength = 0;
	}
	
	// Update is called once per frame
	void Update () {
		curTime += Time.deltaTime;
		Debug.Log(curTime.ToString());
		var rand = Random.Range(0, 1f);
		waitTime = Random.Range(10f, 15f);
		if(curTime > waitTime) {
			shakeStrength = Random.Range(0, .5f);
			curTime = 0;
		}
		if(curTime > 0 && rand < .25f) {
			Vector3 offsetVector = transform.right * Mathf.Sin (Time.time * 70f)
				+ transform.up * - Mathf.Sin (Time.time * 70f);
			
			transform.position = startPos + offsetVector * shakeStrength;
		} else if (curTime > 0 && rand > .25f && rand < .5f) {
			Vector3 offsetVector = transform.right * Mathf.Sin (Time.time * 70f)
				+ transform.up * Mathf.Sin (Time.time * 70f);
			
			transform.position = startPos + offsetVector * shakeStrength;
		} else if (curTime > 0 && rand > .5f && rand < .75f) {
			Vector3 offsetVector = transform.right * -Mathf.Sin (Time.time * 70f)
				+ transform.up * - Mathf.Sin (Time.time * 70f);
			
			transform.position = startPos + offsetVector * shakeStrength;
		} else if (curTime > 0 && rand > .75f) {
			Vector3 offsetVector = transform.right * - Mathf.Sin (Time.time * 70f)
				+ transform.up * Mathf.Sin (Time.time * 70f);
			
			transform.position = startPos + offsetVector * shakeStrength;
		}
		
		// control the shaking via key press
		if(Input.GetKeyDown(KeyCode.Space)) {
			shakeStrength = 0.2f;
		}
		
		// *decay* the shake strength
		shakeStrength = Mathf.Clamp (shakeStrength - Time.deltaTime / 30, -5f, 5f);
	}
}
