using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Move3D : MonoBehaviour {
	
	public float myForce = 500.0f;
	private Rigidbody myR;
	public bool canJump;
	public float moveSpeed;
	public float turnSpeed;
		
	void Start()
	{
		myR = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () 
	{
		if(Input.GetKeyDown(KeyCode.Space) && canJump)
		{
			Jump();
		}
	}

	void Update()
	{
	 var y = Input.GetAxis("Horizontal")*Time.deltaTime*turnSpeed;
	 var z = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;	
	
		transform.Rotate(0,y,0);
		transform.Translate(0,0,z);
	}

	private void Jump()
	{
		myR.AddForce(0, myForce, 0);
		canJump = false;
	}

	void OnCollisionEnter()
	{
		canJump = true;
	}

}
