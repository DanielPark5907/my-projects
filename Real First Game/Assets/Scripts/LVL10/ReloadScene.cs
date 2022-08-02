using UnityEngine.SceneManagement;
using UnityEngine;

public class ReloadScene : MonoBehaviour {
	void Update (){
		if (Input.GetKey (KeyCode.L))
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
