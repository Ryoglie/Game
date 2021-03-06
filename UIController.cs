﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {

    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;

    public void GameOver(){
        this.gameOverText.GetComponent<Text>().text = "GameOver";
    }

    public void AddScore(){
        this.score += 10;
    }
	// Use this for initialization
	void Start () {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.GetComponent < Text >().text= "Score:" + score.ToString("D4");
	}
}
