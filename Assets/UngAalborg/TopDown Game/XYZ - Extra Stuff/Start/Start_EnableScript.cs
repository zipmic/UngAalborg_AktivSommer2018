using UnityEngine;
using System.Collections;

public class Start_EnableScript : MonoBehaviour {

    public Behaviour ScriptToEnable;

    // Use this for initialization
    void OnEnable ()
    {
        ScriptToEnable.enabled = true;
	}
	
}
