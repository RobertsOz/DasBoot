using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour {

	public int Health;
	public int EnemyScore;

	private GameObject DASBOOT;

	void OnTriggerEnter2D(Collider2D Boot)
	{
		if (Boot.gameObject.name == "Das Boot")
		{
			Health -= 1;
		}

		if (Health <= 0)
		{
			DASBOOT = GameObject.Find("Das Boot");
			DASBOOT.GetComponent<DasBootInfo> ().Score += EnemyScore;
			print (DASBOOT.GetComponent<DasBootInfo> ().Score);
			Destroy (gameObject);
		}
	}


}
