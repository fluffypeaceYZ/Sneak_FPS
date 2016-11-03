using UnityEngine;
using System.Collections;

public class EndPoint : MonoBehaviour {

	public GameObject EndGameScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {

		if(other.gameObject.tag == "MainCamera")
		{
			 
			EndGameScreen.SetActive (true);
		}
}
}
