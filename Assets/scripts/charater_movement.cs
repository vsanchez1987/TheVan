using UnityEngine;
using System.Collections;

public class charater_movement : MonoBehaviour {

	public float speed = 1.0f;

	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;
	
	public float minimumX = -360F;
	public float maximumX = 360F;
	
	public float minimumY = -60F;
	public float maximumY = 60F;

	private Vector3 movement;
	
	float rotationY = 0F;

	void Start () {
	/*
		if (rigidbody)
			rigidbody.freezeRotation = true;*/
	}

	void Update () {

		movement = Vector3.zero;

		if (axes == RotationAxes.MouseXAndY)
		{
			float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
		}
		else if (axes == RotationAxes.MouseX)
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
		}


		if (Input.GetKey ("a")) { 
			//this.rigidbody.velocity = new Vector3(-speed,0.0f,0.0f);
			movement.x -= 1f;

		}


		if (Input.GetKey ("d")) {
			//this.rigidbody.velocity = new Vector3(speed,0.0f,0.0f);
			movement.x += 1f;
		}
		
		if (Input.GetKey ("w")) {		
			//this.rigidbody.velocity = Vector3.forward * speed;	
			movement.z += 1f;
		}

		if (Input.GetKey ("s")) {		
			//this.rigidbody.velocity = new Vector3(0.0f,0.0f,-speed);
			movement.z -= 1f;
		}

		/*
		if (Input.GetKey ("a") && Input.GetKey ("w")) {		
			this.rigidbody.velocity = new Vector3(-speed,0.0f,speed);
		}

		if (Input.GetKey ("a") && Input.GetKey ("s")) {		
			this.rigidbody.velocity = new Vector3(-speed, 0.0f, -speed);
		}

		if (Input.GetKey ("d") && Input.GetKey ("w")) {
			
			this.rigidbody.velocity = new Vector3(speed, 0.0f, speed);
		}

		if (Input.GetKey ("d") && Input.GetKey ("s")) {	
			this.rigidbody.velocity = new Vector3(speed, 0.0f, -speed);
		}
		
		
		if (Input.GetKeyUp ("a") || Input.GetKeyUp ("s") || Input.GetKeyUp ("w") || Input.GetKeyUp ("d")) {		
			this.rigidbody.velocity = new Vector3(0.0f,0.0f,0.0f);
		}
*/
		transform.Translate( movement * Time.deltaTime );
	}
}
