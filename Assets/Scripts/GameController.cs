﻿using UnityEngine;
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
	public static float waitTime = 0.0f;
	public static string moves = "forward";
	public static string moveX = "right";
	public static string moveY = "up";
	public static string moveZ = "forward";

	public static bool levelComplete = false;

	public static int currentLevel = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
			Application.LoadLevel(0);
	}
}
