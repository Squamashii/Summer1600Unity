using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class scoreManager : MonoBehaviour {
//----------- Variables For the Score -----------------
	public static int winScore = 250;
	public static int currentScore = 0;

	public Text scoreText;

	public static void AddScore(int scoreToAdd){
		currentScore += scoreToAdd;
		
		if(currentScore >= winScore){
			WinGame();
		}

	}

	public void Reset(){
		currentScore = 0;
	}

	public static void WinGame() {
	SceneManager.LoadScene(3);
	}
	
	void Update () {
		scoreText.text = currentScore.ToString() + " /250"; //The text object always reflects how many points you have
	}
	
	/* 
	void Start () {
		chickenText = GetComponent<Text>();
		chickenScore = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(chickenScore < 0){
			chickenScore = 0;
		chickenText.text = " " + chickenScore;
		}
		
		if(chickenScore >= winScore) //winScore is a public float that I can compare with the score, and then it executes the WIN scene. 
			WinGame();
		
	}*/

	



}
