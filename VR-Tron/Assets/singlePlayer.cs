using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class singlePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // (Re)starts the game
    public void StartGame ()
    {
        //restart scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
