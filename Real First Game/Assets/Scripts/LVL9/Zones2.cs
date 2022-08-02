using UnityEngine;

public class Zones2 : MonoBehaviour {
	public GameObject EnabledObj;

	void OnTriggerEnter(){
		EnabledObj.SetActive (false);
	}
	void OnTriggerExit(){
		EnabledObj.SetActive (true);
	}
}