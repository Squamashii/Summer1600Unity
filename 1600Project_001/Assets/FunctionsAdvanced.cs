using UnityEngine;
using System.Collections;

public class FunctionsAdvanced : MonoBehaviour {

public string keyWord;
public int health;

void Start()
{
	health = PowerUp(10);
	keyWord = PowerUp("OU812");
}


string PowerUp (string _s)
{
	return _s;
}

int PowerUp (int _i)
{
	return _i;
}	




}
