using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	private float timer = 0f;
	private float delayTime = 2.0f;

	public GameObject pillerPrefabs;

	void Start () {
		spawn ();
	}
	
	// Update is called once per frame
	void Update () {
		
			timer += Time.deltaTime;
			if (timer >= delayTime) {
				spawn ();
				timer = 0f;
			}
	}

	public void spawn(){
		float yPos = Random.Range(1.5f,-1.5f);
		float xPos = transform.position.x;
		Vector2 position = new Vector2 (xPos, yPos);

		GameObject gameobj = Instantiate (pillerPrefabs, position, Quaternion.identity);

		Destroy (gameobj, 5.0f);
	}
}
