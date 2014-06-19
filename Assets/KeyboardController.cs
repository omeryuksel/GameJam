using UnityEngine;
using System.Collections;

public class KeyboardController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		endTransform = new Vector3 ();
	}

	public Vector3 endTransform;
	public float anglePhase=0;

	/*
	void OnCollisionEnter (Collision col)
	{
		float a = 10;
		a++;
	}
*/
	/*
	void OnTriggerEnter(Collision other){
		float a = 10;
		a++;
		
		
	}
*/
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.DownArrow))
			rigidbody2D.AddForce (Vector2.up* 100f);
		if (Input.GetKeyDown (KeyCode.UpArrow))
			rigidbody2D.AddForce (Vector2.up* -100f);

		if (Input.GetKey (KeyCode.RightArrow))
			rigidbody2D.AddForce (Vector2.right* -10f);

		if (Input.GetKey (KeyCode.LeftArrow))
			rigidbody2D.AddForce (Vector2.right* 10f);

		GameObject mainCamera = GameObject.FindGameObjectWithTag ("MainCamera");

		endTransform = transform.position;

		//transform.Translate (transform.position.x, transform.position.y * -1);

		anglePhase+=0.1f;

		endTransform.z = transform.position.z - 15.0f + (Mathf.Sin(anglePhase)*0.2f);

		mainCamera.transform.position = Vector3.Lerp (mainCamera.transform.position , endTransform, Time.deltaTime * 1f);

		mainCamera.transform.LookAt (transform.position);

		//if (Input.GetKeyDown (KeyCode.UpArrow))
			//transform.Translate (Vector3.up * 0.5);


	}
}
