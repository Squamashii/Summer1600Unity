using UnityEngine;
using System.Collections;

public class move3D : MonoBehaviour {
	public float moveSpeed;
	public float turnSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var y = Input.GetAxis("Horizontal")*Time.deltaTime*turnSpeed; //Time.deltaTime makes it update a fixed number per second
		var z = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
	
		transform.Rotate(0,y,0);
		transform.Translate(0,0,z);
	
	}
}
