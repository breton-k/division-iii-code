using UnityEngine;
using System.Collections;

public class NPCscript : MonoBehaviour {
	public bool showGUI = false;
	
	void Update() {
	}
	
	public static bool sugarfarmerEnabled = false;
	
	public GameObject murf;

	
	void Awake() {
		murf = GameObject.FindWithTag("SugarFarmer");
	}
	
	void OnGUI () {
		if (!showGUI) {
			return; 
		}
		// Make a background box
		GUI.Box(new Rect(780,20,220,135), "Zines");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		GUI.enabled = sugarfarmerEnabled;
		if(GUI.Button(new Rect(800,50,30,30), "1")) {
			Application.LoadLevel(2);
		}
		
		GUI.enabled = true;
		
	}
}