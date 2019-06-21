using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class ProjectileSpeed : MonoBehaviour {


	public float Speed = 100;
	private Rigidbody2D _rb;

	// Use this for initialization
	void Awake () 
	{
		_rb = GetComponent<Rigidbody2D> ();
	}

	void Start()
	{
		_rb.velocity = transform.right * Speed;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
