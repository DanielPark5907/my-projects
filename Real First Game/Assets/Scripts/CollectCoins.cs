using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections;

namespace lmao{
	public class CollectCoins : MonoBehaviour {
		[SerializeField] private Text scoreText;
		[SerializeField] private Text Winner;
		public int numberPoints;
		public int Score = 0;
		static private int TotalScore = 0;
		public GameObject NextLVL;

		private IEnumerator OnTriggerEnter(Collider other){
			if (other.gameObject.tag == "Coins") {
				TotalScore++;
				Score++;
				Destroy (other.gameObject);
				scoreText.text = "Score:" + Score;
				if (Score != numberPoints)
					scoreText.text = "Score:" + Score;
	
				if (Score >= numberPoints) {
					Winner.text = "You Win!";
					yield return new WaitForSeconds (3f);
					NextLVL.SetActive (true);
				}
			}
		}
	}
}