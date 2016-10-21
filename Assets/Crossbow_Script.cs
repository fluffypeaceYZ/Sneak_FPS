﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Crossbow_Script : MonoBehaviour {

	public int Ammo= 12;
	public float crtimer = 2f;
	public bool iscrReloading = false;
	// Use this for initialization
	void Start () {

		Cursor.visible = false;

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown(0)){

			GetComponent<AudioSource>().Play(); 
			iscrReloading = true;
		}

		if (iscrReloading) {

			if (crtimer > 0) {
				crtimer -= Time.deltaTime;
				iscrReloading= true;
			} else {

				crtimer = 2f;
				iscrReloading = false;
				Ammo--;

			} 

		}

		if (Ammo <=0){

			Application.LoadLevel("Game_Over_screen");
		}
	
	
	}

	void OnGUI() {
		GUI.contentColor = Color.magenta;
		GUI.Label(new Rect (10,10,150,20), "Arrows: "+Ammo); 

	}

}

