using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
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

		healthBar.sprite = healthBarArray [healthBarCount];
	}

}
