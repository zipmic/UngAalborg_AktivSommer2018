using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdate_Rigidbody2D_AddForce_TransformDirection : MonoBehaviour {

	public enum Direction {right, left, up, down}
	public Direction TransformDirection = Direction.right;

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

		Vector3 moveDirection = Vector3.zero;

		if (TransformDirection == Direction.right) 
		{
			moveDirection = transform.right;
		}
		if (TransformDirection == Direction.left) 
		{
			moveDirection = transform.right * -1;
		}
		if (TransformDirection == Direction.up) 
		{
			moveDirection = transform.up;
		}
		if (TransformDirection == Direction.down) 
		{
			moveDirection = transform.up * -1;
		}

		Vector3 movement = moveDirection*Speed*Time.deltaTime;

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
