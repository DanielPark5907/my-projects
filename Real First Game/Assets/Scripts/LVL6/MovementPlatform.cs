using UnityEngine;

public class MovementPlatform : MonoBehaviour {
	bool Moveing;
	public int MovementCoordinate;
	public float Speed;
	public float Distance1;
	public float Distance2;

	void Update(){
		if (MovementCoordinate == 1) {
			if (transform.position.x > Distance1)
				Moveing = false;
			else if (transform.position.x < Distance2)
				Moveing = true;

			if (Moveing)
				transform.position = new Vector3 (transform.position.x + Speed * Time.fixedDeltaTime, transform.position.y, transform.position.z);
			else if (!Moveing)
				transform.position = new Vector3 (transform.position.x - Speed * Time.fixedDeltaTime, transform.position.y, transform.position.z);
		} else if (MovementCoordinate == 2) {
			if (transform.position.y > Distance1)
				Moveing = false;
			else if (transform.position.y < Distance2)
				Moveing = true;

			if (Moveing)
				transform.position = new Vector3 (transform.position.x, transform.position.y + Speed * Time.fixedDeltaTime, transform.position.z);
			else if (!Moveing)
				transform.position = new Vector3 (transform.position.x, transform.position.y - Speed * Time.fixedDeltaTime, transform.position.z);
		}else if (MovementCoordinate == 3) {
			if (transform.position.z > Distance1)
				Moveing = false;
			else if (transform.position.z < Distance2)
				Moveing = true;
		
			if (Moveing)
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + Speed * Time.fixedDeltaTime);
			else if (!Moveing)
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - Speed * Time.fixedDeltaTime);
		}
	}
}
