using UnityEngine;
using System.Collections;

public class GetKey_DisableGameObject : MonoBehaviour
{
    public KeyCode KeyToPress;
    public GameObject ObjectToDisable;

    public enum ButtonType {SkalSlippes, SkalIkkeSlippes}
    public ButtonType TypeOfButtonPress;
    public float CoolDownTime = 0.5f;

    private float Counter = 0;
	
	// Update is called once per frame
	void Update ()
    {
	    if(TypeOfButtonPress == ButtonType.SkalIkkeSlippes)
        {
            if(Input.GetKey(KeyToPress))
            {
                if(Counter <= 0)
                {
                    Counter = CoolDownTime;
                    ObjectToDisable.SetActive(false);
                }
            }
        }

        else if(TypeOfButtonPress == ButtonType.SkalSlippes)
        {

            if (Input.GetKeyDown(KeyToPress))
            {
                if (Counter <= 0)
                {
                    Counter = CoolDownTime;
					ObjectToDisable.SetActive(false);
                }
            }
        }

        if(Counter > 0)
        {
            Counter -= Time.deltaTime;
        }
	}
}
