using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float ballForce = 500.0f;
	bool ballInPlay;
	Rigidbody rd;
	// Use this for initialization
	void Start () {
		rd = GetComponent<Rigidbody> ();
		ballInPlay = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && !ballInPlay) {
			transform.parent = null;
			ballInPlay = true;
			rd.isKinematic = false;
			rd.AddForce(new Vector3(ballForce,ballForce,0));
		}
	}
}
