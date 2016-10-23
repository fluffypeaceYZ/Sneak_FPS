using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {

	public Transform target;
	public float ProjectileSpeed = 20;

	private Transform myTransform;

	void Awake() 
	{
		myTransform = transform; 
	}

	void Start () 
	{
		GameObject go = GameObject.FindGameObjectWithTag("MainCamera");
		target = go.transform;
		// rotate the projectile to aim the target:
		myTransform.LookAt(target);
	}

	// Update is called once per frame
	void Update () 
	{
		// distance moved since last frame:
		float amtToMove = ProjectileSpeed * Time.deltaTime;
		// translate projectile in its forward direction:
		myTransform.Translate(Vector3.forward * amtToMove);
	
		Destroy(this.gameObject, 20);
	
	}
}
