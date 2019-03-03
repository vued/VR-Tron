using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SinglePlayer : MonoBehaviour {

    int points;
    public int maxPoints;
    bool[] coinsCollected;

    float lapStart;

    // Use this for initialization
    void Start() {
        StartGame(false);
        coinsCollected = new bool[maxPoints];
    }

    // Update is called once per frame
    void Update() {

    }

    public void RestartGame()
    {
        EndGame();
        StartGame(true);
    }


    // (Re)starts the game
    public void StartGame(bool withSceneReset)
    {
        //restart scene
        if (withSceneReset)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        points = 0;
        Debug.Log("Points reset to " + points);

        lapStart = Time.time;
    }

    public bool AddCoin(int coinNumber)
    {

        if (coinsCollected[coinNumber] == false)
        {
            coinsCollected[coinNumber] = true;
            points++;
            Debug.Log("Points increased to " + points);

            if (points >= maxPoints)
                return true;
            else
                return false;

        }
        else
        {
            Debug.Log("Double counting coin " + coinNumber);
            return false;
        }
    }

    public GamePerformance EndGame ()
    {
        // Calculate laptime of this lap
        float laptime = Time.time - lapStart;

        // Return the performance of the player in this lap
        return new GamePerformance(laptime, points);
    }
}

public class GamePerformance
{
    float laptime;
    int points;

    public GamePerformance (float laptime, int points)
    {
        this.laptime = laptime;
        this.points = points;
    }

    public float GetLaptime ()
    {
        return laptime;
    }

    public int GetPoints()
    {
        return points;
    }
}