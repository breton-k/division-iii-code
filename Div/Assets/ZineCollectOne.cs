using UnityEngine;
using System.Collections;

public class ZineCollectOne : MonoBehaviour {
	public static bool zineoneEnabled = false;
	public static bool zinetwoEnabled = false;
	public static bool zinethreeEnabled = false;
	public static bool zinefourEnabled = false;
	public static bool zinefiveEnabled = false;
	public static bool zinesixEnabled = false;
	public static bool zinesevenEnabled = false;
	public static bool zineeightEnabled = false;

	public GameObject zineone;
	public GameObject zinetwo;
	public GameObject zinethree;
	public GameObject zinefour;
	public GameObject zinefive;
	public GameObject zinesix;
	public GameObject zineseven;
	public GameObject zineeight;

	void Start() 
	
			{
		zineone = GameObject.Find("zineone");
		zinetwo = GameObject.Find("zinetwo");
		zinethree = GameObject.Find("zinethree");
		zinefour = GameObject.Find("zinefour");
		zinefive = GameObject.Find("zinefive");
		zinesix = GameObject.Find("zinesix");
		zineseven = GameObject.Find("zineseven");
		zineeight = GameObject.Find("zineeight");

		}


	void OnTriggerEnter (Collider zineone) {
		zineoneEnabled = true;
		Destroy (zineone.gameObject);
	}	

	void OnTriggerEnter2 (Collider zinetwo) {
		zinetwoEnabled = true;
		Destroy (zinetwo.gameObject);
	}

	void OnTriggerEnter3 (Collider zinethree) {
		zinethreeEnabled = true;
		Destroy (zinethree.gameObject);
	}

	void OnTriggerEnter4 (Collider zinefour) {
		zinefourEnabled = true;
		Destroy (zinefour.gameObject);
	}

	void OnTriggerEnter5 (Collider zinefive) {
		zinefiveEnabled = true;
		Destroy (zinefive.gameObject);
	}

	void OnTriggerEnter6 (Collider zinesix) {
		zinesixEnabled = true;
		Destroy (zinesix.gameObject);
	}

	void OnTriggerEnter7 (Collider zineseven) {
		zinesevenEnabled = true;
		Destroy (zineseven.gameObject);
	}

	void OnTriggerEnter8 (Collider zineeight) {
		zineeightEnabled = true;
		Destroy (zineeight.gameObject);
	}
}
