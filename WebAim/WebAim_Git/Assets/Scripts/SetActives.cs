using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActives : MonoBehaviour {

	public List<GameObject> page1;
	public List<GameObject> page2;

	void Awake () {
		DysFunctions.Page1Set += ActivatePage1;
		DysFunctions.Page2Set += ActivatePage2;
	}

	public void ActivatePage1()
	{
		foreach (GameObject item in page2)
		{
			
			if(gameObject.activeSelf)
			{
				item.gameObject.SetActive(false);
			}
			else if(!gameObject.activeSelf)
			{
				item.gameObject.SetActive(true);
			}
			else{
				item.gameObject.SetActive(true);
			}
		}				
	}

	public void ActivatePage2()
	{
		foreach (GameObject item in page2)
		{
			
			if(gameObject.activeSelf)
			{
				item.gameObject.SetActive(false);
			}
			else if(!gameObject.activeSelf)
			{
				item.gameObject.SetActive(true);
			}
			else{
				item.gameObject.SetActive(true);
			}
		}		
	}	
}
