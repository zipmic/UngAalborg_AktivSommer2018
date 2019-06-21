using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_GameObject_Enable : MonoBehaviour 
{

	public GameObject ObjectToEnable;

	// Use this for initialization
	void Start () {

		ObjectToEnable.SetActive (true);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
