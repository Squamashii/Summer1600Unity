using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WolfAI : MonoBehaviour {

	//public float moveSpeed;
	//public Transform target;
	public int damage;

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

}
