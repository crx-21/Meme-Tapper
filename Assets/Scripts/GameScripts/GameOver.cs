using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public HealthScript myhealthScript;
    public ScoreScript myscoreScript;
    public GameObject myGameOver;
    public GameObject myActiveObjects;
    private void OnMouseDown()
    {
        myhealthScript.health--;
    }
    void Update()
    {
        if (myhealthScript.health < 1)
        {
            myGameOver.SetActive(true);
            myActiveObjects.SetActive(false);
        }

    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Joc");
        ScoreScript.scoreValue = 0;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
        ScoreScript.scoreValue = 0;
    }
}
