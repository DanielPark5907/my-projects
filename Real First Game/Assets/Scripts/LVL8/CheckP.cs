using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckP : MonoBehaviour {
	public Player pl;
	public Vector3 Coordinate;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			pl.teleport = Coordinate;
		}
	}
}
