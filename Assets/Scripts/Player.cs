using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	[SerializeField]
	private int lifes;

	[SerializeField]
	private Text gameOverText;

	[SerializeField]
	private GameObject myFlip1, myFlip2;



	public void LoseLife(){
	
		if (lifes > 0)
			lifes--;
		else
			LoseGame ();
	}

	void LoseGame ()
	{
		gameOverText.text = "GAME OVER";
		myFlip1.SetActive (false);
		myFlip2.SetActive (false);
	}
}
