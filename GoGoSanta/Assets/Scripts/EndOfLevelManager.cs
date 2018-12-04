using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndOfLevelManager : MonoBehaviour {

    private float score = LevelInfo.score;
    [SerializeField] Button restartButton;
    [SerializeField] Button mainMenuButton;
    [SerializeField] Button nextLevelButton;
    [SerializeField] Text scoreText;
    [SerializeField] Text performanceRating;
    [SerializeField] Text nextLevelPrepText;
    UIPanel myUIPanel;


    // Use this for initialization
    void Start () {
        myUIPanel = FindObjectOfType<UIPanel>();
        scoreText.text = "Your Score: " + score.ToString();
        if (score < 200) {
            performanceRating.text = "That was a disaster! You RUINED Christmas!";
            nextLevelButton.gameObject.SetActive(false);    // Player cannot move on to next level if score is less than 200
            nextLevelPrepText.enabled = false;
        } else if (score >= 200 && score <= 300) {
            performanceRating.text = "Good Job! But is that all you've got?";
        } else if (score > 300){
            performanceRating.text = "Excellent! Best Christmas yet!";
        }
        // There is no next level after level 2
        if (LevelInfo.level == 2) {
            nextLevelButton.gameObject.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
