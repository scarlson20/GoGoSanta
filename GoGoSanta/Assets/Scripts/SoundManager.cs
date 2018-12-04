using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    
    // sound variable that plays while the game is running
    public AudioSource backgroundMusic;
    // sound variable that plays when a present is shot
    public AudioSource presentShot;
    // sound variable that plays when a present hits a roof
    public AudioSource houseHit;
    // sound variable that plays when a present hits a smokey house
    public AudioSource smokeyHouseHit;
    // sound variable that plays when Santa hits an obstacle
    public AudioSource lifeLost;
    // sound variable that plays when Santa loses all his lives
    public AudioSource santaDies;
    // sound variable that plays when a level is successfully completed
    public AudioSource levelComplete;


    void Start()
    {
        
    }
}
