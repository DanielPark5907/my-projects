using UnityEngine;

public class fCamera : MonoBehaviour {
	public Transform playerTransform;
	public Vector3 offset;

	void Update(){
		transform.position = playerTransform.position + offset;
	}
}
