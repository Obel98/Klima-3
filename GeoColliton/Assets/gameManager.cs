﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public void CompleteLevel ()
    {
        Debug.Log("LEVEL WON!");
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
