using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public GameObject GameOverScreen;

	public Sprite[] healthBarArray;
	public Image healthBar;

	private int healthBarCount = 0;

	void Start () 
	{
	
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.P))
		{
			TakeDamage ();
		}
	}

	public void TakeDamage()
	{
		healthBarCount++;

		if (healthBarCount > 5){

			GameOver ();
		}

		healthBar.sprite = healthBarArray [healthBarCount];
	}

	void OnTriggerEnter (Collider other) {

		if(other.gameObject.tag == "Fireball")
		{
			TakeDamage ();
		}

}

	void GameOver()
	{
		GameOverScreen.SetActive (true);
	}
}
