using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	public GameObject explosionPrefab;

	// Update is called once per frame
	void OnCollisionEnter(Collision collision) {
		Debug.Log ("Collision");
		Debug.Log (collision.collider);
		Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}


}
