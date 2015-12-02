using UnityEngine;
using System.Collections;

public class TurnPlayerController : MonoBehaviour {
	public float moveSpeed = 0.1f;
	public float turnSpeed = 5f;
	//public GameObject rightDoor;
	//public GameObject leftDoor;
	public float doorSlide = 5f;
		
		
	Vector3 rightOriginPos;
	Vector3 leftOriginPos;
		
		
	// Use this for initialization
	void Start () {
		//rightOriginPos = rightDoor.transform.position;
		//leftOriginPos = leftDoor.transform.position;
	}
		
	// Update is called once per frame
	void Update () {
		/*if(transform.position.z < -765f && transform.position.z > -777f){
			if(rightOriginPos.x - rightDoor.transform.position.x < doorSlide) {
				rightDoor.transform.position += new Vector3(-moveSpeed, 0f, 0f);
			}
			if(leftDoor.transform.position.x - leftOriginPos.x < doorSlide) {
				leftDoor.transform.position += new Vector3(moveSpeed, 0f, 0f);
			}
		}
		else{
			if(leftDoor.transform.position.x > leftOriginPos.x){
				leftDoor.transform.position += new Vector3(-moveSpeed, 0f, 0f);
			}
			if(rightDoor.transform.position.x < rightOriginPos.x){
				rightDoor.transform.position += new Vector3(moveSpeed, 0f, 0f);
			}
		}*/
		//if ( Input.GetKey( GameController.forwardKey ) ) {
		if ( Input.GetKey( KeyCode.W ) ) {
			transform.position += transform.forward * moveSpeed;
		}
		//if ( Input.GetKey( GameController.leftKey ) ) {
		if ( Input.GetKey( KeyCode.A ) ) {
			transform.Rotate(0f, -1 * turnSpeed * Time.deltaTime, 0f);
		}
		//if ( Input.GetKey( GameController.rightKey ) ) {
		if ( Input.GetKey( KeyCode.D) ) {
			transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
		}
		//if ( Input.GetKey( GameController.backKey ) ) {
		if ( Input.GetKey( KeyCode.S ) ) {
			transform.position += -transform.forward * moveSpeed;
		}
		//if ( Input.GetKey( GameController.upKey ) ) {
		if ( Input.GetKey( KeyCode.I ) ) {
			transform.position += transform.up * moveSpeed;
		}
		//if ( Input.GetKey( GameController.downKey ) ) {
		if ( Input.GetKey( KeyCode.K ) ) {	
			transform.position += -transform.up * moveSpeed;
		}
		if (Input.GetKeyDown(GameController.dropKey)) {
			//Rigidbody crb = this.GetComponentsInChildren<Rigidbody>();
			//crb.useGravity = true;
			this.transform.DetachChildren();
		}
		if(GameController.levelComplete && Input.GetKey(KeyCode.Return))
			Application.LoadLevel(3);
		}
		
		void OnCollisionEnter (Collision hit){
			if(hit.transform.gameObject.tag == "Pickup"){
				if(!hit.transform.parent == this)
					hit.transform.parent = this.transform;
				
				hit.rigidbody.useGravity = false;
			}
		}
		
		void OnTriggerEnter(Collider other) {
			if(other.transform.gameObject.tag == "tutComplete"){
				Debug.Log("Done!");
				GameController.levelComplete = true;
			}
		}
	}

