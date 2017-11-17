using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePeasant : MonoBehaviour {

	public float MoveSpeed = 0.005f;

	void FixedUpdate () 
	{
		gameObject.transform.Translate(MoveSpeed,0,0);
	}
}
