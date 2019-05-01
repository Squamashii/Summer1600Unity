using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DysFunctions : MonoBehaviour {

	public static UnityAction Inverter;
	public static UnityAction Reverser;
	public static UnityAction Scrambler;
	public static UnityAction Reseter;
	public static UnityAction Page1Set;
	public static UnityAction Page2Set;

	public void SimCallHandler(){
		Inverter();
		Reverser();
		Scrambler();
	}
	public void ResetAction(){
		Reseter();
	}
	public void Page1Action(){
		Page1Set();
	}
	public void Page2Action(){
		Page2Set();
	}
	
}
