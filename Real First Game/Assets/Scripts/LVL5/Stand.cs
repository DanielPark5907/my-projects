using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stand : MonoBehaviour {
	public GameObject Player;

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			Player.GetComponent<MeshRenderer> ().material.color = Color.yellow;
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			GetComponent<MeshRenderer> ().material.color = Color.white;
		}
	}
}
