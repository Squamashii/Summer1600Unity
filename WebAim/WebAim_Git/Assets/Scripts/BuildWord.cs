using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuildWord : MonoBehaviour {

	
	public List<GameObject> itemsList;
	private List<GameObject> defaultWord;	
	List<GameObject> prefabList = new List<GameObject>();
	public float spacing = 2;
	public LetterScrambler scrambler;


	void Awake () {
		DysFunctions.Scrambler += ScrambleHandler;
		DysFunctions.Reseter += ResetHandler;
	}

	void Start(){		
		LoadLetters();
		SaveWord();
		BuildWords(false);
	}
	//-----------------------------------------------------------------------------------
	void LoadLetters()
	{		
		foreach(GameObject a in itemsList)
		{
			GameObject b = Instantiate(a, transform.position, transform.rotation) as GameObject;
			b.transform.parent=this.gameObject.transform;
			prefabList.Add(b);			
		}
	} 

	void SaveWord(){
		defaultWord = new List<GameObject> (prefabList);
	}

	public void ResetHandler(){
		StopCoroutine(ScrambleTimer());
		prefabList = new List<GameObject> (defaultWord);
		BuildWords(false);
	}

	public void ScrambleHandler()
	{
		StartCoroutine(ScrambleTimer());
		//BuildWords(true);
	}

	IEnumerator ScrambleTimer(){
		float wait_seconds = Random.Range (0, 10);
		yield return new WaitForSeconds(wait_seconds);
		BuildWords(true);
	}

	private void BuildWords(bool scramble){

		if(scramble)
		{
			scrambler.Randomizer(prefabList);
		}

		foreach(GameObject letter in prefabList)
		{
			letter.transform.localPosition = Vector3.zero;
		}

		float tempSpacing = spacing;
		
		foreach (GameObject letter in prefabList)
		{
			letter.transform.Translate(tempSpacing,0,0);
			tempSpacing += spacing;
		}	
	}
}
