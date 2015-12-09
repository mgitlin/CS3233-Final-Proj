using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 0.1f;
	public float turnSpeed = 5f;
	public GameObject camCtrl;
	Vector3 startPos;
	public float shakeStrength = 0;
	public GameObject popUp;

	private bool levelComplete = false;

	void Start () {levelComplete = false;}
		
	// Update is called once per frame
	void Update () {
		GameController.waitTime = Random.Range(0f, 2f);
		/*
		Vector3 offsetVector = transform.right * Mathf.Sin (Time.deltaTime * 1f)
			+ transform.up * Mathf.Sin (Time.deltaTime * 2f);
		if(shakeStrength < -.1f || shakeStrength > .1f) {
			shakeStrength = Random.Range(-1f,1f);
		}
		transform.position = transform.position + offsetVector * shakeStrength;
		
		// control the shaking via key press
		if(Input.GetKeyDown(KeyCode.Space)) {
			shakeStrength = 0.2f;
		}
		
		// *decay* the shake strength
		shakeStrength = Mathf.Clamp (shakeStrength - Time.deltaTime / 10, -1f, 1f);
		*/

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
		if (Input.GetKey(KeyCode.LeftArrow)){
			camCtrl.transform.Rotate(0.0f, Input.GetAxis("Horizontal") * turnSpeed, 0.0f);;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			camCtrl.transform.Rotate(0.0f, Input.GetAxis("Horizontal") * turnSpeed, 0.0f);;
		}
		if (levelComplete && Input.GetKey (KeyCode.Return)) {
			GameController.currentLevel++;
			Application.LoadLevel(GameController.currentLevel);
		}
	}

	void OnCollisionEnter (Collision hit){
		if(hit.transform.gameObject.tag == "levelComplete"){
			Debug.Log("Done!");
			popUp.SetActive(true);
			levelComplete = true;
		}
	}

}
