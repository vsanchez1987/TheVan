using UnityEngine;
using System.Collections;

public class van_control : MonoBehaviour {

	public float avoidspeed = 1f;
	public float ray_distance = 10f;

	Vector3 fwd, left, right;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 15;
		Vector3 rgt = new Vector3 (-2,0,1);
		Vector3 lft = new Vector3 (2,0,1);
		fwd = transform.TransformDirection(Vector3.forward); //the direction the player is facing
		right = transform.TransformDirection (-2,0,1);
		left = transform.TransformDirection (2,0,1);
		LayerMask colide = 1 << 8;
		RaycastHit hit;
		Debug.DrawRay (transform.position, forward, Color.green);
		Debug.DrawRay (transform.position, lft, Color.red);
		Debug.DrawRay (transform.position, rgt, Color.blue);

		if (Physics.Raycast(transform.position, fwd, out hit, ray_distance, colide)) 
		{
			Debug.Log("FRONT");
		}

		if (Physics.Raycast(transform.position, left, out hit, ray_distance, colide))
		{
			Debug.Log("LEFT");
			gameObject.transform.Translate(-avoidspeed,0,0);
		}

		if (Physics.Raycast(transform.position, right, out hit, ray_distance, colide)) 
		{
			Debug.Log("RIGHT");
			gameObject.transform.Translate(avoidspeed,0,0);
		}
	}


}
