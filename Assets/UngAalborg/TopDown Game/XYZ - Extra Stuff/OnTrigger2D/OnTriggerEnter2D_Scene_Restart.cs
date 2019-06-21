using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnTriggerEnter2D_Scene_Restart : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
            }
        }
    }

