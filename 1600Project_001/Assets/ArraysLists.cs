using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArraysLists : MonoBehaviour {

	public List<string> players = new List<string>() ;

	public List<int> doubleStuff = new List<int>();
	

	// Use this for initialization
	void Start () {
		
	}

	public void ClickHere(string _s)
	{
		players.Add(_s);
	}

	public void RunLoop()
	{
		foreach (string item in players)
		{
			print(item);
		}
		
		if (players.Count != 1)
		{
			print("There are currently " + players.Count + " players in the game");
		}
		else
		{
			print("There is currently " + players.Count + " player in the game");
		}


		doubleStuff.Add(5);
		doubleStuff.Add(7);
		doubleStuff.Add(13);
		doubleStuff.Add(2);

		foreach (int item in doubleStuff)
		{
			print(item*2);
		}
		



	}		



	// Update is called once per frame
	void Update () {
	
	}
}
