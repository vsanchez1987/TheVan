using UnityEngine;
using System.Collections;

public class van_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 fwd = transform.TransformDirection(Vector3.forward); //the direction the player is facing
		Vector3 left = transform.TransformDirection (-1,0,0);
		Vector3 right = transform.TransformDirection (1,0,0);
		float avoidspeed = 1f;
		LayerMask colide = 1 << 8;
		RaycastHit hit;

		if (Physics.Raycast(transform.position, fwd, 10, colide)) //if a game object is in front of player but within 10 units of it trigger a hit
		{
			Debug.Log("FRONT");
		}
		if (Physics.Raycast(transform.position, left, 10, colide)) //if a game object is in front of player but within 10 units of it trigger a hit
		{
			Debug.Log("LEFT");
			gameObject.transform.Translate(-avoidspeed,0,0);
		}
		if (Physics.Raycast(transform.position, right, 10, colide)) //if a game object is in front of player but within 10 units of it trigger a hit
		{
			Debug.Log("RIGHT");
			gameObject.transform.Translate(avoidspeed,0,0);
		}
	}
}
