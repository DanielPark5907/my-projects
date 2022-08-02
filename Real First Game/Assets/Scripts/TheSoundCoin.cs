using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSoundCoin : MonoBehaviour {
	public AudioSource Sound;
	public AudioClip Coin;
	public AudioClip Portal;
	public AudioClip GateOpen;
	public AudioClip GateClose;

	IEnumerator OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Coins") {
			Sound.PlayOneShot (Coin, 0.2f);
		} else if (other.gameObject.tag == "Portal")
			Sound.PlayOneShot (Portal, 1f);
		else if (other.gameObject.tag == "Gate") {
			Sound.PlayOneShot (GateOpen, 0.2f);
			yield return new WaitForSeconds (4.5f);
			Sound.PlayOneShot (GateClose, 0.2f);
		}
	}
}
