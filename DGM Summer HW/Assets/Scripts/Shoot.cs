using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shoot : MonoBehaviour {

public Rigidbody projectile;
public Transform SpawnPoint;
public float shootSpeed;


	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1")){
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, SpawnPoint.position, projectile.rotation);
			clone.velocity = SpawnPoint.TransformDirection (Vector3.forward*shootSpeed);
			
		}
	}

	



}
