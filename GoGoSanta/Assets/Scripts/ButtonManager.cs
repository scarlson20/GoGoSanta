using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
    private int currentLevel;

    // Use this for initialization
    void Start () {
        currentLevel = LevelInfo.level;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Takes player to beginning of first level
    public void NewGame()
    {
        SceneManager.LoadScene("Level_Tutorial");
    }

    // Takes player to the next level
    public void NextLevel(){
        if (currentLevel == 0) {
            SceneManager.LoadScene("Level_One");
        } else if (currentLevel == 1) {
            SceneManager.LoadScene("Level_Two");
        }
    }

    // Button takes player back to beginning of current level
    public void RestartLevel()
    {
        if (currentLevel == 0)
        {
            SceneManager.LoadScene("Level_Tutorial");
        }
        else if (currentLevel == 1)
        {
            SceneManager.LoadScene("Level_One");
        }
        else {
            SceneManager.LoadScene("Level_Two");
        }
    }

    // Takes player back to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("Screen_MainMenu");
    }

    // Takes player to screen with controls after starting new game
    public void ControlScreen() {
        SceneManager.LoadScene("Screen_Controls");
    }

    // Function for Quit Game Button
    public void QuitGame()
    {
        Application.Quit();
    }
}

