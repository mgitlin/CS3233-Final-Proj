using UnityEngine;
using System.Collections;

public class PersistOnLoad : MonoBehaviour {

	private static PersistOnLoad instance = null;
	public static PersistOnLoad Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
}
