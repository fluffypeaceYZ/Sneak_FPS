using UnityEngine;
using System.Collections;

public class SoldierMovement : MonoBehaviour {
	public ParticleSystem Blood;
	bool MovementSoldier = true;
	float timer = 6f;
	bool isReloading = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (MovementSoldier == true){

		transform.position += new Vector3 (4f, 0, 0) * Time.deltaTime;
		}
		if (MovementSoldier == false){

			transform.position -= new Vector3 (4f, 0, 0)* Time.deltaTime;
		}
		if (timer > 0) {
			timer -= Time.deltaTime;
			isReloading =true;
		}
			else
			{

				GameObject aPrefab = Instantiate(Resources.Load("fireball"), new Vector3(transform.position.x, transform.position.y , transform.position.z), transform.rotation) as GameObject;
			
			
				timer = 6f;

				isReloading = false;
				}

	}

	


	void OnTriggerEnter (Collider other) {

		if(other.gameObject.tag == "Right")
		{
			MovementSoldier = false;
			print ("Touched Right");
			 

		}

		if(other.gameObject.tag == "Left")
		{
			 
			MovementSoldier = true;
		}

		if(other.gameObject.tag == "Arrow")
		{
			GameObject bPrefab = Instantiate(Resources.Load("ToonRTS_demo_knight 1"), new Vector3(transform.position.x, transform.position.y , transform.position.z), transform.rotation) as GameObject;
			GameObject cPrefab = Instantiate(Resources.Load("ToonRTS_demo_knight 2"), new Vector3(transform.position.x, transform.position.y , transform.position.z), transform.rotation) as GameObject;

			Destroy (this.gameObject,1);
			
			Blood.Play ();

		}
	
	}
}
