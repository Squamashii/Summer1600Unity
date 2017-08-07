using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public int damage = 10;
	public int delay = 5;

	void Start(){
		StartCoroutine(DestroyBullet());
	}

	void OnCollissionEnter(Collision other)
	{
		var hit = other.gameObject;
		var health = hit.GetComponent<WolfAI>();

		if(health != null){
			health.TakeDamage(damage);
		}
	}

	void OnCollisionEnter(Collision other)
	{
		var hit = other.gameObject; //We are creating a variable so we don't have to write out other.gameObject every time
		var health = hit.GetComponent<WolfAI>();

		if(health != null)
		{
			health.TakeDamage(damage);
		}
	}
	
	IEnumerator DestroyBullet(){
		yield return new WaitForSeconds(delay);
		Destroy(gameObject); //Will wait 4 seconds
	}


}
