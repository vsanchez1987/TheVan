﻿using UnityEngine;
using System.Collections;

public class charater_movement : MonoBehaviour {

	public Transform playertransform;

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
	//Vector3 position;

	public GameObject bullet_prefab;
	public float distance = 10.0f;
	
	float rotationY = 0F;

	void Start () {
		playertransform = transform;
	}

	void Update () {


		movement = Vector3.zero;

		if (rotationY < minimumY) {rotationY=0;}
		if (rotationY > maximumY) {rotationY=0;}

		if (axes == RotationAxes.MouseXAndY)
		{
			transform.Rotate(  Input.GetAxis("Mouse Y") * -sensitivityY, Input.GetAxis("Mouse X") * sensitivityX,0);
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
		}
		else if (axes == RotationAxes.MouseX)
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
		}
		else
		{
			transform.Rotate( Input.GetAxis("Mouse Y") * -sensitivityY,0,0);
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
		}


		if (Input.GetKey ("a")) { 
			movement.x -= 1f;

		}

		if (Input.GetKey ("d")) {
			movement.x += 1f;
		}

		if (Input.GetKey ("w")) {		
			movement.z += 1f;
		}

		if (Input.GetKey ("s")) {		
			movement.z -= 1f;
		}

		/*if (Input.GetKeyUp ("a") || Input.GetKeyUp ("s") || Input.GetKeyUp ("w") || Input.GetKeyUp ("d")) {
			
			this.rigidbody.velocity = new Vector3(0.0f,-0.17342f,0.0f);
			
		}*/

		transform.Translate( movement * Time.deltaTime );
	}
}

