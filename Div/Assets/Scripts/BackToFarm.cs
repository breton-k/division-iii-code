using UnityEngine;
using System.Collections;

public class BackToFarm : MonoBehaviour {
	public GameObject player;
	private Vector3 shackdoor = new Vector3(3f, -2f, 0f);
	
	void Awake() {
		player = GameObject.FindWithTag ("Player");
	}
	
	void OnMouseDown() {
		player.transform.position = shackdoor;
	}
}