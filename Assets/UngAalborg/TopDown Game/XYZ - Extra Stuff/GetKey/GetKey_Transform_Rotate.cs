using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey_Transform_Rotate : MonoBehaviour 
{

	public float RotationSpeed = 180;

	public KeyCode KeyLeft = KeyCode.LeftArrow, KeyRight = KeyCode.RightArrow;


	void Update () 
	{


		if (Input.GetKey (KeyLeft))
		{
			transform.Rotate (0,0,RotationSpeed * Time.deltaTime);
		} 
		else if (Input.GetKey (KeyRight))
		{
			transform.Rotate (0,0,-RotationSpeed * Time.deltaTime);
		}
			
		
	}
}
