using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Destroy : MonoBehaviour {

	public Transform spawnPoint;
	public int points;
		
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player1")
		{
			//Destroy(gameObject);
			scoreManager.AddPoints(points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			
		}
	}


}
