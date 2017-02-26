using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour 
{

	private static GameManager instance;

	public static GameManager Instance
	{
		get { return instance; }
	}

	private int score;

	private int lifes;

	public event Action OnGameOver;

	public event Action OnIncreaseScore;

	public int Score
	{
		get { return score; }
	}

	public int Lifes
	{
		get{ return lifes; }
	}
		

	void Awake()
	{
		lifes = 3;

		if (instance != null)
			Destroy (gameObject);
		else
			instance = this;

	}

	public void IncreaseScore()
	{
		score += 50;
		if (score % 1000 == 0)
			score += 250;

		if (OnIncreaseScore != null)
			OnIncreaseScore ();
	}

	public void BumpersCombo()
	{

		score += 2000;
		if (OnIncreaseScore != null)
			OnIncreaseScore ();
	}

	public void DecreaseLife()
	{	
		if (lifes > 0)
			lifes--;
		else {
			if(OnGameOver != null)
			OnGameOver ();
		}
	}

}
