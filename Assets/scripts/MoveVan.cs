using UnityEngine;
using System.Collections;

public class MoveVan : MonoBehaviour {
	public GameObject van;
	public State currentState;
	public GameObject wayPointRight, wayPointCenter, wayPointLeft;
	public float speed = 10;
	public int zombieSize;
	private RaycastHit hit;

	//public Rigidbody obstical;

	public Transform target;

	Vector3 heading_left, heading_right;
	public Vector3 curr_pos;
	public Vector3 heading;
	public float _rangeHit = 5.0f;
	public float adj_factor = 25.0f;

	


	public enum State{
		swerve,
		slow,
		go
	};


	// Use this for initialization
	void Start () {
		van = GameObject.FindWithTag("van");
		wayPointRight= GameObject.FindGameObjectWithTag("wayPointRight");
		wayPointLeft= GameObject.FindGameObjectWithTag("wayPointLeft");
		wayPointCenter= GameObject.FindGameObjectWithTag("wayPointCenter");

		zombieSize = 0;


	}
	
//	// Update is called once per frame
//	void Update () {
//
//		//transform.Translate (Vector3.forward * speed * Time.deltaTime);
//
//		Ray impactRay = new Ray (transform.position, Vector3.forward);
//
//		Debug.DrawRay(transform.position, Vector3.forward ,Color.blue);
//
//		if(Physics.Raycast(impactRay, out hit, 20.0f))
//		{
//
//		
//
//			if(collider.CompareTag("obstical"))
//			
//			
//				if (currentState == State.swerve) 
//				{
//					Debug.Log("in the swerve state");
////					if(target != null)
////					{
////					//	wayPointRight.transform.position = target.transform.position - transform.position;
////					//	Quaternion rotation = Quaternion.LookRotation(wayPointRight.transform);
////
////						transform.rotation = Quaternion.Slerp(transform.rotation,rotation, Time.deltaTime);
////						transform.Translate(0,0,3 * Time.deltaTime);
////					}
//
//
//				}
//
////			if(rigidbody.CompareTag("zombie"))
////				if (currentState == State.slow) 
////			{
////				Vector3 direction = target.transform.position - transform.position;
////				direction.y = 0.0f;
////				Quaternion rotation = Quaternion.LookRotation(direction);
////				
////				transform.rotation = Quaternion.Slerp(transform.rotation,rotation, Time.deltaTime);
////				transform.Translate(0,0,3 * Time.deltaTime);
////
////				speed -= 1;
////				
////				
////			}
//		//}
//
//
//
//
//		}
//	}

	private Vector3 Calculate()
	{
		Vector3 totalacc = new Vector3 (0, 0, 0);
		
		totalacc += ObjectAvoidance () * adj_factor;
		

		
		return totalacc;
	}

	public Vector3 ObjectAvoidance()
	{
		Vector3 avoidForce = new Vector3 (0,0,0);
		RaycastHit hit;
		LayerMask obstical = 1 << 8; //hit only in layer 8
		
		//Debug.Log("Calculating avoidance");
		
		curr_pos = gameObject.transform.position;
		heading_right = transform.TransformDirection (1,0,0);
		heading_left = transform.TransformDirection (-1,0,0);
		
		if (Physics.Raycast (curr_pos, heading, out hit, _rangeHit, obstical)) 
		{
			Vector3 overshoot = hit.point - transform.position;
			avoidForce += (hit.normal * (_rangeHit - overshoot.magnitude)) * adj_factor;
			avoidForce.y = 0;
			
		}
		if (Physics.Raycast (curr_pos, heading_right, out hit, _rangeHit, obstical)) 
		{
			Vector3 overshoot = hit.point - transform.position;
			avoidForce += Mathf.Sin (Vector3.Dot (heading_right.normalized, heading.normalized)) * ((hit.point - transform.position).normalized * _rangeHit);
			return avoidForce;
		}
		if (Physics.Raycast (curr_pos, heading_left, out hit, _rangeHit, obstical)) 
		{
			Vector3 overshoot = hit.point - transform.position;
			avoidForce += Mathf.Sin (Vector3.Dot (heading_left.normalized, heading.normalized)) * ((hit.point - transform.position).normalized * _rangeHit);			
		}
		return avoidForce;
	}

	float radius = 0.5f;
	public GameObject waypointTarget;

	void OnDrawGizmos ()
	{
		Gizmos.color = new Color(1.0f, 1.0f, 0.0f, 0.5f);
		Gizmos.DrawLine(this.transform.position,transform.TransformPoint(0.0f,0.0f,_rangeHit));
		Gizmos.DrawLine(this.transform.position,transform.TransformPoint(_rangeHit/1.41f,0.0f,_rangeHit/1.41f));
		Gizmos.DrawLine(this.transform.position,transform.TransformPoint(-_rangeHit/1.41f,0.0f ,_rangeHit/1.41f));
		
	}
	
//	void OnDrawGizmos () { //Draws a line to next waypoint and a sphere 
//		Gizmos.color = new Color(1.0f, 1.0f, 0.0f, 0.5f);
//		Gizmos.DrawSphere(transform.position, radius);
//		if (waypointTarget != null)
//			Gizmos.DrawLine(transform.position, waypointTarget.transform.position);
//	}
//	
//	void OnDrawGizmosSelected () { //Draws a line to next waypoint and a sphere with alternate color when selected.
//		Gizmos.color = new Color(1.0f, 0.0f, 0.0f, 0.5f);
//		Gizmos.DrawSphere(transform.position, radius);
//		if (waypointTarget != null)
//			Gizmos.DrawLine(transform.position, waypointTarget.transform.position);
//	}	
}