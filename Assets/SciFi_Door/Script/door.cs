using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

	private GameObject theDoor;

	void OnTriggerEnter(Collision collision) 						// open the door animation
	{	
		if (collision.gameObject.tag == "Player") {
			theDoor = GameObject.FindWithTag ("SF_Door");
			theDoor.GetComponent<Animation>().Play("open");
		}
	}

	void OnTriggerExit(Collision collision) 						// close the door animation
	{	
		if (collision.gameObject.tag == "Player") {
			theDoor = GameObject.FindWithTag ("SF_Door");
			theDoor.GetComponent<Animation>().Play("close");
		}
	}
}
