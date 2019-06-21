﻿using UnityEngine;
using System.Collections;

public class DestroyAfterSeconds : MonoBehaviour {

    public float SecondsBeforeDestroy = 1;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, SecondsBeforeDestroy);
	}
	
}
