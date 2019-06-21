using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_SceneManager_LoadScene : MonoBehaviour 
{

	public string SceneToLoad;

	public bool LoadSameLevel;


	void Start () 
	{
		if (LoadSameLevel)
		{
			SceneToLoad = SceneManager.GetActiveScene ().name;
		}
		SceneManager.LoadScene (SceneToLoad);
	}


}
