using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones : MonoBehaviour {
	public GameObject EnabledObj;

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Change") {
				EnabledObj.SetActive (true);
		}
	}
}