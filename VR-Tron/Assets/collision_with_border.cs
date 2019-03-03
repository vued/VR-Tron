using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_with_border : MonoBehaviour {

    int points;

	// Use this for initialization
	void Start () {
        points = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
	
		Debug.Log ("Collision of " + this.gameObject.name + " with " + col.gameObject.name);

        // Check for collision with border
		if (col.gameObject.name.StartsWith ("Border") && col.gameObject.name != "Border Player One Wall") {

            // Restart single player
            GameObject.Find("GameManager").GetComponent<singlePlayer>().StartGame();            
		}

        // Check for collision with coin
        if (col.gameObject.name.StartsWith("Coin"))
        {

            // Increase points
            points++;
            Debug.Log("Points increased for Player 1 to " + points);
        }

    }

}
