﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used to check user clicked button with pattern sequence

public class ButtonController : MonoBehaviour {

    private SpriteRenderer theSprite;

    public int thisButtonNumber;

    private gameMang theGM;

    private AudioSource theSound;

    // Use this for initialization
    void Start () {

        theSprite = GetComponent<SpriteRenderer>();
        theGM = FindObjectOfType<gameMang>();
        theSound = GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //detects when player clicks on object
    void OnMouseDown()
    {

        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 1f);
        theSound.Play();

    }

    //detects when player lets go of button
    void OnMouseUp()
    {

        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 0.5f);
        theGM.ColourPressed(thisButtonNumber);
        theSound.Stop();
        

    }
}