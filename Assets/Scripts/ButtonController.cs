using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonController : MonoBehaviour {

	private Text textobj;
	private bool changeKey = false;

	public void LoadScene( int scene) {
		Application.LoadLevel(scene);
	}

	public void ExitApp () {
		Application.Quit();
	}

	// Use this for initialization
	void Start () {
		textobj = GetComponentInChildren<Text>();
		if (this.name == "Forward Key")
			textobj.text = "Forward: " + GameController.forwardKey.ToString();
		if (this.name == "Back Key")
			textobj.text = "Backward: " + GameController.backKey.ToString();
		if (this.name == "Left Key")
			textobj.text = "Left: " + GameController.leftKey.ToString();
		if (this.name == "Right Key")
			textobj.text = "Right: " + GameController.rightKey.ToString();
		if (this.name == "Up Key")
			textobj.text = "Ascend: " + GameController.upKey.ToString();
		if (this.name == "Down Key")
			textobj.text = "Descend: " + GameController.downKey.ToString();
		if (this.name == "Pickup Key")
			textobj.text = "Pick up: " + GameController.pickupKey.ToString();
		if (this.name == "Drop Key")
			textobj.text = "Drop: " + GameController.dropKey.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
