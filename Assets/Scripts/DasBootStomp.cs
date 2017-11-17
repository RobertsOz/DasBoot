using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DasBootStomp : MonoBehaviour {

	private Vector3 StompSpeed = new Vector3(0, -2,0);

	private Vector3 StompRecover = new Vector3(0, 0 ,0);

	private Vector3 StartingPosition;

	private bool NotStomping = true;

	private bool PositionReset = true;
	// Use this for initialization
	void Start () 
	{
		StompRecover.y = gameObject.GetComponent<DasBootInfo>().refreshRate;
		StartingPosition = gameObject.GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		if (gameObject.transform.position.y <= -10)
		{
			NotStomping = true;
			gameObject.transform.Translate (0, 5, 0);
		}

		if (Input.GetAxis("Fire1")>0 && PositionReset == true)
		{
			NotStomping = false;
		}

		if (NotStomping == false)
		{
			gameObject.transform.Translate(StompSpeed);
			PositionReset = false;
		}

		if (NotStomping == true && gameObject.transform.position.y < StartingPosition.y)
		{
			gameObject.transform.Translate (StompRecover);
		} 

		if (gameObject.transform.position.y >= StartingPosition.y)
		{
			print ("Reset Position");
			PositionReset = true;
		}

	}

	void OnCollisionEnter2D (Collision2D OtherObject)
	{
		if (OtherObject.gameObject.name == "Floor")
		{
			NotStomping = true;
		}
	}
}
