﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgoundMove : MonoBehaviour {

	private float speed =0.1f;
	Vector2 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		offset =new Vector2 (Time.time * speed, 0);

		GetComponent<Renderer> ().material.mainTextureOffset = offset;

	}
}
