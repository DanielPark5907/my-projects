using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour {
	public static bool GameIsPaused = false;
	public GameObject PauseMenuUI;
	public GameObject Settings;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(GameIsPaused)
				Resume();
			else 
				PauseM();
		}
	}
	public void Resume(){
		PauseMenuUI.SetActive (false);
		Settings.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	void PauseM(){
		PauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void ToMenu(){
		PauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		SceneManager.LoadScene (0);
	}
	public void ToExit(){
		Application.Quit ();
	}
}