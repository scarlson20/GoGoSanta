using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Used to keep track of data that needs to be used between scenes
public class LevelInfo : MonoBehaviour {
    public static float score;
    public static int level;

	// Use this for initialization
	void Start () {
        score = 0;
        level = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
