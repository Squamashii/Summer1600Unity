using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
//----------- Variables For the Score -----------------
	public static int score;
	public Text text;

//----------- Variables For the Health Bar ------------
	public static float health;
	public Text healthText;


	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0)
			score = 0;

		text.text = " " + score;
		
	}
	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}

	public static void Reset(){
		score = 0;
	}

}
