using UnityEngine;
using System.Collections;

public class Dog : Mammal {

	//Properties
	public int dogSizeLbs = 80;
	public int dogAge = 18;
	//Functions
	public bool dogAppetite = true;
	//Attack
	//public string[] Attack = { "rage", "rabies", "lick"};
	//Wags Tail
	public bool emotionalState = false;
	public string rageAttack = "rabies";
	//Panting
	//Barking


	void Start()
	{
		if (dogAge < 1 || dogAge > 15)
		{
			print("This dog is physically unable to harm you");
		}

		if (dogSizeLbs > 50 && dogAppetite == true)
		{
			print("You just got mawled by the dog");
		}
		else
		{
			print("This dog is either too small or just ate");
		}




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