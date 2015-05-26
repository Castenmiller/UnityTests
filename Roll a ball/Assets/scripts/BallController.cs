using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallController : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");
		
		//Vector3 movement = new Vector3 (moveHorizontal, moveVertical*5, 0.0f);
		
		//rb.AddForce (movement * speed);
		//rb.AddTorque (0.5f, 0.5f, 0.5f);
		
		if (Input.GetKeyUp (KeyCode.Space)) {
			Vector3 movement = new Vector3 (100.0f*Random.value-100.0f*Random.value, 250.0f, 100.0f*Random.value-100.0f*Random.value);
			
			rb.AddForce (movement * speed);
		}
	}

	void FixedUpdate ()
	{
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");
		
		//Vector3 movement = new Vector3 (moveHorizontal, moveVertical*5, 0.0f);
		
		rb.AddForce (0.0f, -150.0f, 0.0f);
		//rb.AddTorque (0.5f, 0.5f, 0.5f);

		//Input.GetKeyUp (KeyCode.Space);
	}
}