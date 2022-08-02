using UnityEngine.SceneManagement;
using UnityEngine;

public class DeleteIf : MonoBehaviour {
	[SerializeField]private AudioSource Audio;

	void Update(){
		if (SceneManager.GetActiveScene().buildIndex == 3) {
			Debug.Log ("апчхиблять");
		}
	}

}
