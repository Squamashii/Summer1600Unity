using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LetterReversal : MonoBehaviour
{
	private bool running = false;
	
	void Awake () {
		DysFunctions.Reverser += RevActionHandler;
		DysFunctions.Reseter += ResetHandler;
	}
	
	public void RevActionHandler () {
		StartCoroutine(ReverseTimer());
		//this.transform.Rotate(0,180,0);
	}
	
	IEnumerator ReverseTimer()
	{
		running = true;
		while (running)
		{
			float wait_seconds = Random.Range (1, 100);
			yield return new WaitForSeconds(wait_seconds);
			this.transform.Rotate(0,180,0);
		}
	}

	public void ResetHandler ()
	{
		running = false;
		StopCoroutine(ReverseTimer());
		this.transform.rotation = Quaternion.identity;
	}
}
