using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class FollowObject : MonoBehaviour {

    public GameObject ObjectToFollow;
    public float Speed;

    public enum Movement { Addforce, Velocity}
    public Movement MovementType;

	private Rigidbody2D _rb;

    void Awake()
    {
		_rb = GetComponent<Rigidbody2D> ();
    }


	void FixedUpdate ()
    {
        Vector3 calc = ObjectToFollow.transform.position - transform.position;
        calc.Normalize();
        transform.right = calc;

		Vector3 movement = transform.right*Speed*Time.deltaTime;

        if (MovementType == Movement.Addforce)
        {
			_rb.AddForce(movement);
        }
        else if(MovementType == Movement.Velocity)
        {
			_rb.velocity = movement;
        }


		if (movement != Vector3.zero) 
		{
			float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}
	
	}
}


