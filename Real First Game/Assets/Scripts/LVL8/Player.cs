using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public bool isGrounded;
	public float HSpeed;
	public float VSpeed;
	public float Cofactor = 1;
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

	void FixedUpdate(){
		rb.velocity = new Vector3 (Input.GetAxis ("Horizontal") * HSpeed * Time.fixedDeltaTime, rb.velocity.y,VSpeed * Cofactor * Time.fixedDeltaTime);

		if (this.gameObject.GetComponent<Transform> ().position.y >= 30f || this.gameObject.GetComponent<Transform> ().position.y <= -5f)
			transformPlayer.position = teleport;
		if (Cofactor == 0)
			rb.velocity = new Vector3 (Input.GetAxis ("Horizontal") * HSpeed * Time.fixedDeltaTime, rb.velocity.y,Input.GetAxis("Vertical")* VSpeed * Time.fixedDeltaTime);
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {
			isGrounded = false;
			GetComponent<Rigidbody>().AddForce (0, JumpForce, 0);
		}
	}
}
