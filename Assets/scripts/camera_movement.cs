using UnityEngine;
using System.Collections;

public class camera_movement : MonoBehaviour {
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
		Screen.showCursor = false;
		Screen.lockCursor = true;
	}
	
	void Update () {

		
				movement = Vector3.zero;
		
				if (rotationY < minimumY) {
						rotationY = 0;
				}
				if (rotationY > maximumY) {
						rotationY = 0;
				}
		
				if (axes == RotationAxes.MouseXAndY) {
						transform.Rotate (Input.GetAxis ("Mouse Y") * -sensitivityY, Input.GetAxis ("Mouse X") * sensitivityX, 0);
						rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;
				} else if (axes == RotationAxes.MouseX) {
						transform.Rotate (0, Input.GetAxis ("Mouse X") * sensitivityX, 0);
				} else {
						transform.Rotate (Input.GetAxis ("Mouse Y") * -sensitivityY, 0, 0);
						rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;
				}
		}

}
