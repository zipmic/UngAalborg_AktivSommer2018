using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_GameObject_Disable : MonoBehaviour 
{

	public GameObject ObjectToDisable;

	// Use this for initialization
	void Start () {

		ObjectToDisable.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
