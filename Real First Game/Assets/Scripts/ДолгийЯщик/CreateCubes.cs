using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class CreateCubes : MonoBehaviour {
	public GameObject Cube;
	public Vector3 Position;
	public Text txt;
	public float Wait;
	bool Create = true;
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

	void OnTriggerEnter(Collider other){
		if (Create == true) {
			if (other.gameObject.tag == "Player") {
				Instantiate (Cube, Position, Quaternion.Euler (0, 0, 0));
				Create = false;
				Wait = 0;
			}
		}
	}

	IEnumerator Timer(){
		while (true) {
			yield return new WaitForSecondsRealtime (1f);
			Wait = Wait + 0.05f;
		}
	}
}
