using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public Button backButton;
	public Button newGameButton;
	public Button exitButton;

	void Start()
	{

	}

	// update the buttons to be in desired state
	void Update()
	{
		if (!GameManager.gm.gameHasBeenPlayed) {
			transform.Find ("New Game Text Button").gameObject.SetActive (true);
			transform.Find ("Back Text Button").gameObject.SetActive (false);

//			backButton.enabled = false;
//			newGameButton.enabled = true;
		} else {
			transform.Find ("New Game Text Button").gameObject.SetActive (false);
			transform.Find ("Back Text Button").gameObject.SetActive (true);

//			backButton.enabled = true;
//			newGameButton.enabled = false;
		}
	}

	// back to start of the game
	public void BackToStart()
	{
		GameManager.gm.RestartGame ();
	}

	// start new game
	public void StartNewGame()
	{
//		Debug.Log ("Start new game");
		GameManager.gm.StartGame();
	}

	//exit game
	public void ExitGame()
	{
//		Debug.Log ("Quit game");
		Application.Quit ();
	}
}
