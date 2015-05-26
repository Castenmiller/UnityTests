using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseMove : MonoBehaviour {
	
	private float speed = 1.0f;
	private Vector3 target;
	private Vector3 start;
	private Vector3 pos;

	private Vector3 MouseCoords;

	private RaycastHit rayHit;

	private Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		start = transform.position;
		pos = transform.position;
	}
	
	void Update ()
	{
		if(Input.GetMouseButtonUp(0))
		{
			pos = Input.mousePosition;
			//pos.x = 0.0f;
			//pos.y = 0.0f;
			//pos.z = 0.0f;
			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
			//Debug.Log(ray);

	

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out rayHit, 100))
			{
				Debug.DrawLine(ray.origin, rayHit.point);
				Debug.Log(rayHit.point);
				pos = rayHit.point;
				//pos.y = 20;
				//transform.position = Vector3.Lerp(transform.position, pos, speed*Time.deltaTime);

				rb.AddForce (0.0f, 20000.0f, 0.0f);
				rb.AddTorque(Random.value*1000.0f, Random.value*1000.0f, Random.value*1000.0f);

			}

			//pos = Camera.main.ScreenPointToRay(ray);
			//Debug.Log(pos);

		}

		rb.position = Vector3.Lerp(transform.position, pos, speed*Time.deltaTime);


		//rb.position = Vector3.Lerp(transform.position, pos, speed*Time.deltaTime);

		//rb.AddForce (0.0f, -150.0f, 0.0f);
	}
}