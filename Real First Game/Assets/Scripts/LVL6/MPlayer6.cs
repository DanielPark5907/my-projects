using UnityEngine;

public class MPlayer6 : MonoBehaviour {
	public bool isGrounded;
	public float speed;
	public float JumpForce;
	Rigidbody rb;
	Transform transformPlayer;
	public Vector3 teleport;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		transformPlayer = GetComponent<Transform> ();
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Road")
			isGrounded = true;
	}

	void FixedUpdate(){//Input.GetAxis ("Horizontal") * speed * Time.fixedDeltaTime,
		rb.velocity = new Vector3 (Input.GetAxis ("Vertical") * speed * Time.fixedDeltaTime, rb.velocity.y, Input.GetAxis ("Horizontal") * -speed * Time.fixedDeltaTime);

		if (this.gameObject.GetComponent<Transform> ().position.y >= 30f || this.gameObject.GetComponent<Transform> ().position.y <= -30f)
			transformPlayer.position = teleport;
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {
			isGrounded = false;
			GetComponent<Rigidbody>().AddForce (0, JumpForce, 0);
		}
	}
}
