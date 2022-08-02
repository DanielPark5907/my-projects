using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuDio : MonoBehaviour {
	public AudioSource Dio;
	public AudioClip ZoWarudo;

	void Update (){
		if (Input.GetKeyDown (KeyCode.Space)) {
			Dio.PlayOneShot (ZoWarudo);
		}
	}
}
