using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LookAt : MonoBehaviour {

	public Transform Target;
	[SerializeField]
	private Transform bullet;
	private bool inrange;
	public List<Transform> targets = new List<Transform>();

	public enum states
	{
		PatrolState,
		ShootState
	}

	public states state;

	void Start () {
		switch (state) {
		case states.PatrolState:
			break;
		case states.ShootState:
			break;
		}
	}


	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
			inrange = true;
			Target = other.transform;
			targets.Add(Target);
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Enemy") {
			inrange = false;
			Target = other.transform;
			targets.Remove(Target);
		}
	}

	void Update () {

		if (state == states.PatrolState && inrange == true) {
			state = states.ShootState;
			
		}
		else if(state == states.ShootState)
		{
			transform.LookAt (Target);
			shoot();
		}
		/*else if (targets.Count == 0) {
			inrange = false;
			state = states.PatrolState;
		}*/
	}

	void shoot(){
		Instantiate(bullet, transform.position, transform.rotation);
	}
}
