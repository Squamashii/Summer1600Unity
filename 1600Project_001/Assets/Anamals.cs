using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Anamals : MonoBehaviour {

	public List<Animal> myAnimals = new List<Animal>();
	

	// Use this for initialization
	void Start ()
	{
		foreach (Animal item in myAnimals)
		{
			print(item);	
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
