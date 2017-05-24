using UnityEngine;
using System.Collections;

public class Dog : Mammal {

	//Properties
	//Functions
	//Attack
	//public string[] Attack = { "rage", "rabies", "lick"};
	//Wags Tail
	public bool emotionalState = false;
	public string rageAttack = "rabies";
	//Panting
	//Barking
	void Start()
	{
		if (rageAttack == "rabies")
		{
			print("This " + this.name + " bit you. You are dead :(");
		}
		else
		{
			print("You survived the dog attack! Huzzah!");
		}
		if (6 == 6)
		{
			print("yup");
		}
		if (emotionalState)
		{
			print("<wags tail>");
		}
		
	}
	
}