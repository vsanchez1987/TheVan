using UnityEngine;
using System.Collections;

public class MoveVan : MonoBehaviour {
	public GameObject van;
	public State currentState;
	//public GameObject[] wayPoints;
	public GameObject wayPointRight, wayPointCenter, wayPointLeft;
	public float speed = 10;
	public int zombieSize;
	private RaycastHit hit;

	public Rigidbody obstical;

	public Transform target;



	public enum State{
		swerve,
		stop,
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
	
	// Update is called once per frame
	void Update () {

		//transform.Translate (Vector3.forward * speed * Time.deltaTime);

		if(Physics.Raycast(transform.position, Vector3.up, out hit, 10.0f))
		{
			obstical = hit.rigidbody;

			if(rigidbody.CompareTag("obstical"))
			
				if (currentState == State.swerve) 
				{
//					if(target != null)
//					{
//					//	wayPointRight.transform.position = target.transform.position - transform.position;
//					//	Quaternion rotation = Quaternion.LookRotation(wayPointRight.transform);
//
//						transform.rotation = Quaternion.Slerp(transform.rotation,rotation, Time.deltaTime);
//						transform.Translate(0,0,3 * Time.deltaTime);
//					}


				}

//			if(rigidbody.CompareTag("zombie"))
//				if (currentState == State.slow) 
//			{
//				Vector3 direction = target.transform.position - transform.position;
//				direction.y = 0.0f;
//				Quaternion rotation = Quaternion.LookRotation(direction);
//				
//				transform.rotation = Quaternion.Slerp(transform.rotation,rotation, Time.deltaTime);
//				transform.Translate(0,0,3 * Time.deltaTime);
//
//				speed -= 1;
//				
//				
//			}
		}




	}
}
