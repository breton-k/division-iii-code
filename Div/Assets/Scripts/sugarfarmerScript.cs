using UnityEngine;
using System.Collections;

public class sugarfarmerScript : MonoBehaviour {
	public bool showGUI = false;
	public static bool sugarfarmerGUI = false;
	public GameObject sugarFarmer;

	public string sugarfarmerSpeech1 = "Welcome to the farm! Feel free to look around. If you come back after you've read some books, I can help you out.";
	public string sugarfarmerSpeech2 = "This is what I say to you after you know how to make maple syrup.";

	public GameObject zineone;
	public GameObject zinetwo;
	public GameObject zinethree;
	public GameObject zinefour;
	public GameObject zinefive;
	public GameObject zinesix;
	public GameObject zineseven;
	public GameObject zineeight;
	
	private Rect sugarfarmerRect = new Rect (20, 20, (Screen.width)-40, 70);


	void Awake() {
		sugarFarmer = GameObject.FindWithTag("SugarFarmer");
		
		zineone = GameObject.FindWithTag("ZineOne");
		zinetwo = GameObject.FindWithTag("ZineTwo");
		zinethree = GameObject.FindWithTag("ZineThree");
		zinefour = GameObject.FindWithTag("ZineFour");
		zinefive = GameObject.FindWithTag("ZineFive");
		zinesix = GameObject.FindWithTag("ZineSix");
		zineseven = GameObject.FindWithTag("ZineSeven");
		zineeight = GameObject.FindWithTag("ZineEight");
	}







	void OnMouseDown() {
		sugarfarmerGUI = !sugarfarmerGUI;
	}

	void OnGUI () {
		if (sugarfarmerGUI)
			sugarfarmerRect = GUI.Window (0, sugarfarmerRect, WindowFunction, "Maple Sugar Farmer");
	}
	
	
	void WindowFunction (int windowID) {
		if (zineone != null) {
			GUILayout.Label (sugarfarmerSpeech1);
		}
		
		if (zineone == null) {
			GUILayout.Label (sugarfarmerSpeech2);
		}
		
	}

}
