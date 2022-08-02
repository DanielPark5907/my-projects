using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledZoVardo : MonoBehaviour {
	ZoVardo EnabledZoVarudo;
	void Start () {
		EnabledZoVarudo = GetComponent<ZoVardo> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			EnabledZoVarudo.enabled = false;
		else if (Input.GetKeyUp (KeyCode.Space))
			EnabledZoVarudo.enabled = true;
	}
}
