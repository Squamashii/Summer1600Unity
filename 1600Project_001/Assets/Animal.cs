using UnityEngine;
using System.Collections;

public class Animal: MonoBehaviour {

	//Classes are the levels of hierarchy of objects in a unity project. 
	//For example, "dog" is a class of "mammal" which is a class of "animal" which is a class of "life-form" 
	//Everything in the upper levels is also applicable in the lower levels unless otherwise stated


	//PROPERTIES (Things they are or have)
	//Body Segments
	public string[] bodySegments = { "Head", "Abs", "Thorax" };
	//Health
	public int health = 100;
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
//Move
//Die
//Grow

}
