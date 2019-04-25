using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LetterInvert : MonoBehaviour {

	bool running = false;
	
	void Awake () {
		DysFunctions.Inverter += InvActionHandler;
		DysFunctions.Reseter += ResetHandler;
	}

	public void InvActionHandler () {
		StartCoroutine(InvertTimer());
		//this.transform.Rotate(0,0,180);
	}

	IEnumerator InvertTimer()
	{
		running = true;
		while (running)
		{
			float wait_seconds = Random.Range (1, 100);
			yield return new WaitForSeconds(wait_seconds);
			this.transform.Rotate(0,0,180);
			this.transform.Rotate(0,180,0);
		}
		
	}
	
	
	public void ResetHandler ()
	{
		running = false;
		StopAllCoroutines();
		//StopCoroutine(InvertTimer());
		this.transform.rotation = Quaternion.identity;
		Debug.Log("Invert is Reset: " + running);
	}
}

