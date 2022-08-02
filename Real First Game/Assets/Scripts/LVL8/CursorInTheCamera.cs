using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RootMotion {
	public class CursorInTheCamera : MonoBehaviour {
		CameraController cam;

		void Start(){
			cam = GetComponent<CameraController> ();
		}

		void Update(){
			if (Input.GetKeyDown (KeyCode.LeftShift))
				cam.lockCursor = false;
			else if (Input.GetKeyUp (KeyCode.LeftShift))
				cam.lockCursor = true;
		}
	}
}