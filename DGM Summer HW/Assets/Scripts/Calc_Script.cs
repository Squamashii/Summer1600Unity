using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Calc_Script : MonoBehaviour {

	public InputField in1;
	public InputField in2;
	public Text result;
	public Text resultSave;
	public Text operation;
	public float save1 = 0.0f;
	public float save2 = 0.0f;
	public float save3 = 0.0f;
	public string mathOpps = "=";

//Clears the result window 
	public void ClearClick(){
		result.text = "";
		}

//These are the number buttons. They just add the number to the end of the result.text
	public void But1Click(){
		result.text = result.text + "1";
	}
	public void But2Click(){
		result.text = result.text + "2";
	}
	public void But3Click(){
		result.text = result.text + "3";
	}
	public void But4Click(){
		result.text = result.text + "4";
	}
	public void But5Click(){
		result.text = result.text + "5";
	}
	public void But6Click(){
		result.text = result.text + "6";
	}
	public void But7Click(){
		result.text = result.text + "7";
	}
	public void But8Click(){
		result.text = result.text + "8";
	}
	public void But9Click(){
		result.text = result.text + "9";
	}
	public void But0Click(){
		result.text = result.text + "0";
	}
//Math Operator Button Functions. They add a "Operator" string, and populate text fields in the game
	public void AddClick(){
		mathOpps = "+";
		resultSave.text = result.text;
		operation.text = "+";
		save1 = float.Parse(result.text);
		result.text = "";
	}
	public void SubClick(){
		mathOpps = "-";
		resultSave.text = result.text;
		operation.text = "-";
		save1 = float.Parse(result.text);
		result.text = "";
	}
	public void DivClick(){
		mathOpps = "/";
		resultSave.text = result.text;
		operation.text = "/";
		save1 = float.Parse(result.text);
		result.text = "";
	}
	public void MultClick(){
		mathOpps = "*";
		resultSave.text = result.text;
		operation.text = "*";
		save1 = float.Parse(result.text);
		result.text = "";
	}
	public void ModClick(){
		mathOpps = "%";
		resultSave.text = result.text;
		operation.text = "%";
		save1 = float.Parse(result.text);
		result.text = "";
	}
	//This one is going to take some more work, but it basically just switches between operators that I clicked
	public void EqClick(){
		save2 = float.Parse(result.text);
		//operation.text = "";
		switch(mathOpps){
			case "+":	
				save3 = save1 + save2; 	break;
			
			case "-":	
				save3 = save1 - save2;	break;

			case "*":	
				save3 = save1 * save2;	break;
			
			case "/":	
				save3 = save1 / save2;	break;
			
			case "%":	
				save3 = save1 % save2;	break;
		}
		resultSave.text = save3.ToString();
		result.text = "";
	}

}



