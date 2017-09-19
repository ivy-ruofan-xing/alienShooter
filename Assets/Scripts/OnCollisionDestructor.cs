using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestructor : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision) 						// this is used for things that explode on impact and are NOT triggers
	{	
		Destroy (gameObject);	  // destroy the object whenever it hits something
	}
}
