using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemys : MonoBehaviour {
	[Header("Lose Text")]
	public Text Lose;

	[Header("Wait Time")]
	public float Wait;

	[Header("Repulsion")]
	public Vector3 Repuls;

	IEnumerator OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Rigidbody> ().AddForce (Repuls);
			Lose.text = "You lose dude";
			yield return new WaitForSeconds (Wait);
			Lose.text = " ";
			other.gameObject.GetComponent<Transform> ().position = other.gameObject.GetComponent<Player>().teleport;
		}
	}
}
