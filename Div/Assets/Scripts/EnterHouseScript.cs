using UnityEngine;
using System.Collections;

public class EnterHouseScript : MonoBehaviour {

	public GameObject player;
	private Vector3 shackdoor = new Vector3(-203f, -42.5f, 0f);

	void Awake() {
				player = GameObject.FindWithTag ("Player");
		}

	void OnMouseDown() {
		player.transform.position = shackdoor;
	}
}