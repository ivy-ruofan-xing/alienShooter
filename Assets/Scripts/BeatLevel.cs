using UnityEngine;
using System.Collections;

public class BeatLevel : MonoBehaviour {
	void OnTriggerExit(Collider collision)                   // 
	{
		if (collision.gameObject.tag == "Player") {
			GameManager.gm.BeatLevel();
		}
	}
}
