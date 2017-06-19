using UnityEngine;
using System.Collections;

public class ScopeAccess : MonoBehaviour {

public int coins = 0;

void Attack(){

	void SwordAttack(){

		if(SwordAttack > EnemyDefense){
			EnemyHealth.AddDamage();
		}
		else{
			EndTurn();
		}
	}

	void AxeAttack(){
		
		if(AxeAttack > EnemyDefense){
			EnemyHealth.AddDamage();
		}
		else{
			EndTurn();
		}

	}
}





}
