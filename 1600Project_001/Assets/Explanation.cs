using UnityEngine;
using System.Collections;

public class Explanation : MonoBehaviour {

	//What is a variable?
	/*
	 * A variable is a bit of information that is stored in the program. 
	 * Variables can be whole numbers (int), decimal numbers (float), true or false (bool), words/sentences (string), etc.
	 * To use a variable in your code, you have to first declare it by stating the variable type, 
	*/
	public int wholeNumber = 10;
	public float decimalNumber = 5.5f;
	public string[] sentences = { "This is a string variable" + "This is another string output"};
	public Color testColor = Color.black;
	public bool trueOrFalse = true;
}
