using UnityEngine;
using System.Collections;

public class BackToFarm : MonoBehaviour {
	
	void OnTriggerStay(Collider shackdoor) {
		if (shackdoor.tag == "shackdoor" && Input.GetKeyDown(KeyCode.W)) 
		{
			Application.LoadLevel(1);
		}
	}
}