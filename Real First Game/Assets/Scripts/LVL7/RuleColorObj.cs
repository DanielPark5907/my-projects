using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleColorObj : MonoBehaviour {
	MeshRenderer Obj;
	public int Group;
	public Zone Zone1;
	public SpecialTeleport TP;

	void Awake(){
		Obj = GetComponent<MeshRenderer> ();
	}

	void Update(){
		if (Group == 1)
			IfInput1 ();
		if (Group == 2) {
			if (Zone1.Grupe == 1) {
				//IfInput1 ();
				IfInput2 ();
			}
		}
		if (Group == 3) {
			if (TP.Grape == 1) {
				IfInput3 ();
			}
		}
	}

	void IfColor(){
		if (Obj.material.color == Color.gray)
			Obj.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
		else
			Obj.gameObject.GetComponent<Rigidbody> ().isKinematic = true;

		if (Obj.material.color == Color.green)
			Obj.gameObject.GetComponent<Collider> ().isTrigger = true;
		else
			Obj.gameObject.GetComponent<Collider> ().isTrigger = false;

		if (Obj.material.color == Color.cyan)
			Obj.enabled = false;
		else
			Obj.enabled = true;
	}

	void IfInput1(){
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Obj.material.color = Color.gray;
			IfColor ();
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			Obj.material.color = Color.clear;
			IfColor ();
		}
	}
	void IfInput2(){
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Obj.material.color = Color.green;
			IfColor ();
		}else if (Input.GetKeyDown (KeyCode.Space)) {
			Obj.material.color = Color.clear;
			IfColor ();
		}
	}
	void IfInput3(){
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			Obj.material.color = Color.cyan;
			IfColor ();
		}else if (Input.GetKeyDown (KeyCode.Space)) {
			Obj.material.color = Color.clear;
			IfColor ();
		}
	}
}
