using UnityEngine;

public class Rotate : MonoBehaviour {
	public float RY = 0;
	public int Num;

	void Update(){
		if (Num == 1) {
			this.gameObject.GetComponent <Transform> ().Rotate (0 + RY * Time.deltaTime, 0, 0);
			NRotate (1);
		}else if (Num == -1) {
			this.gameObject.GetComponent <Transform> ().Rotate (0 + -RY * Time.deltaTime, 0, 0);
			NRotate (-1);
		}else if (Num == 2) {
			this.gameObject.GetComponent <Transform> ().Rotate (0, 0 + RY * Time.deltaTime, 0);
			NRotate (2);
		}else if (Num == -2) {
			this.gameObject.GetComponent <Transform> ().Rotate (0, 0 + -RY * Time.deltaTime, 0);
			NRotate (-2);
		} else if (Num == 3) {
			this.gameObject.GetComponent <Transform> ().Rotate (0, 0, 0 + RY * Time.deltaTime);
			NRotate (3);
		}else if (Num == -3) {
			this.gameObject.GetComponent <Transform> ().Rotate (0, 0, 0 + -RY * Time.deltaTime);
			NRotate (-3);
		}
	}

	private void NRotate(int NUM){
		if (Input.GetKey (KeyCode.P)) {
			if (NUM == 1)
				Debug.Log (this.gameObject.name + "Rotate:X");
			else if (NUM == -1)
				Debug.Log (this.gameObject.name + "Rotate:-X");
			else if (NUM == 2)
				Debug.Log (this.gameObject.name + " Rotate:Y");
			else if (NUM == -2)
				Debug.Log (this.gameObject.name + "Rotate:-Y");
			else if (NUM == 3)
				Debug.Log (this.gameObject.name + "Rotate:Z");
			else if (NUM == -3)
				Debug.Log (this.gameObject.name + "Rotate:-Z");
		}
	}
}
