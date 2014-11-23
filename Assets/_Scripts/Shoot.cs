using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bombPrefab;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightControl)) {
			Vector3 currentPosition = transform.position;
			Vector3 targetSpawnPosition = currentPosition + new Vector3(0.1f, 1.0f, 7.0f);
			Quaternion rotation = new Quaternion(0.0f, -180.0f, 0.0f, 0.0f);

			GameObject bomb = (GameObject) Instantiate(bombPrefab, targetSpawnPosition, rotation);

			Vector3 direction = new Vector3(0.0f, 1.0f, 1.0f);
			float force = 300.0f;
			bomb.rigidbody.AddForce(direction * force);
		}
	}
}
