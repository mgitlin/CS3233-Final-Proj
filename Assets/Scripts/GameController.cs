using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public static KeyCode upKey = KeyCode.Space;
	public static KeyCode downKey = KeyCode.LeftControl;
	public static KeyCode forwardKey = KeyCode.W;
	public static KeyCode backKey = KeyCode.S;
	public static KeyCode leftKey = KeyCode.A;
	public static KeyCode rightKey = KeyCode.D;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
			Application.LoadLevel(0);
	}
}
