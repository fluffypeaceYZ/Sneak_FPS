using UnityEngine;
using System.Collections;

public class SoldierMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3(0.3f, 0, 0); 
	
	}

	void OnTriggerEnter(Collider other) {

		if(other.gameObject.tag == "Right")
		{
			transform.position += new Vector3(-0.3f, 0, 0);
		}

		if(other.gameObject.tag == "Left")
		{
			transform.position += new Vector3(0.3f, 0, 0);
		}
	
	}
}
