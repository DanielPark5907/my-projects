using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {
	public MeshRenderer colorPlayer;
	public Text Посхалка;

	void Update(){
		if (Input.GetKey (KeyCode.R))
			this.gameObject.GetComponent <MeshRenderer> ().material.color = Color.red;
		else if (Input.GetKey (KeyCode.P))
			this.gameObject.GetComponent <MeshRenderer> ().material.color = Color.magenta;
		else if (Input.GetKey (KeyCode.B))
			this.gameObject.GetComponent <MeshRenderer> ().material.color = Color.blue;
		else if (Input.GetKey (KeyCode.C))
			this.gameObject.GetComponent <MeshRenderer> ().material.color = Color.cyan;
		else if (Input.GetKey (KeyCode.U))
			Посхалка.text = "Кто двинется тот гей";
		else if (Input.GetKey(KeyCode.I))
			Посхалка.text = " ";
	}
}
