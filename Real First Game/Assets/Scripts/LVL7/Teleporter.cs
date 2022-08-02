using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
	public Vector3 Coordinate;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player")
			other.gameObject.GetComponent<Transform> ().position = Coordinate;
	}
}
