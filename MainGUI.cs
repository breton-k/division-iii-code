using UnityEngine;
using System.Collections;

public class MainGUI : MonoBehaviour {

	private Texture playButton;
	private Texture storyButton;
	private Texture quitButton;
	void Start() {
		playButton = (Texture)Resources.Load ("playButton.png");
		storyButton = (Texture)Resources.Load ("storyButton.png");
		quitButton = (Texture)Resources.Load ("quitButton.png");
	}


	void OnGUI() {
		if (GUI.Button (new Rect (125, 250, 150, 100), playButton))
			Application.LoadLevel("Level");

		if (GUI.Button (new Rect (325, 250, 150, 100), storyButton))
			print ("Display Story");

		if (GUI.Button (new Rect (525, 250, 150, 100), quitButton))
			Application.Quit();
	}
}