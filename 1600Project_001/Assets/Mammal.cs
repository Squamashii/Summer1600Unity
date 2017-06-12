using UnityEngine;
using System.Collections;

public class Mammal:Animal{
	//
	//Properties
	public int mamSize = 150;
	public bool mamTame = false;
	//Hair
	public bool hasHair = true;
	public Color hairColor = Color.grey;
	//
	//Warm Blooded
	//HowManyLegs
	public int legCount = 1;

	//FUNCTIONS
	//Live Birth Overides Reproduction
	//Feed Milk
	//Bite
	void start()
	{
		if (legCount != 4)
		{
			print("Um.. You cannot ride that thing!");
		}
		else
		{
			print("You can ride him");
		}

		if (!mamTame && mamSize > 100)
		{
			print("Are you gonna try anyway?");
		}
		else
		{
			print("why isn't this working?");
		}






	}


}
