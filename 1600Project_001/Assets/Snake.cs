using UnityEngine;
using System.Collections;

public class Snake : Animal {

	//properties , false, &&, ||

	public bool venomous = true;
	public float sLength = 6.5f;
	public int snakeSpeed = 10;
	public bool constrictor = false;


	void Start ()
	{
		if (snakeSpeed > 5 && venomous)
		{
			print("you are going to die a very painful death");
		}

		if (!constrictor && !venomous)
		{
			print("That is in fact, a work.. not a snake");
		}

		if (sLength > 8 || venomous)
		{
			print("You don't have much of a chance");
		}
	}
	
	
}
