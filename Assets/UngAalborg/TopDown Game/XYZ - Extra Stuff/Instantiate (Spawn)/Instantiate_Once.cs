using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Once : MonoBehaviour 
{

	public GameObject ObjectToSpawn;
	public Transform SpawnPosition;

	public float Delay = 0;

	IEnumerator Start () 
	{
		yield return new WaitForSeconds (Delay);
		Instantiate (ObjectToSpawn, SpawnPosition.position, Quaternion.identity); 
	}
	

}
