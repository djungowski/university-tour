using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float accelerator = 4f;

	void FixedUpdate() {

		Physics.bounceThreshold = 0;
		float moveHorizontally = Input.GetAxis("Horizontal");
		float moveUp = 0.0f;
		float moveVertically = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontally, moveUp, moveVertically);

		//this.transform.position += movement;
		rigidbody.AddForce(movement*accelerator);
	}
}
