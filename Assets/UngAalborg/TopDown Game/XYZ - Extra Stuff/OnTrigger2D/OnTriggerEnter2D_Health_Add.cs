using UnityEngine;
using System.Collections;

public class OnTriggerEnter2D_Health_Add : MonoBehaviour
{

    public int AntalLivDenHealer = 1;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Health>())
        {
            //Den har et health script! Så nu kan vi give health...
            other.GetComponent<Health>().Heal(AntalLivDenHealer);
            
        }
    }

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.GetComponent<Health>())
		{
			//Den har et health script! Så nu kan vi give health...
			other.gameObject.GetComponent<Health>().Heal(AntalLivDenHealer);

		}
	}

}