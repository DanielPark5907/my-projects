using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour {
	public GameObject EnabledObj;
	public int Grupe;

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Change") {
			if (other.gameObject.GetComponent<MeshRenderer> ().material.color == Color.gray) {
				Grupe = 1;
				EnabledObj.SetActive (true);
			}
		}
	}
}
