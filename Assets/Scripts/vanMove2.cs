using UnityEngine;
using System.Collections;

public class vanMove2 : MonoBehaviour {

	public Vector3 heading;
	Vector3 heading_left, heading_right;

	public float _rangeHit = 5.0f;
	RaycastHit hit;


	public float adj_factor = 25.0f;

	public float maxSpeed=10.0f;
	public Vector3 currVelocity;
	public Vector3 currAcc;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	public Vector3 wallAvoidance()
	{
		Vector3 avoidForce = new Vector3 (0, 0, 0);

		LayerMask wall = 1 << 8;

		Vector3 curr_pos = gameObject.transform.position;
		Vector3 heading_right = transform.TransformDirection (1, 0, 0);
		Vector3 heading_left = transform.TransformDirection (-1, 0, 0);
		if (Physics.Raycast (curr_pos, heading, out hit ,wall)) 
		{
			print ("There is something in front of the object!");
			Vector3 overshoot = hit.point - transform.position;
			avoidForce += (hit.normal * (_rangeHit - overshoot.magnitude)) * adj_factor;
			avoidForce.y = 0;
		}
		if (Physics.Raycast (curr_pos, heading_right, out hit ,wall)) 
		{
			print ("There is something in right of the object!");
			Vector3 overshoot = hit.point - transform.position;
			avoidForce += Mathf.Sin (Vector3.Dot (heading_right.normalized, heading.normalized)) * ((hit.point - transform.position).normalized * _rangeHit);
			return avoidForce;
		}
		if (Physics.Raycast (curr_pos, heading_left, out hit ,wall)) 
		{
			print ("There is something in left of the object!");
			Vector3 overshoot = hit.point - transform.position;
			avoidForce += Mathf.Sin (Vector3.Dot (heading_left.normalized, heading.normalized)) * ((hit.point - transform.position).normalized * _rangeHit);			
		}
		return avoidForce;

	}

	
	private Vector3 Calculate()
	{
		Vector3 totalacc = new Vector3 (0, 0, 0);
		
		totalacc += wallAvoidance () * adj_factor;
		

		
		return totalacc;
	}
	void FixedUpdate(){
		
		currAcc = Calculate();
	} 

	void Update () {
		currVelocity += currAcc*Time.deltaTime;
		heading = currVelocity.normalized;
		
		if (currVelocity.magnitude > maxSpeed)
		{
			currVelocity=Vector3.ClampMagnitude(currVelocity,maxSpeed);
		}


	}
}
