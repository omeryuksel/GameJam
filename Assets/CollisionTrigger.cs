using UnityEngine;
using System.Collections;

public class CollisionTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float a = 10;
		a++;
	}


	void OnTriggerEnter (Collider other) {
		Physics2D.gravity.Set(0,-1);
	}


	void OnCollisionEnter (Collision col)
	{
		float a = 10;
		a++;
	}


	void OnTriggerEnter(Collision other){
		float a = 10;
		a++;
		
		
		}



}
