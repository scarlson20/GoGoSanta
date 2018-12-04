using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIPanel : MonoBehaviour {

    [SerializeField] Image[] hearts;
    [SerializeField] Text scoreText;
    [SerializeField] Text presentsText;
    [SerializeField] Text deathText;
    [SerializeField] Button restartButton;
    [SerializeField] Button mainMenuButton;
    public int currentLevel;
    private int livesCounter;
    private float presentsCounter;
    public int totalScore;


    // Use this for initialization
    void Start () {
        deathText.enabled = false;
        restartButton.gameObject.SetActive(false);
        mainMenuButton.gameObject.SetActive(false);
        livesCounter = GameObject.FindGameObjectWithTag("Sleigh").GetComponent<PlayerMovement>().lives;
        presentsCounter = GameObject.FindGameObjectWithTag("Shooter").GetComponent<PresentShooter>().totalNumPresents;
        LevelInfo.level = currentLevel;
    }
	
	// Update is called once per frame
	void Update () {
        //Update Lives
        livesCounter = GameObject.FindGameObjectWithTag("Sleigh").GetComponent<PlayerMovement>().lives;
        UpdateHearts(livesCounter);
        if (livesCounter <= 0 ) {
            deathText.enabled = true;
            restartButton.gameObject.SetActive(true);
            mainMenuButton.gameObject.SetActive(true);

        }
       
        //Update number of presents left for player to fire
        presentsCounter = GameObject.FindGameObjectWithTag("Shooter").GetComponent<PresentShooter>().totalNumPresents - GameObject.FindGameObjectWithTag("Shooter").GetComponent<PresentShooter>().numPresentsFired;
        // End level early if player uses all of their presents
        if (presentsCounter <= 0) {
            if (LevelInfo.level != 2 || LevelInfo.score < 200) {
                StartCoroutine("RunOutOfPresents");
            }
        } 
        UpdatePresents(presentsCounter);
    }

    // Update hearts on UIPanel
    void UpdateHearts(int lives)
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < lives)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    // Called in HitTarget to update the score
    public void UpdateScore(int score)     {
        totalScore += score;
        if (scoreText == null) {
            return;
        }         scoreText.text = totalScore.ToString();
        LevelInfo.score = totalScore;     }

    void UpdatePresents(float numPresents)
    {
        if (presentsText == null)
        {
            return;
        }
        presentsText.text = numPresents.ToString();
    }

    // Takes player to end of level screen after running out of presents
    private IEnumerator RunOutOfPresents(){
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Screen_EndOfLevel");
    }
}
