using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WordObject : MonoBehaviour {

	public List<GameObject> Letters = new List<GameObject>();	//Creates a list to fill with letters
	public int wordLength;
	public Vector3 position;
	public float letterSpacing = 10f;
//--------------------------------------------------------------------------------------
	void Awake(){
		DysFunctions.Scrambler += ScramblerHandler;
	}
	
	void Start(){
		position = this.transform.position;
		wordLength = Letters.Count;
		WordSetup();
	}
//--------------------------------------------------------------------------------------
	void WordSetup(){
		float placement = 0;
		foreach(GameObject letter in Letters){
			letter.transform.Translate(placement,0,0);
			placement += letterSpacing;
		}
	}
//--------------------------------------------------------------------------------------
	void ScramblerHandler(){
	//	Letters
	}





}
