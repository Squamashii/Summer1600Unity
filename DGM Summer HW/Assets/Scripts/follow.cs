using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	//public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public float relaxSpeed;
	public float rRs;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player1")
		{
			transform.Rotate(0,2,0);
			transform.LookAt(target);
			transform.Translate(Vector3.forward*-moveSpeed*Time.deltaTime);	
		}

		else
		{
			transform.Rotate(0,rRs,0);
			transform.Translate(Vector3.forward*relaxSpeed*Time.deltaTime);
		}
	}

	

}
