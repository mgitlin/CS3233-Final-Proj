using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 0.1f;
	public float turnSpeed = 5f;
	public GameObject camCtrl;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameController.waitTime = Random.Range(0f, 2f);

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
		if (Input.GetKeyDown(GameController.dropKey)) {
			//Rigidbody crb = this.GetComponentsInChildren<Rigidbody>();
			//crb.useGravity = true;
			this.transform.DetachChildren();
		}
		if (GameController.levelComplete && Input.GetKey (KeyCode.Return)) {
			GameController.currentLevel++;
			Application.LoadLevel(GameController.currentLevel);
			GameController.levelComplete = false;
		}
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
