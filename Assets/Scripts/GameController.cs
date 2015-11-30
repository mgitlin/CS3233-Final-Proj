using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public static KeyCode upKey = KeyCode.UpArrow;
	public static KeyCode downKey = KeyCode.DownArrow;
	public static KeyCode forwardKey = KeyCode.W;
	public static KeyCode backKey = KeyCode.S;
	public static KeyCode leftKey = KeyCode.A;
	public static KeyCode rightKey = KeyCode.D;
	public static KeyCode pickupKey = KeyCode.I;
	public static KeyCode dropKey = KeyCode.O;

	public static bool tutComplete = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
			Application.LoadLevel(0);
	}
}
