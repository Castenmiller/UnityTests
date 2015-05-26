using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject player;
	
	private Vector3 offset;
	
	void Start ()
	{
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate ()
	{
		transform.position = new Vector3 (player.transform.position.x + offset.x, offset.y, player.transform.position.z + offset.z);
	}
}