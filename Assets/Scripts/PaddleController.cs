using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	public float paddleSpeed = 1.0f;
	Vector3 paddlePos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float xPos = Mathf.Clamp (transform.position.x + Input.GetAxis ("Horizontal") * paddleSpeed,-8.0f,8.0f);
		paddlePos = new Vector3 (xPos, -9.5f, 0f);
		transform.position = paddlePos;
	}
}
