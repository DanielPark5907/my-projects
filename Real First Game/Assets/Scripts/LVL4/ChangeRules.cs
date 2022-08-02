using UnityEngine;

public class ChangeRules : MonoBehaviour {
	public GameObject Box;
	public float Flying;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			if (other.gameObject.GetComponent <MeshRenderer> ().material.color == Color.red) {
				if (this.gameObject.tag == "Invisible") {
					Destroy (Box.gameObject);
				}
			}
			if (other.gameObject.GetComponent<MeshRenderer> ().material.color == Color.magenta) {
				if (this.gameObject.tag == "Block") {
					this.gameObject.GetComponent<Collider> ().isTrigger = true;
				}
			}
			if (other.gameObject.GetComponent<MeshRenderer> ().material.color == Color.cyan) {
				if (this.gameObject.tag == "Rotate") {
					this.gameObject.GetComponent<Rigidbody> ().mass = 0.0001f;
				}
			}
			if (other.gameObject.GetComponent<MeshRenderer> ().material.color == Color.blue) {
				if (this.gameObject.tag == "Flying")
					this.gameObject.GetComponent<Transform> ().position = this.gameObject.GetComponent<Transform> ().position + new Vector3 (0, 0 + Flying * 5f , 0);
			}
		}
	}

	void FixedUpdate(){
		if (this.gameObject.GetComponent<Transform> ().position.y >= 30f || this.gameObject.GetComponent<Transform> ().position.y <= -30f) {
			DestroyObject (this.gameObject);
		}
	}
}
