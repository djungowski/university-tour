using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	public GameObject explosionPrefab;

	// Update is called once per frame
	void OnCollisionEnter(Collision collision) {
		Collider target = collision.collider;

		Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		Destroy (gameObject);

		// Destroy Target Object it if is an enemy
		if (target.gameObject.CompareTag ("Enemy")) {
			Destroy(target.gameObject);
		}
	}


}
