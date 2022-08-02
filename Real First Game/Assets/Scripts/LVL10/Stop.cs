using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour {
	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Player")
			other.gameObject.GetComponent<Player> ().Cofactor = 0;
	}

	IEnumerator OnCollisionExit(Collision other){
		if (other.gameObject.tag == "Player") {
			yield return new WaitForSeconds (0.2f);
			other.gameObject.GetComponent<Player> ().Cofactor = 1;
		}
	}
}
