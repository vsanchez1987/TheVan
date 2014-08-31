using UnityEngine;
using System.Collections;

public class DemoPlayerControls : MonoBehaviour 
{
	public float speed = 5.0f;
	public bool nearBlueprints = false;
	public Camera vanCam;
	public Camera mainCamera;
	
	private GameObject van;
	private CharacterInventory playerInventory;

	void Start()
	{
		vanCam.enabled = false;
		mainCamera.enabled = true;
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(-Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(-Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.E) && nearBlueprints) {
			vanCam.enabled = true;
			mainCamera.enabled = false;
		}
	}

	void OnTriggerStay (Collider other) 
	{
		if (other.gameObject == GameObject.Find ("Blueprints")) {
			nearBlueprints = true;
		}
	}

	void OnTriggerExit (Collider other) 
	{
		if (other.gameObject == GameObject.Find ("Blueprints")) {
			nearBlueprints = false;
		}
	}
}
