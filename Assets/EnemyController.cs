using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public GameObject EndGameScreen;
	int EnemyNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		EnemyNumber = transform.childCount;
		//Debug.Log (EnemyNumber);
		if (EnemyNumber <= 0) {
			EndGameScreen.SetActive (true);
		}
	}
}
