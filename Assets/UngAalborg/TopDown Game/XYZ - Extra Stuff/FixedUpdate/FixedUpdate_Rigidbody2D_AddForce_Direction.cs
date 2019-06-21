using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdate_Rigidbody2D_AddForce_Direction : MonoBehaviour {

	public Vector2 Direction = Vector2.right;
	public float Speed;

	public enum Movement { Addforce, Velocity}
	public Movement MovementType;

	private Rigidbody2D _rb;

	void Awake()
	{
		_rb = GetComponent<Rigidbody2D> ();
	}


	void FixedUpdate ()
	{

		Vector3 movement = Direction*Speed*Time.deltaTime;

		if (MovementType == Movement.Addforce)
		{
			_rb.AddForce(movement);
		}
		else if(MovementType == Movement.Velocity)
		{
			_rb.velocity = movement;
		}


	}
}
