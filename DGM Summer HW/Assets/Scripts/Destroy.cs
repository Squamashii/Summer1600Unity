using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Destroy : MonoBehaviour {

	public Transform spawnPoint;
	public int points;
	public Text chickenCount;
		
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player1")
		{
			//Destroy(gameObject);
			ChickenCounter.AddChicken(points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			
		}
	}


}
