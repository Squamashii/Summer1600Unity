using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LetterReversal : MonoBehaviour {

	void Awake () {
		DysFunctions.Reverser += RevActionHandler;
		DysFunctions.Reseter += ResetHandler;
	}
	
	public void RevActionHandler () {
		StartCoroutine(ReverseTimer());
		//this.transform.Rotate(0,180,0);
	}
	
	IEnumerator ReverseTimer(){
		int i = 1;
		float wait_seconds = Random.Range (0, 10);
		yield return new WaitForSeconds(wait_seconds);
		this.transform.Rotate(0,i*180,0);
		i++;
	}

	public void ResetHandler () {
		StopCoroutine(ReverseTimer());
		this.transform.rotation = Quaternion.identity;
	}
}
