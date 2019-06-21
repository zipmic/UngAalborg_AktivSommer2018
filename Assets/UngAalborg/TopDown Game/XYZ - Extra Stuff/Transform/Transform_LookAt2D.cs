using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_LookAt2D : MonoBehaviour {

	public Transform ObjectToLookAt;
	private Rigidbody2D _rb;

	// Use this for initialization
	void Awake () 
	{

		_rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () 
	{

		Vector3 dir = ObjectToLookAt.transform.position - transform.position;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);

		
	}
}
