﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Crossbow_Script : MonoBehaviour {

	public int Ammo= 20;
	public float crtimer = 2f;
	public bool iscrReloading = false;
	public GameObject ArrowText;

	// Use this for initialization
	void Start () {

		Cursor.visible = false;
		//ArrowText.GetComponent<Text>().text = "Arrows: " + Ammo.ToString();

	}
	
	// Update is called once per frame
	void Update () {

		ArrowText.GetComponent<Text>().text = "Arrows: " + Ammo.ToString();
		if (Input.GetMouseButtonDown(0))
		{

			//GetComponent<AudioSource>().Play(); 
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
				//Debug.Log (Ammo);


			} 

		}

		/*if (Ammo <=0){

			Application.LoadLevel("Game_Over_screen");
		}*/
	
	
	}

	/*void OnGUI() {
		GUI.contentColor = Color.magenta;
		GUI.Label(new Rect (10,10,150,20), "Arrows: "+Ammo); 

	}*/

	void OnTriggerEnter(Collider other){
		if (other.tag == "ArrowAmmo") {
			Ammo = 20;
			Destroy (other.gameObject);
		}
	}

}

