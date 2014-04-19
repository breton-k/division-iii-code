using UnityEngine;
using System.Collections;

public class EnterHouseScript : MonoBehaviour {
	
	void OnTriggerStay(Collider door) {
		if (door.tag == "door" && Input.GetKeyDown(KeyCode.W)) 
			{
			Application.LoadLevel(2);
				}
	}
}