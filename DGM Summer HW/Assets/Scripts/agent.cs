using UnityEngine;
using System.Collections;

public class agent : MonoBehaviour {

	public Transform target;
	NavMeshAgent wolfAgent;

	void Start () {
		wolfAgent = GetComponent<NavMeshAgent>();
	}
	
	void Update() {
		wolfAgent.SetDestination(target.position);
	}
}
