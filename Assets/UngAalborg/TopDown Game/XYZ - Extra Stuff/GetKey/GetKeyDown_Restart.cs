﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GetKeyDown_Restart : MonoBehaviour {

    public KeyCode ButtonForRestartLevel;
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(ButtonForRestartLevel))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	
	}
}
