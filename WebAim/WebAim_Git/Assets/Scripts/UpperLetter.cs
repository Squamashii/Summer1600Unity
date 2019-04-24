using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperLetter : MonoBehaviour {

	public GameObject letterPrefab = null;
	
	
	// Use this for initialization
	void Start () {
		Instantiate(letterPrefab, transform.localPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
