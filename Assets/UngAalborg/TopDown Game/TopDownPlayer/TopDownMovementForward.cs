using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TopDownMovementForward : MonoBehaviour 
{

	public float PlayerSpeed; 

	private Rigidbody2D rb;

	private Vector3 _lastMovement;

	void Awake()
	{
		rb = GetComponent<Rigidbody2D> ();

	}

	// Use this for initialization
	void Start () 
	{



	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector3 movement = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);

		rb.velocity = movement * Time.deltaTime * PlayerSpeed;

	
		if (movement != Vector3.zero) 
		{
			float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}

	

	}
}
