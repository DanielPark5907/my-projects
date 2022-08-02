using UnityEngine;

public class FollowingCamera : MonoBehaviour {
	public Transform Player;
	Vector3 Target;

	public float TrackingSpeed = 1.5f;

	void Update (){
		if (Player)
		{
			Vector3 currentPossition = Vector3.Lerp (transform.position, Target, TrackingSpeed * Time.deltaTime);
			transform.position = currentPossition;

			Target = new Vector3 (Player.transform.position.x, Player.transform.position.y, transform.position.z);
		}
	}
}
