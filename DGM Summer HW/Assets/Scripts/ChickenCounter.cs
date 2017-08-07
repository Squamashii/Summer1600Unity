using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChickenCounter : MonoBehaviour {

	public static int currentChickens = 0; //How many chickens you have at any given moment
	public static int topChickenCount = 15; //The amount of chickens you need in order to win
	public static int chickenPoints = 5;

	public Text chickens; //The text object that will update when you collect a chicken
	
	void Update () {
		chickens.text = currentChickens.ToString() + " /15"; //The text object always reflects how many chickens you have
	}


	//A method to add a chicken to currentChickens. "int amount" is a 
	//temporary variable in the parameters, so when you call the function in another script, 
	//it will add whatever the integer/variable is that you put in there.
	public static void AddChicken(int amount) 
	{
		currentChickens += amount;
		scoreManager.AddScore(chickenPoints);
		if(currentChickens >= topChickenCount){
			WinGame();
		}
	}
	
	public static void WinGame() {
	SceneManager.LoadScene(3);
	}
}
