﻿using UnityEngine;
using System.Collections;

public class Target_Script : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Arrow")
		{
			GetComponent<AudioSource>().Play(); 
		}
}
}
