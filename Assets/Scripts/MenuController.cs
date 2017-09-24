using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public Button newGameButton;
	public Button exitButton;

	// start new game
	public void StartNewGame()
	{
		Debug.Log ("Start new game");
		GameManager.gm.StartGame();
	}

	public void ExitGame()
	{
		Debug.Log ("Quit game");
		Application.Quit ();
	}
}
