using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace lmao{
	public class LoadScene : MonoBehaviour {
		public CollectCoins ok;
		public int Need;
	
		void OnTriggerEnter(){	
			if (ok.Score >= Need) {
				SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex +1);
			}
		}
	}
}