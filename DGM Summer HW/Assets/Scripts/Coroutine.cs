using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour {

	public int number = 10;
	public int maxNumber;

	public int ammo;

	void Start () {
	StartCoroutine(Stuff());
	StartCoroutine(AmmoLoad());
	}
	
	IEnumerator Stuff(){
		while(number<maxNumber) 
		{
			print("Health at " + number);
			yield return new WaitForSeconds(2);
			number ++;
		}

		/*print("First Action");
		yield return new WaitForSeconds(5);
		print("Second Action");
		*/
	}

	IEnumerator AmmoLoad(){
		while(ammo<15){
			print("Ammo at " + ammo);
			yield return new WaitForSeconds(1);
			ammo ++;	
		}
	}

	

}
