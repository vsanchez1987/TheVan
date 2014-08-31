using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public GameObject bullet_prefab;
	public float distance = 10.0f;
	//public float speed = 1000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
			Vector3 position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			position = Camera.main.ScreenToWorldPoint (position);
			GameObject go =(GameObject)Instantiate (bullet_prefab, transform.position, Quaternion.identity);
			go.transform.LookAt (position);
			Debug.Log (position);
			go.rigidbody.AddForce (transform.forward * 1500);
		}
	}
}
