using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : LookAt {

	private float speed = 10;

	void Update () {
		this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy") {
			Destroy(other.gameObject);
			Destroy(this.gameObject);
			targets.Remove(Target);
			
		}
	}
}
