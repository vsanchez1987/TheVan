using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {

	public float Health;

	void Start () {
	
	}

	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "bullet") {
			ApplyDamage (10);
			}
	}

	void ApplyDamage (float damage)
	{
		Health = Health - damage;
		print (Health);
		if (Health <= 0.0)
			Destroy(this.gameObject);
	}
}
