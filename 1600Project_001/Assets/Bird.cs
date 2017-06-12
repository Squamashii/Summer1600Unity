using UnityEngine;
using System.Collections;

public class Bird : Animal {

	//Properties
	//Feather count
	public int feathers = 100;
	//Beak
	public float beak = 0.25f; 
	//Wings bool if they work
	public bool wings = true;
	//Color
	public Color featherColor = Color.red;

	//Functions
	//Fly
	//BuildNests
	//LayEggs overides repreopducion
	//Call

		
	//Variables for testiing 
	public string charName = "Freddy";
	public float charWeight = 150.5f;
	public int charHeightcm = 95;
	public bool charFit = true;
	public bool charHappy = false;

	void Start() //This is the Start function, and includes everything in the following curly bracket code box.
	{
		if (beak < 0.1f || beak > 10)
		{
			print("This bird is too small or too big");
		}




		if (wings && feathers > 0)
		{
			print("flying");
		}
		else
		{
			print("bird is lame");
		}

		/*
		if (charHeightcm <= 120)    //The computer will check if whatever is inside these parenthesis are true, and if it is, it will continue with the function in the curly brackets below it. 
		{
			print("You are a midget");
		}
		else
		{
			print(this.name + " is " + charHeightcm + " tall.");
		}

		if (charName == "Freddy")
		{
			print("Hi Freddy"); //if the character's name is Freddy, this will tell him Hi
		}
		else  //This is an else clause. If the if statment returned false, then this part of the function plays out.
		{
			print("Who the heck are you?"); //if his name isn't Freddy, the computer will ask his name
		}

		if (charWeight <= 140)
		{
			print("Somebody get that kid a sandwich");
		}
		else if (charWeight <= 180)
		{
			charFit = true; //I actually don't know if this will work.. We haven't made a variable affect
		}
		else
		{
			print("Do you even lift?");
		}

		if (2 + 2 == 5)
		{
			print("really?");
		}
		else
		{
			print("you were so close!");
			Debug.LogError("You are an idiot, everyone knows what 2 + 2 is... wait.. what what is again?");
		}


		if (charFit)
		{
			charHappy = true;
		}
		else
		{
			charHappy = false;
		}		*/
	}


}


