using UnityEngine;
using System.Collections;

public class BricksController : MonoBehaviour {

	public GameObject bricksParticle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		Instantiate (bricksParticle, transform.position, Quaternion.identity);
		Destroy (gameObject);
		GameManager.instance.DestroyBrick ();
	}
}
