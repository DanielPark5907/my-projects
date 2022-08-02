using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveP : MonoBehaviour {
	[Header("Скорость")]
	public float Speed;
	[Header("Дистанция:Большая(1),Меньшая(2)")]
	public float Distance1;
	public float Distance2;
	[Header("Координата(1-x;2-y;3-z)")]
	public int MovementCoordinate;
	Vector3 input;

	void OnCollisionEnter(Collision other){
		other.transform.parent = transform;
	}
	void OnCollisionExit(Collision other){
		other.transform.parent = null;
	}

	void Update(){
		if (MovementCoordinate == 1)
			If1 ();
		if (MovementCoordinate == 2)
			If2 ();
		if (MovementCoordinate == 3)
			If3 ();
		transform.position = transform.position + input * Time.deltaTime * Speed;
	}
	void If1(){
		if (transform.position.x >= Distance1)
			Speed = -Speed;
		else if (transform.position.x <= Distance2)
			Speed = -Speed;
		input = new Vector3 (1, 0, 0);
	}
	void If2(){
		if (transform.position.y >= Distance1)
			Speed = -Speed;
		else if (transform.position.y <= Distance2)
			Speed = -Speed;
		input = new Vector3 (0, 1, 0);
	}
	void If3(){
		if (transform.position.z >= Distance1)
			Speed = -Speed;
		else if (transform.position.z <= Distance2)
			Speed = -Speed;
		input = new Vector3 (0, 0, 1);
	}
}
