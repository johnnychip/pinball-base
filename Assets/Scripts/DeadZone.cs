﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour {

	[SerializeField]
	private Transform spawnTransform;


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "ball") 
		{
			if (GameManager.Instance.Lifes > 0) 
			{
				other.gameObject.transform.position = spawnTransform.position;	
			} else 
			{
				other.gameObject.SetActive (false);
			}
			GameManager.Instance.DecreaseLife ();

		}
	}



}
