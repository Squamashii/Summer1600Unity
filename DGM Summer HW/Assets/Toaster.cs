using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour {

	public int num1;
	public int num2;

	void Start(){
		int num = AddNumbers(num1,num2);
		print (num);
	}

	public int AddNumbers(int number1, int number2){ //Upper case name (AddNumbers) makes it a function
		int result = number1 + number2;
		return result;
	}

}

	
/* 
	int slices = 15;

	void Toaster(int slot1, int slot2){ //between”()” is called the argument. These 2 slots are temporary variables
		if(slot1 == 1 || slot2 == 1){
			print("Bread is toasted!");
		}
		else if(slot1 == 1 && slot2 == 1){
			print("Both slices are toasted!");
		}
		else{
			print("Something went wrong!");
		}
	}
	Toaster(1,0); //This is where the variables are used.. when you call the function down here
	*/

	

