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

	public void HealDamage(){

		healthBarCount = 0;
		healthBar.sprite = healthBarArray [healthBarCount];
	}

	void OnTriggerEnter (Collider other) {

		if(other.gameObject.tag == "Fireball")
		{
			TakeDamage ();
		}

		if(other.gameObject.tag == "Blood")
		{
			HealDamage();
			Destroy (other.gameObject, 1);
			 
		 
		}

}

	void GameOver()
	{
		GameOverScreen.SetActive (true);
	}
}
