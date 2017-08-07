using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {

    public int damage;

	void Update ()
    {
        Destroy(gameObject, 5);
    }

    
    
}
