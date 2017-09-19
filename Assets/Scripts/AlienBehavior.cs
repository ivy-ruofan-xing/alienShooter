using UnityEngine;
using System.Collections;

public class AlienBehavior : MonoBehaviour
{

	// target impact on game
	public int scoreAmount = 0;
	public float timeAmount = 0.0f;
	public float exitAnimationSeconds = 1f; // should be >= time of the exit animation

	private bool startDestroy = false;

	// when collided with another gameObject
	void OnCollisionEnter (Collision newCollision)
	{
		// exit if there is a game manager and the game is over
		if (GameManager.gm) {
			if (GameManager.gm.gameIsOver)
				return;
		}

		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			// if game manager exists, make adjustments based on target properties
			if (GameManager.gm) {
				GameManager.gm.targetHit (scoreAmount, timeAmount);
			}

			if (this.GetComponent<Animator> () == null)
				// no Animator so just destroy right away
				Destroy (gameObject);
			else if (!startDestroy) {
				// set startDestroy to true so this code will not run a second time
				startDestroy = true;

				// destroy the projectile
				Destroy (newCollision.gameObject);

				// trigger the Animator to make the "Exit" transition
				this.GetComponent<Animator> ().SetTrigger ("Exit");

				// Call KillTarget function after exitAnimationSeconds to give time for animation to play
				Invoke ("KillTarget", exitAnimationSeconds);
			}
		}
	}

	// destroy the gameObject when called
	void KillTarget ()
	{
		// remove the gameObject
		Destroy (gameObject);
	}
}
