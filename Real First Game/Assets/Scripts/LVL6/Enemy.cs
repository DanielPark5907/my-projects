using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	public Text Lose;

	IEnumerator OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Rigidbody> ().AddForce (0, 1000, 15000);
			Lose.text = "You lose";
			yield return new WaitForSeconds (3f);
			Lose.text = " ";
			other.gameObject.GetComponent<Transform> ().position = new Vector3 (0, 2, 0);
		}
	}
}
