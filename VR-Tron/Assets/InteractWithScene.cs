using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
	
		//Debug.Log("Collision of " + this.gameObject.name + " with " + col.gameObject.name);

        // Check for collision with border
		if (col.gameObject.name.StartsWith ("Border") && col.gameObject.name != "Border Player One Wall") {

            Debug.Log("Collision of " + this.gameObject.name + " with " + col.gameObject.name);

            // Restart single player
            GameObject.Find("GameManager").GetComponent<SinglePlayer>().RestartGame();
		}

        // Check for collision with coin
        if (col.gameObject.name.StartsWith("Coin"))
        {
            // Disable coin
            col.gameObject.SetActive(false);

            // Get coin number
            int coinNumber = col.gameObject.name[col.gameObject.name.Length - 1] - '0';
            Debug.Log("Coin Number: " + coinNumber);

            // Increase points
            bool allCoins = GameObject.Find("GameManager").GetComponent<SinglePlayer>().AddCoin(coinNumber);

            //
            if (allCoins) {
                // Pause game (in a very ugly way)
                Time.timeScale = 0;

                // Log performance of player
                GamePerformance gamePerformance = GameObject.Find("GameManager").GetComponent<SinglePlayer>().EndGame();
                Debug.Log("Laptime: " + gamePerformance.GetLaptime().ToString());
            }

        }

    }

}