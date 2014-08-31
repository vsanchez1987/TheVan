using UnityEngine;
using System.Collections;

public class movePlatform : MonoBehaviour {
	
	public float Speed = 1.0F;
	public float stopper = 50.0F;
	public float header = 0.0F;

	void Update () 
	{
		transform.position += new Vector3(Time.deltaTime * Speed, 0, 0); // apply movement
		
		if ((transform.position.x > stopper)) // if we are past either of these then
		{
			//transform.position.x= stopper;
			transform.position -= new Vector3(Time.deltaTime * Speed, 0, 0); // undo the move
			Speed=-Speed; // go the other way by negating speed
		}
		if ((transform.position.x < header)) 
		{
			//transform.position.x= header;
			transform.position -= new Vector3(Time.deltaTime * Speed, 0, 0); // undo the move
			Speed=-Speed; // go the other way by negating speed
		}

	}

}




