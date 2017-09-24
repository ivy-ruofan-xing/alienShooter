using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

	private GameObject theDoor;

	void OnTriggerEnter(Collider collision) 					// open the door animation
	{	
		if (collision.gameObject.tag == "Player") {
			theDoor = GameObject.FindWithTag ("SF_Door");
			theDoor.GetComponent<Animation>().Play("open");
		}
	}

	void OnTriggerExit(Collider collision) 						// close the door animation
	{	
		if (collision.gameObject.tag == "Player") {
			theDoor = GameObject.FindWithTag ("SF_Door");
			theDoor.GetComponent<Animation>().Play("close");
		}
	}
}
