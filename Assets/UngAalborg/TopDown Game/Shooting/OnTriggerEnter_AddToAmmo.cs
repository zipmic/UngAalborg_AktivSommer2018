using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OnTriggerEnter_AddToAmmo : MonoBehaviour {

	public int AmmoToAdd = 1;
	public bool DestroyAfterUse = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.GetComponent<PlayerShoot> ())
		{
			other.GetComponent<PlayerShoot> ().Ammo += AmmoToAdd;
			if (DestroyAfterUse) {
				Destroy (gameObject);
			}
		}
	}
}
