using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndOfGameManager : MonoBehaviour {

    [SerializeField] Text scoreText;

    // Use this for initialization
    void Start () {
        scoreText.text = "Final Score: " + LevelInfo.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
