using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Calc_Script : MonoBehaviour {

	public InputField in1;
	public InputField in2;
	public Text result;
	
		public void AddClick(){
		float num = float.Parse(in1.text) + float.Parse(in2.text);
		result.text = num.ToString();
	}

	public void DivClick(){
		float num = float.Parse(in1.text) / float.Parse(in2.text);
		result.text = num.ToString();
	}
	
	public void MultClick(){
		float num = float.Parse(in1.text) * float.Parse(in2.text);
		result.text = num.ToString();
	}

	public void SubClick(){
		float num = float.Parse(in1.text) - float.Parse(in2.text);
		result.text = num.ToString();
	}
}