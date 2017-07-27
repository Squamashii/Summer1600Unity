using UnityEngine;
using System.Collections;

public class Keyboard : Calculator {

	void FixedUpdate() 
	{
        //Number Buttons on the keyboard
		if(Input.GetKeyDown(KeyCode.Keypad1))
		{
			result.text = result.text + 1;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad2))
		{
			result.text = result.text + 2;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad3))
		{
			result.text = result.text + 3;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad4))
		{
			result.text = result.text + 4;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad5))
		{
			result.text = result.text + 5;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad6))
		{
			result.text = result.text + 6;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad7))
		{
			result.text = result.text + 7;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad8))
		{
			result.text = result.text + 8;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad9))
		{
			result.text = result.text + 9;
			oppDisplay.text = "";
		}
		if(Input.GetKeyDown(KeyCode.Keypad0))
		{
			result.text = result.text + 0;
			oppDisplay.text = "";
		}
   		
		//Math Function Buttons on the Keyboard
		if(Input.GetKeyDown(KeyCode.KeypadPlus))
		{
			opps = "+";	
			oppDisplay.text = "+";
			save1 = float.Parse(result.text);
			result.text = "";
		}

		if(Input.GetKeyDown(KeyCode.KeypadMinus))
		{
			opps = "-";	
			oppDisplay.text = "-";
			save1 = float.Parse(result.text);
			result.text = "";
		}

		if(Input.GetKeyDown(KeyCode.KeypadMultiply))
		{
			opps = "*";	
			oppDisplay.text = "*";
			save1 = float.Parse(result.text);
			result.text = "";
		}

		if(Input.GetKeyDown(KeyCode.KeypadDivide))
		{
			opps = "/";	
			oppDisplay.text = "/";
			save1 = float.Parse(result.text);
			result.text = "";
		}

		if(Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			save2 = float.Parse(result.text);
			float save3 = 0.0f;
			//operation.text = "";
			switch(opps)
			{
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
   
   
   
   
    }
}
