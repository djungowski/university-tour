using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bulletPrefab;

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, transform.parent.rotation);
			float force = g.GetComponent<Bullet>().Speed;
			g.rigidbody.AddForce(g.transform.forward * force);
		}
	}
}
