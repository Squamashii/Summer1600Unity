using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour {


	public int timeLeft = 100;
	public Text countdownText;
	//public static UnityAction nextPage;
	public GameObject toActivate1;
	public GameObject toActivate2;

	public List<GameObject> toDeactivate;

	public void StartTimer(){
		StopCoroutine("CountDown");
		StartCoroutine("CountDown");
	}

	void Update(){
		countdownText.text = ("Time Left: " + timeLeft);
		if (timeLeft <= 0)
		{
			StopAllCoroutines();
			countdownText.text = "Times Up!";
			NextPage();
		}
	}

	public void NextPage(){
		toActivate1.gameObject.SetActive(true);
		toActivate2.gameObject.SetActive(true);
		foreach(GameObject thing in toDeactivate)
		{
			thing.gameObject.SetActive(false);
		}
	}

	IEnumerator CountDown(){
		while (true){
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}

}
