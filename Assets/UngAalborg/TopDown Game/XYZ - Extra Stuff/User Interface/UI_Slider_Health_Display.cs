using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Slider_Health_Display : MonoBehaviour {

	public Health GameObjectMedHealthScript;

	private Slider _slider;

	// Use this for initialization
	void Awake () {

		_slider = GetComponent<Slider> ();

	}

	void Start()
	{
		_slider.maxValue = GameObjectMedHealthScript.MaxLiv;
		_slider.minValue = 0;
		_slider.value    = GameObjectMedHealthScript.Liv;
	}
	
	// Update is called once per frame
	void Update () 
	{

		_slider.value = GameObjectMedHealthScript.Liv;
		
	}
}
