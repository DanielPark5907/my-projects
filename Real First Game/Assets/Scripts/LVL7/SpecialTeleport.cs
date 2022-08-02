using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialTeleport : MonoBehaviour {
	public int Grape;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			Grape = 1;
		}
	}
}
