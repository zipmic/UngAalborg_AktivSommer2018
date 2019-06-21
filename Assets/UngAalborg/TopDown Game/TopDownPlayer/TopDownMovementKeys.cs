using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TopDownMovementKeys: MonoBehaviour 
{

	public float PlayerSpeed; 

	public SpriteRenderer PlayerSpriteRenderer;
	public Sprite Up,Down,Right,Left;

	private Rigidbody2D rb;
	private Vector3 _lastDir;


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
		Vector3 movement = Vector3.zero;

		if (Input.GetKey (KeyCode.W)) 
		{
			movement += Vector3.up;
			if (Up != null) {
				PlayerSpriteRenderer.sprite = Up;
			}
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			movement += Vector3.down;
			if (Down != null) {
				PlayerSpriteRenderer.sprite = Down;
			}
		}

		if (Input.GetKey (KeyCode.A)) 
		{

			movement += Vector3.left;
			if (Left != null) {
				PlayerSpriteRenderer.sprite = Left;
			}
		}

		if (Input.GetKey (KeyCode.D)) 
		{

			movement += Vector3.right;
			if (Right != null) {
				PlayerSpriteRenderer.sprite = Right;
			}
		}


		rb.velocity = movement * Time.deltaTime * PlayerSpeed;

	




	

	}
}
