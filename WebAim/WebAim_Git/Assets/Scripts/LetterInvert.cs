using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LetterInvert : MonoBehaviour {

	void Awake () {
		DysFunctions.Inverter += InvActionHandler;
		DysFunctions.Reseter += ResetHandler;
	}

	public void InvActionHandler () {
		StartCoroutine(InvertTimer());
		//this.transform.Rotate(0,0,180);
	}

	IEnumerator InvertTimer(){
		int i = 1;
		float wait_seconds = Random.Range (3, 25);
		yield return new WaitForSeconds(wait_seconds);
		this.transform.Rotate(0,0,i*180);
		this.transform.Rotate(0,i*180,0);
		i++;
	}
	
	
	public void ResetHandler () {
		StopCoroutine(InvertTimer());
		this.transform.rotation = Quaternion.identity;
	}
}

