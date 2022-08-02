using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {
	public void ChangeScenes(int numScene){
		SceneManager.LoadScene (numScene);
	}

	public void Exit(){
		Application.Quit ();
	}

	public void ChangeToMenu(){
		SceneManager.LoadScene (0);
	}
}
