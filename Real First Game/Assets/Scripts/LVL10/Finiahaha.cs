using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RootMotion{
	public class Finiahaha : MonoBehaviour {
		[Header("NEXT LVL")]
		public GameObject PanelToNextLvl;

		[Header("Objects")]
		public CameraController Cam;
		public MP10 Player;

		IEnumerator OnCollisionEnter(Collision other){
			if (other.gameObject.tag == "Player") {
				Cam.lockCursor = false;
				Player.Cofactor = 0f;
				yield return new WaitForSeconds (0.5f);
				PanelToNextLvl.SetActive (true);
			}
		}
	}
}
