using UnityEngine;
using System.Collections;
 
public class Arrow_Script : MonoBehaviour {

		public float thrust;
		public Rigidbody rb;
		
		public static Transform parent;
		public static Vector3 initialPosition;
		public static Quaternion initialRotation;
		public static Arrow_Script currentArrow;
	public ParticleSystem Trail;
		
	 
	 
		
		void Start() 
		{


			rb = GetComponent<Rigidbody>();

			if (parent == null) {
				initialPosition = transform.localPosition;
				initialRotation = transform.localRotation;
				parent = transform.parent;
			}

			currentArrow = this;
		}

		void Update() {

	 


		if (currentArrow != this)
			
			return;

		if (Input.GetMouseButtonDown(0)){

			 
			Vector3 direction = transform.forward * thrust;
			rb.AddForce(direction, ForceMode.Impulse);
			transform.parent = null;
			isReloading = true;
			Trail.Play ();

			 
		}

		if (Input.GetMouseButtonUp(0)){

		 
			Destroy (this.gameObject, 10);

		}

	

		//print (timer);

		if (isReloading) {

			if (timer > 0) {
				timer -= Time.deltaTime;
			} else {

				//create arrow
				GameObject aPrefab = Instantiate(Resources.Load("arrow"), new Vector3(transform.position.x, transform.position.y , transform.position.z), transform.rotation) as GameObject;
				aPrefab.transform.parent = Arrow_Script.parent;
				aPrefab.transform.localPosition = Arrow_Script.initialPosition;
				aPrefab.transform.localRotation = Arrow_Script.initialRotation;

				timer = 2f;

				isReloading = false;

			}
		}

	}
	bool isReloading = false;
	float timer = 1f;

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Target")
		{
			//transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z)
			//transform.parent = null;
			rb.isKinematic = true;
		}
}
	 

}
