using UnityEngine;
using UnityEngine.UI;

public class MPlayer : MonoBehaviour {
	public float speed;
	Rigidbody rb;
	Transform transformPlayer;
	public Vector3 teleport;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		transformPlayer = GetComponent<Transform> ();
	}

	void FixedUpdate(){
		rb.velocity = new Vector3 (Input.GetAxis ("Horizontal") * speed * Time.fixedDeltaTime, rb.velocity.y, Input.GetAxis ("Vertical") * speed * Time.fixedDeltaTime);

		if (this.gameObject.GetComponent<Transform> ().position.y >= 30f || this.gameObject.GetComponent<Transform> ().position.y <= -30f)
			transformPlayer.position = teleport;
	}
}
