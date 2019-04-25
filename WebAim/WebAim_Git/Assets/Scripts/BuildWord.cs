using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuildWord : MonoBehaviour {

	
	public List<GameObject> itemsList;
	private List<GameObject> defaultWord;	
	List<GameObject> prefabList = new List<GameObject>();
	public float spacing = 50f;
	public LetterScrambler scrambler;
	private bool running = false;


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
	public void LoadLetters()
	{		
		foreach(GameObject a in itemsList)
		{
			GameObject b = Instantiate(a, transform.position, transform.rotation) as GameObject;
			b.transform.parent=gameObject.transform;
			prefabList.Add(b);			
		}
	}

	public void WipeEverything()
	{
		foreach (GameObject prefab in prefabList)
		{
			Destroy(prefab);
		}
		prefabList.Clear();
	}
	
	public void SaveWord(){
		defaultWord = new List<GameObject> (prefabList);
	}

	public void ResetHandler()
	{
		running = false;
		StopAllCoroutines();
		//StopCoroutine(ScrambleTimer());
		prefabList = new List<GameObject> (defaultWord);
		BuildWords(false);
		Debug.Log("Scrambler is Reset: " + running);
	}

	public void ScrambleHandler()
	{
		StartCoroutine(ScrambleTimer());
		//BuildWords(true);
	}

	IEnumerator ScrambleTimer()
	{	
		running = true;	
		while (running)
		{
			float wait_seconds = Random.Range (1, 20);
			yield return new WaitForSeconds(wait_seconds);
			BuildWords(true);			
		}
	}

	public void BuildWords(bool scramble){

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
