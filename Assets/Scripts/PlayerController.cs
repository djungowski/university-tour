using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	void FixedUpdate() {
		float moveHorizontally = Input.GetAxis("Horizontal");
		float moveUp = 0;
		float moveVertically = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontally, moveUp, moveVertically);
		rigidbody.AddForce(movement);
		Debug.Log("moving: " + movement);
	}
}
