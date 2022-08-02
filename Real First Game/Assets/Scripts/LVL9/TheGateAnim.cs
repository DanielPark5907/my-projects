using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGateAnim : MonoBehaviour {
	Animator Gate;

	void Start(){
		Gate = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			Gate.SetInteger ("Controller",1);
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			Gate.SetInteger ("Controller", 2);
		}
	}
}
