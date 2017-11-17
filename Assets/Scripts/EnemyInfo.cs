using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour {

	public int Health;
	public int EnemyScore;

	private GameObject ScoreManager;

	void OnTriggerEnter2D(Collider2D Boot)
	{
		if (Boot.gameObject.name == "Das Boot")
		{
			Health -= 1;
		}

		if (Health <= 0)
		{
			ScoreManager = GameObject.Find("ScoreManager");
			ScoreManager.GetComponent<ScoreManager> ().score += EnemyScore;
			print (ScoreManager.GetComponent<ScoreManager> ().score);
			Destroy (gameObject);
		}
	}
}
