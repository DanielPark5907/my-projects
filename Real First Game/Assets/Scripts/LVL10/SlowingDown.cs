using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingDown : MonoBehaviour {
	Player pl;

	void Awake(){
		pl = GetComponent<Player> ();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.LeftAlt))
			pl.Cofactor = 0.5f;
		else if (Input.GetKeyUp (KeyCode.LeftAlt))
			pl.Cofactor = 1f;
	}
}
