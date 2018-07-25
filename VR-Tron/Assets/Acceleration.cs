using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		var speed = 100;
		var rotSpeed = 150; 

		transform.Translate (0, speed * Time.deltaTime, 0);
		transform.Rotate (0, 0, rotSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime * -1);
	}
}
