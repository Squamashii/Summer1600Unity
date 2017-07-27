using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Calculator : MonoBehaviour {

	//Variables
	public Text finalResult;	//For displaying the result of the last problem
	public Text result;			//This is the current result of the current problem
	public Text oppDisplay;
	public float save1 = 0.0f;	//Holds number value from before the math operator was pressed
	public float save2 = 0.0f;	//When "=" is pressed, this stores the result.text as variable#2 for the math problems
	public string opps;			//Holds the value of the math operator

	//Button Functions
	public void AddClick(){
		opps = "+";	
		oppDisplay.text = "+";
		save1 = float.Parse(result.text);
		result.text = "";
	}

	public void SubClick(){
		opps = "-";	
		oppDisplay.text = "-";
		save1 = float.Parse(result.text);
		result.text = "";
	}

	public void MultClick(){
		opps = "*";	
		oppDisplay.text = "*";
		save1 = float.Parse(result.text);
		result.text = "";
	}

	public void DivClick(){
		opps = "/";	
		oppDisplay.text = "/";
		save1 = float.Parse(result.text);
		result.text = "";
	}

	public void EqClick(){
		save2 = float.Parse(result.text);
		float save3 = 0.0f;
		//operation.text = "";
		switch(opps){
			case "+":	
				save3 = save1 + save2; 	
			break;
			
			case "-":	
				save3 = save1 - save2;	
			break;

			case "*":	
				save3 = save1 * save2;
			break;
			
			case "/":	
				save3 = save1 / save2;	
			break;
		}
		finalResult.text = save3.ToString();
		result.text = "";
		save1 = 0.0f;
		save2 = 0.0f;
		save3 = 0.0f;
	}

//Clears all stored values, so you can start over
	public void ClearClick(){ 
		save1 = 0.0f;
		save2 = 0.0f;
		result.text = "";
		finalResult.text = "";
		opps = "";
	}


}
