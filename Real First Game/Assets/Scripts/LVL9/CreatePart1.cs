using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class CreatePart1 : MonoBehaviour {
	public Text txt;
	public float Wait;
	public bool Create = true;
	IEnumerator rutine;

	void Start(){
		rutine = Timer();
	}

	void Update(){
		if (Wait < 60f) {
			Create = false;
			StartCoroutine (rutine);
			txt.text = Mathf.Round (Wait) + "/60";
		} else if (Wait >= 60f) {
			Create = true;
			StopCoroutine (rutine);
			txt.text = "Ready";
		}
	}
	IEnumerator Timer(){
		while (true) {
			yield return new WaitForSecondsRealtime (1f);
			Wait = Wait + 0.05f;
		}
	}
}
