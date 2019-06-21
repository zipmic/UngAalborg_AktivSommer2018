using UnityEngine;
using System.Collections;

public class OnDestroy_SpawnGameObject : MonoBehaviour {

    public GameObject SpawnThisOnDestroy;

	void OnDestroy()
    {
        GameObject t = Instantiate(SpawnThisOnDestroy) as GameObject;
        t.transform.position = transform.position;
      
    }
}
