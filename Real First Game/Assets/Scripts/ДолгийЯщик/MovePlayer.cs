using UnityEngine;
using System;

namespace lmao{
	public class MovePlayer : MonoBehaviour {
		[SerializeField] private float Speed = 5f;
		[NonSerialized] public Rigidbody _rb;
		public Transform transformPlayer;
		private Vector3 teleport;

		private void Awake (){
			_rb = GetComponent <Rigidbody> ();
			teleport = new Vector3 (0, 1, 0);
		}

		void FixedUpdate(){
			float h = Input.GetAxis ("Horizontal");
			float v = Input.GetAxis ("Vertical");

			_rb.AddForce (new Vector3 (h, 0, v) * Speed * Time.fixedDeltaTime);

			if (this.gameObject.GetComponent<Transform> ().position.y >= 30f || this.gameObject.GetComponent<Transform> ().position.y <= -30f)
				transformPlayer.position = teleport;
		}
	}
}