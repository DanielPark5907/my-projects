using UnityEngine;

public class Checpoint : MonoBehaviour {
	public MPlayer6 ChekPoint;
	public Vector3 Coordinate;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			ChekPoint.teleport = Coordinate;
		}
	}
}
