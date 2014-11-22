using UnityEngine;
using System.Collections;

public class RotatingWheel : MonoBehaviour {

	private float walkingSpeed = 10.0f;
	private float speedFactor = 2.0f;

	// Update is called once per frame
	void Update () {
		float verticalAcceleration = Input.GetAxis ("Vertical");
		float speed = verticalAcceleration * speedFactor;
		//speed = Mathf.Abs (speed);
		Vector3 rotation = new Vector3 (speed, 0.0f, 0.0f);

		if (Input.GetAxis ("Vertical") != 0) {
			transform.Rotate(rotation, Space.Self);
		}
	}
}
