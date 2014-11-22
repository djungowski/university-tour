using UnityEngine;
using System.Collections;

public class RotatingWheel : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		float speed = Input.GetAxis ("Vertical");
		Vector3 rotation = new Vector3 (1.0f, 0.0f, 0.0f);

		if (Input.GetAxis ("Vertical") > 0) {
			transform.Rotate(rotation, Space.Self);
		}
	}
}
