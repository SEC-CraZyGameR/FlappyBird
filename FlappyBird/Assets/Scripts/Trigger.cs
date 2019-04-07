using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour {

	public GameObject deathMenu;
	public bool gameOver= false;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Piller")) {
			gameEnd ();
		}
	}


	void gameEnd()
	{
		deathMenu.SetActive (true);
		gameOver = true;
	}


	public void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

	}
}
