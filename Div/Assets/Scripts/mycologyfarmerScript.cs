using UnityEngine;
using System.Collections;

public class mycologyfarmerScript : MonoBehaviour {
	public bool showGUI = false;
	public static bool mycologyfarmerGUI = false;
	public GameObject mycologyFarmer;
	
	public string sugarfarmerSpeech1 = "Welcome to the farm! Feel free to look around. If you come back after you've read some books, I can help you out.";
	public string sugarfarmerSpeech2 = "This is what I say to you after you know how to make maple syrup.";
	
	public string mycologyfarmerSpeech1 = "This is what I say to you before you pick up your second zine.";
	public string mycologyfarmerSpeech2 = "Let's grow some mushrooms";
	public string mycologyfarmerSpeech3 = "Here's a bunch of stuff about mycology and maple syrup.";
	public string mycologyfarmerSpeech4 = "Welcome to the farm! Feel free to look around. If you come back after you've read some books, I can help you out.";
	
	public GameObject zineone;
	public GameObject zinetwo;
	public GameObject zinethree;
	public GameObject zinefour;
	public GameObject zinefive;
	public GameObject zinesix;
	public GameObject zineseven;
	public GameObject zineeight;
	
	private Rect mycologyfarmerRect = new Rect (20, 20, (Screen.width)-40, 70);
	
	
	void Awake() {
		mycologyFarmer = GameObject.FindWithTag("mycologyFarmer");
		
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
		mycologyfarmerGUI = !mycologyfarmerGUI;
	}
	
	void OnGUI () {
		if (mycologyfarmerGUI)
			mycologyfarmerRect = GUI.Window (0, mycologyfarmerRect, WindowFunction, "Mycology Farmer");
	}
	
	
	void WindowFunction (int windowID) {

		if(zinetwo != null) {
			GUILayout.Label (mycologyfarmerSpeech1);
				}

		if (zinetwo == null) {
			GUILayout.Label (mycologyfarmerSpeech2);
		}

/*		else if(zineone == null && zinetwo == null) {
			GUILayout.Label (mycologyfarmerSpeech3);
		}

		else(zineone != null && zinetwo != null) {
			GUILayout.Label (mycologyfarmerSpeech4);
		} */
		
	}
	
}