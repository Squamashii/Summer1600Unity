using UnityEngine;
using System.Collections;

public class Explanation : MonoBehaviour {

	//What is a variable?
	/*
	 * A variable is a bit of information that is stored in the program. 
	 * Variables can be whole numbers (int), decimal numbers (float), true or false (bool), words/sentences (string), etc.
	 * To use a variable in your code, you have to first declare it by stating the variable type, 
	*
	
	public float decimalNumber = 5.5f;
	public string[] sentences = { "This is a string variable"};
	public Color testColor = Color.black;
	public bool trueOrFalse = true;

	//IF / Else / Else IF statements
	* All if else statements must start with a call to action such as: void Start (the Start has to be capitalized. I had to figure that out.
	 * The void part gets parenthesis, and then the IF part gets curly brackets. 
	 * The comparison symbol is a double equal sign "==". This will compare a variable to a value and test to see if it is true. If it IS true, then the rest of the function will work.
	 * A boolean variable is inherently false, unless you state otherwise.
	 * The IF statement function is just searching for truth.. whether that means that you want it to be true or false, whatever you are comparing it to, if it matches, then it is true.
	 * My other if statements are in the Animal and Dog scripts.
	 */
	public string bodyType = "athletic";
	public int wholeNumber = 10;

	void Start()
	{
		if (bodyType == "athletic")
		{
			print(this.name + " is faster than you");
		} 
		
		if (wholeNumber == 10)
		{
			print("this " + this.name + " is equal to 10");
		}
	} 

	//Conventions and Syntax:
	/*
	 The period "." is used to separate pieces of a multi-piece element. Like an address, where the dot would separate the city.state.street.etc
	 The semicolon ";" is used at the end of every statement. Curly brackets don't need semicolons. "{}"
	 You indent your curly bracket code segments to stay organized and keep it simple to read.
		{
		This is sort of like hitting tab in a word document
			{
			They get layered, and the stuff on the inside applies to everything surrounding it.
			}
		}
	// comments are made by using the double slash. 
	/*
	 * Or you can have a multi-lined comment by using the asterist dash
	 * 
	 */
	 



	 */
}
