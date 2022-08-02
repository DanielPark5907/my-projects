using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {
	public GameObject PanelToNextLvl;

	IEnumerator OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			yield return new WaitForSeconds (3f);
			PanelToNextLvl.SetActive (true);
		}
	}
}
