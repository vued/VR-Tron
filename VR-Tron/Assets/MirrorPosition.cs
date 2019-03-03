using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorPosition : MonoBehaviour {

	public GameObject mirroringObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = mirroringObject.transform.position;
		pos.z = 990 - pos.z;
		transform.position = pos;

		Vector3 rot = mirroringObject.transform.eulerAngles;
		rot.y = 180 - rot.y;
		transform.eulerAngles = rot;

		// Mirroring object is too slow
		var speed = 100;
		transform.Translate (0, speed * Time.deltaTime, 0);
	}
}
