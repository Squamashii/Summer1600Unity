using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth = 100;
	public float hpBoostSpeed;

	public Text hp;
	public Text maxHP;


	void OnTrigger (Collider other)
	{
		if(other.gameObject.name == "Chicken Pen")
		{
			StartCoroutine(HPBoost());
		}
	}

	IEnumerator HPBoost(){
		if(currentHealth<maxHealth){
			currentHealth ++;
			yield return new WaitForSeconds(hpBoostSpeed*Time.deltaTime);
		}
	}

	void Update () {
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();
	}

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth = 0;
			TryAgain();
		}
	}

	
	public void TryAgain () {
	SceneManager.LoadScene(2);
	}

}


