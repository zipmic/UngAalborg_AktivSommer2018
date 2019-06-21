using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerShoot : MonoBehaviour {

	public Transform ProjectileSpawnPoint;

	public KeyCode ButtonToShootWith;

	public GameObject Projectile;

	public float DelayBetweenShooting = 0.5f;
	private float _counter;

	public bool EnableAmmo;
	public int Ammo = 0;

	// Use this for initialization
	void Start () {

		_counter = DelayBetweenShooting;
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (ButtonToShootWith) && _counter > DelayBetweenShooting) 
		{
			if (EnableAmmo && Ammo >= 0) {
				GameObject obj = Instantiate (Projectile) as GameObject;
				obj.transform.position = ProjectileSpawnPoint.position;
				obj.transform.right = transform.right;
				Ammo--;
			} else if (EnableAmmo == false)
			{
				GameObject obj = Instantiate (Projectile) as GameObject;
				obj.transform.position = ProjectileSpawnPoint.position;
				obj.transform.right = transform.right;
			}

			_counter = 0;
		}

		_counter += Time.deltaTime;

	}



}


