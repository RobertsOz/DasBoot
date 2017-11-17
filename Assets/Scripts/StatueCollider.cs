using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatueCollider : MonoBehaviour {

	private GameObject DasBootInfo;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == ("Peasant"))
		{
			DasBootInfo = GameObject.Find("DasBootInfo");
			DasBootInfo.GetComponent<DasBootInfo> ().playerLives -= 1;
			if (DasBootInfo.GetComponent<DasBootInfo> ().playerLives <= 0) 
			{
				SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
			}
		}
	}
}