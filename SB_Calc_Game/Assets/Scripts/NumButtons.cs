using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class NumButtons : Calculator {

	public void NumClick(){
		
		result.text = result.text + gameObject.name;
		oppDisplay.text = "";
				
	}
}
