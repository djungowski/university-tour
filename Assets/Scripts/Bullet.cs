using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float Speed = 2000.0f;

	public GameObject explosionPrefab;

	void onCollisionEnter(Collision c) {
		Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
}
