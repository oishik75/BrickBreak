﻿using UnityEngine;
using System.Collections;

public class LoseLife : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		GameManager.instance.LostLife ();
	}

}
