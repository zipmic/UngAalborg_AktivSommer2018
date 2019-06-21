using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class OnTriggerEnter2D_AudioSource_PlayOneShot : MonoBehaviour {

    public AudioClip SoundToPlay;

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(SoundToPlay);
        }
    }

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			GetComponent<AudioSource>().PlayOneShot(SoundToPlay);
		}
	}
}
