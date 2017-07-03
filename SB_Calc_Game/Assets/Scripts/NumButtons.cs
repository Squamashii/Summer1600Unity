using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class NumButtons : MonoBehaviour {

	public Text numString;
	public Text mathOpp;

	public void NumClick(){
		numString.text = numString.text + gameObject.name;
		mathOpp.text = "";
	}
}
