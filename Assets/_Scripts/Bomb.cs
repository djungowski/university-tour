using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	public GameObject explosionPrefab;

	// Update is called once per frame
	void OnCollisionEnter(Collision collision) {
		Debug.Log ("Collision");
		Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}


}
