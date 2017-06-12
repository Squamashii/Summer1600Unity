using UnityEngine;
using System.Collections;

public class Animal: MonoBehaviour {

	//Classes are the levels of hierarchy of objects in a unity project. 
	//For example, "dog" is a class of "mammal" which is a class of "animal" which is a class of "life-form" 
	//Everything in the upper levels is also applicable in the lower levels unless otherwise stated


	//PROPERTIES (Things they are or have)
	public string animalName = "Jenny";
	//Body Segments
	public string[] bodySegments = {"Head", "Abs", "Thorax" };
	//Health
	public int health = 100; //
	//speed
	public float speed = 0.0f;
	//size
	public string size = "Big";
	//Color
	public Color baseColor;
	//FUNCTIONS (Things they do)
	//Breathe
	//Reproduce
	//Eat
	public bool canEat = false;
	//Move
	//Die
	//Grow
	public int[] arrayTest1 = {001, 101, 201, 301, 401, 501, 601, 701, 801, 901};
	public GameObject[] arrayTest2 = new GameObject[2];

	//arrayTest1[2] = 43; //this is only temporary

	void Start()
	{

		

		if (canEat)
		{
			print(this.name + " can eat.");
		}
		else
		{
			print(this.name + " can't eat.");
		}

		if (2 + 5 == 7)
		{
			print(7);
		}

		if (animalName == "Jen")
		{
			print("this " + this.name + " is named Jen");
		}

		
		if (speed > 0f)
		{
			speed %= 2f;
			print(speed + " Boom");
		}

		if (health > 0)
		{
			health %= 2;
			print(health);
		}
		else
		{
			Debug.LogError("You can't divide by Zer0.");
			print("error");
		}
	}







}
