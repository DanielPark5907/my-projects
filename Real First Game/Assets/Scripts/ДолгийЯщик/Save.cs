using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour {
	public Button LVL1;
	public Button LVL2;
	int levelComlete;

	void Start () {
		levelComlete = PlayerPrefs.GetInt ("LevelComplete");
		LVL1.interactable = false;
		LVL2.interactable = false;

		switch (levelComlete) {
		case 1:
			LVL1.interactable = true;
			break;
		case 2:
			LVL1.interactable = true;
			LVL2.interactable = true;
			break;
		}
	}

	public void LoadTo(int level){
		SceneManager.LoadScene (level);
	}

	public void Reset(){
		LVL1.interactable = false;
		LVL2.interactable = false;
	}
}
