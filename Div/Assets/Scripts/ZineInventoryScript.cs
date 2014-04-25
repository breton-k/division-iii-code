using UnityEngine;
using System.Collections;

public class ZineInventoryScript : MonoBehaviour {
	public bool showGUI = false;

	void Update() {
				//Press "Z" to show all zines.
		if (Input.GetKeyDown (KeyCode.Z)) {
						showGUI = !showGUI;
				}

				//If the zine on level Main has been destroyed (picked up by character) it will
				//display as null and that level will be accessible. 

				//This is also how we communicate with the NPCs. A null return determines what 
				//the characters say to the protagonist.
		if (zineone == null) {
			zineoneEnabled = !zineoneEnabled;
		}

		if (zinetwo == null) {
			zinetwoEnabled = !zinetwoEnabled;
		}

		if (zinethree == null) {
			zinethreeEnabled = !zinethreeEnabled;
		}

		if (zinefour == null) {
			zinefourEnabled = !zinefourEnabled;
		}

		if (zinefive == null) {
			zinefiveEnabled = !zinefiveEnabled;
		}

		if (zinesix == null) {
			zinesixEnabled = !zinesixEnabled;
		}

		if (zineseven == null) {
			zinesevenEnabled = !zinesevenEnabled;
		}

		if (zineeight == null) {
			zineeightEnabled = !zineeightEnabled;
		}
	}

	public static bool zineoneEnabled = false;
	public static bool zinetwoEnabled = false;
	public static bool zinethreeEnabled = false;
	public static bool zinefourEnabled = false;
	public static bool zinefiveEnabled = false;
	public static bool zinesixEnabled = false;
	public static bool zinesevenEnabled = false;
	public static bool zineeightEnabled = false;

	public GameObject zineone;
	public GameObject zinetwo;
	public GameObject zinethree;
	public GameObject zinefour;
	public GameObject zinefive;
	public GameObject zinesix;
	public GameObject zineseven;
	public GameObject zineeight;

	void Awake() {
		zineone = GameObject.FindWithTag("ZineOne");
		zinetwo = GameObject.FindWithTag("ZineTwo");
		zinethree = GameObject.FindWithTag("ZineThree");
		zinefour = GameObject.FindWithTag("ZineFour");
		zinefive = GameObject.FindWithTag("ZineFive");
		zinesix = GameObject.FindWithTag("ZineSix");
		zineseven = GameObject.FindWithTag("ZineSeven");
		zineeight = GameObject.FindWithTag("ZineEight");
		}

	void OnGUI () {
		if (!showGUI) {
						return; 
				}

		{
			GUI.depth = 2;
			// Make a background box
			GUI.Box (new Rect (780, 20, 220, 135), "Zines");
		}


		GUI.depth = 1;
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		GUI.enabled = zineoneEnabled;
		if(GUI.Button(new Rect(800,50,30,30), "1")) {
			Application.LoadLevel(3);
		}

		GUI.enabled = zinetwoEnabled;
		if(GUI.Button(new Rect(850,50,30,30), "2")) {
			Application.LoadLevel(4);
		}
		GUI.enabled = zinethreeEnabled;
		if(GUI.Button(new Rect(900,50,30,30), "3")) {
			Application.LoadLevel(5);
		}
		GUI.enabled = zinefourEnabled;
		if(GUI.Button(new Rect(950,50,30,30), "4")) {
			Application.LoadLevel(6);
		}
		
		// Make the second row.
		GUI.enabled = zinefiveEnabled;
		if (GUI.Button (new Rect (800, 100, 30, 30), "5")) {
			Application.LoadLevel (7);
		}

		GUI.enabled = zinesixEnabled;
		if(GUI.Button(new Rect(850,100,30,30), "6")) {
			Application.LoadLevel(8);
		}

		GUI.enabled = zinesevenEnabled;
		if(GUI.Button(new Rect(900,100,30,30), "7")) {
			Application.LoadLevel(9);
		}

		GUI.enabled = zineeightEnabled;
		if(GUI.Button(new Rect(950,100,30,30), "8")) {
				Application.LoadLevel(10);
		}

		GUI.enabled = true;

	}
}