using UnityEngine;
using UnityEngine.UI;

public class MP10 : MonoBehaviour {
	public bool isGrounded;
	public float HSpeed;
	public float VSpeed;
	public float Cofactor;
	public float JumpForce;
	Rigidbody rb;
	Transform transformPlayer;
	public Vector3 teleport;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		transformPlayer = GetComponent<Transform> ();
	}

	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Road" || other.gameObject.tag == "Platform") {
			isGrounded = true;
			//Cofactor = 1;
		}
		
		if (other.gameObject.tag == "Platform") {
			this.transform.parent = other.transform;
			Cofactor = 0;
		}
	}

	void OnCollisionExit(Collision other){
		if (other.gameObject.tag == "Road" || other.gameObject.tag == "Platform") {
			isGrounded = false;
			Cofactor = 1;
		}
		if (other.gameObject.tag == "Platform") {
			this.transform.parent = null;
		}
	}

	void FixedUpdate(){
			rb.velocity = new Vector3 (Input.GetAxis ("Horizontal") * HSpeed * Time.fixedDeltaTime, rb.velocity.y, VSpeed * Cofactor * Time.fixedDeltaTime);

		if (this.gameObject.GetComponent<Transform> ().position.y >= 30f || this.gameObject.GetComponent<Transform> ().position.y <= -5f)
			transformPlayer.position = teleport;
		if (Cofactor <= 0)
			rb.velocity = new Vector3 (Input.GetAxis ("Horizontal") * HSpeed * Time.fixedDeltaTime, rb.velocity.y,Input.GetAxis("Vertical")* VSpeed * Time.fixedDeltaTime);
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {
			GetComponent<Rigidbody>().AddForce (0, JumpForce, 0);
		}
		if (Input.GetKeyDown (KeyCode.X)&& Cofactor!= 0)
			Cofactor = 0.5f;
		else if (Input.GetKeyUp (KeyCode.X) && Cofactor!= 0)
			Cofactor = 1f;
		if (Input.GetKeyDown (KeyCode.Q) && Cofactor!= 0)
			Cofactor = 2f;
		else if (Input.GetKeyUp (KeyCode.Q) && Cofactor!= 0)
			Cofactor = 1f;
	}
}