using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoButton : MonoBehaviour {

	public List<GameObject> toActivate;
	public List<GameObject> toDeactivate;
	//public static UnityAction StartSimCall;

	public void StartSim(){
		
		foreach(GameObject thing in toActivate){
			thing.gameObject.SetActive(true);
		}

		foreach(GameObject thing in toDeactivate){
			thing.gameObject.SetActive(false);
		}

		//StartSimCall();
	}
}
