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

	void Awake() {
		zineone = GameObject.FindWithTag("ZineOne");
		zinetwo = GameObject.FindWithTag("ZineTwo");
		zinethree = GameObject.FindWithTag("ZineThree");
		zinefour = GameObject.FindWithTag("ZineFour");
		zinefive = GameObject.FindWithTag("ZineFive");
		zinesix = GameObject.FindWithTag("ZineSix");
		zineseven = GameObject.FindWithTag("ZineSeven");
		zineeight = GameObject.FindWithTag("ZineEight");
	}


	void OnTriggerEnter (Collider zine) {
		if (zine.collider.tag == "ZineOne") {
			zineoneEnabled = !zineoneEnabled;
			Destroy(zineone.gameObject);
		}
	
		else
		if (zine.collider.tag == "ZineTwo") {
			zinetwoEnabled = !zinetwoEnabled;
			Destroy(zinetwo.gameObject);
		}

		else
		if (zine.collider.tag == "ZineThree") {
			zinethreeEnabled = !zinethreeEnabled;
			Destroy(zinethree.gameObject);
		}

		else
		if (zine.collider.tag == "ZineFour") {
			zinefourEnabled = !zinefourEnabled;
			Destroy(zinefour.gameObject);
		}
	
		else
		if (zine.collider.tag == "ZineFive") {
			zinefiveEnabled = !zinefiveEnabled;
			Destroy(zinefive.gameObject);
		}
	
		else
		 if (zine.collider.tag == "ZineSix") {
			zinesixEnabled = !zinesixEnabled;
			Destroy(zinesix.gameObject);
		}

		else
		if (zine.collider.tag == "ZineSeven") {
			zinesevenEnabled = !zinesevenEnabled;
			Destroy(zineseven.gameObject);
		}

		else
		if (zine.collider.tag == "ZineEight") {
			zineeightEnabled = !zineeightEnabled;
			Destroy(zineeight.gameObject);
		}
	}
}
