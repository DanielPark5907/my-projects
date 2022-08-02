using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePart2 : MonoBehaviour {
	public GameObject Cube;
	public Vector3 Position;
	public CreatePart1 time;

	void OnTriggerEnter(Collider other){
		if (time.Create == true) {
			if (other.gameObject.tag == "Player") {
				Instantiate (Cube, Position, Quaternion.Euler (0, 0, 0));
				time.Create = false;
				time.Wait = 0;
			}
		}
	}
}
