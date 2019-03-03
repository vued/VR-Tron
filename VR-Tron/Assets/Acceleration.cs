using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour {

    float speed = 100;
    float rotSpeed = 150;

    // Use this for initialization
    void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, speed * Time.deltaTime, 0);
		transform.Rotate (0, 0, rotSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime * -1);
	}
}
