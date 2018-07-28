using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_with_border : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
	
		Debug.Log ("Collision of " + this.gameObject.name + " with " + col.gameObject.name);

		if (col.gameObject.name.StartsWith ("Border")) {
			this.gameObject.transform.position = new Vector3 (250, 0.5f, 75);
			this.gameObject.transform.eulerAngles = new Vector3 (90, 0, 0);
		}

	}

}
