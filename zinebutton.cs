using UnityEngine;
using System.Collections;

public class zinebutton : MonoBehaviour {
	
	void OnGUI() {
		if (GUI.Button (new Rect (Screen.width - 100,Screen.height - 50,100,50), "Zines")) {
			print ("Open Zine Screen!");
		}
	}
}