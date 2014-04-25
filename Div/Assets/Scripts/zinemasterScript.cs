using UnityEngine;
using System.Collections;

public class zinemasterScript : MonoBehaviour {
	public GameObject MainCamera;

	// Use this for initialization
	void Awake () {
		Object.DontDestroyOnLoad(MainCamera);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
