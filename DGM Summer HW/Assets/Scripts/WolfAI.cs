using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WolfAI : MonoBehaviour {

	//public float moveSpeed;
	//public Transform target;
	public int damage;
	public int health = 100;

	//Wolf Health Related Variables
	public int currentHealth;
	public int maxHealth;
	public Transform spawnPoint;

	/*public List <Transform> wolfSpawnList;
		wolfSpawnList = new List<Transform>(wolfSpawn1);
		wolfSpawnList = new List<Transform>(wolfSpawn2);
		wolfSpawnList = new List<Transform>(wolfSpawn3);
		wolfSpawnList = new List<Transform>(wolfSpawn4);
	*/

	public List<Transform> WolfSpawnList = new List<Transform>();
	public int allScore;

	/*void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player1")
		{
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}*/

	void OnCollisionEnter(Collision other)
	{
		var hit = other.gameObject; //We are creating a variable so we don't have to write out other.gameObject every time
		var health = hit.GetComponent<PlayerHealth>();

		if(health != null)
		{
			health.TakeDamage(damage);
		}
	}

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		if(currentHealth <= 0){
			// Keep score at 0
			currentHealth = 0;
			print("Wolf is Dead!");
			// Add points to score for killing wolf
			scoreManager.AddScore(allScore);
			//move wolf to new spawn point (I want to make a Random.Range spawn)
			
			Transform spawnIndex = WolfSpawnList[Random.Range (0, WolfSpawnList.Count)];
						
			transform.position = spawnIndex.position;  //spawnPoint.position;
			transform.rotation = spawnIndex.rotation;
			//Reset wolf Health
			currentHealth = maxHealth;
		}
	}

}


