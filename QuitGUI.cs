using UnityEngine;
using System.Collections;

public class QuitGUI : MonoBehaviour {


	// Use this for initialization
	private Texture quitButton; 
	void Start() { 
		quitButton = (Texture)Resources.Load("quitButton"); 
	} 

	void OnGUI() { 
		if (GUI.Button(new Rect(50, 50, 100, 20), quitButton)); 
		Application.Quit();
	}
}
