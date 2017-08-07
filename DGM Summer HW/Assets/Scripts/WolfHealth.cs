using UnityEngine;
using System.Collections;

public class WolfHealth : MonoBehaviour {
	
	public int currentHealth;
	public int maxHealth;
	public Transform spawnPoint;
	public int points;

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		if(currentHealth <= 0){
			// Keep score at 0
			currentHealth = 0;
			print("Wolf is Dead!");
			// Add points to score for killing wolf
			scoreManager.AddScore(points);
			//move wolf to new spawn point (I want to make a Random.Range spawn)
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			//Reset wolf Health
			currentHealth = maxHealth;
		}
	}

}
