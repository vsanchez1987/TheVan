using UnityEngine;
using System.Collections;

public class ZombieAIScript : MonoBehaviour 
{
	public Transform target;
	public State currentState;
	public float attackRange = 1.0f;
	public float speed = 5.0f;

	private SphereCollider chaseRadius;

	public enum State {
		Attack,
		Idle
	};

	void Start()
	{
		chaseRadius = gameObject.GetComponent<SphereCollider> ();
		chaseRadius.radius = 5.0f;
	}

	void Update()
	{
		if(currentState == State.Attack) {
			Vector3 direction = target.transform.position - transform.position;
			direction.y = 0.0f;

			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.LookRotation(-direction),
			                                      Time.deltaTime);

			if(direction.magnitude < attackRange) {
				Vector3 moveVector = direction.normalized * speed * Time.deltaTime;
				transform.position += moveVector;
			}
		}
	}

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject == GameObject.Find ("Player")) {
			target = other.gameObject.transform; 
			currentState = State.Attack;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if(other.gameObject == GameObject.Find ("Player")) {
			target = null;
			currentState = State.Idle;
		}
	}
}