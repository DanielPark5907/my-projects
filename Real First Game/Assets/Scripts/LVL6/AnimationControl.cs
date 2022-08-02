using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {
	
	void FixedUpdate(){
		GetComponent<Animation>().Play ("Fly");
	}
}
