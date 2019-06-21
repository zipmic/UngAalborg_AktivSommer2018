using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // bruges til at skifte mellem scener.

public class OnTriggerEnter2D_Scene_LoadScene : MonoBehaviour 
{

    public string TagName = "Player";
    public string SceneNavn;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == TagName)
        {
            PlayerPrefs.SetFloat("CheckPointX", 0);
            PlayerPrefs.SetFloat("CheckPointY", 0);
            PlayerPrefs.SetFloat("CheckPointZ", 0);
            SceneManager.LoadScene(SceneNavn);
        }

    }

	void OnCollisionEnter2D(Collision2D other)
	{

		if (other.gameObject.tag == TagName)
		{
			PlayerPrefs.SetFloat("CheckPointX", 0);
			PlayerPrefs.SetFloat("CheckPointY", 0);
			PlayerPrefs.SetFloat("CheckPointZ", 0);
			SceneManager.LoadScene(SceneNavn);
		}

	}
}
