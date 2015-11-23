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

	public void ChangeKey() {
		if (this.name == "Forward Key"){
			changeKey = true;
			textobj.text = "Forward: Press a key";
		}
		/*if (this.name == "Back Key"){
			textobj.text = "Backward: Press a key";
		}
		if (this.name == "Left Key"){
			textobj.text = "Left: Press a key";
			GameController.leftKey = KeyCode.U;
		}
		if (this.name == "Right Key"){
			textobj.text = "Right: Press a key";
		}
		if (this.name == "Up Key"){
			textobj.text = "Ascend: Press a key";
		}
		if (this.name == "Down Key"){
			textobj.text = "Descend: Press a key";
		}*/
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
	}
	
	// Update is called once per frame
	void Update () {
		if (this.name == "Left Key" && !changeKey)
			textobj.text = "Left: " + GameController.leftKey.ToString();
		if (this.name == "Right Key" && !changeKey)
			textobj.text = "Right: " + GameController.rightKey.ToString();
	}
}
