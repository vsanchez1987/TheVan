using UnityEngine;
using System.Collections;

public class itemPickUp : MonoBehaviour {

	public GameObject item;
	public GameObject van;
	private Inventory inventory;


	// Use this for initialization
	void Start () {
	
		item = GameObject.FindGameObjectWithTag("PickUp");
		//van = GameObject.FindGameObjectWithTag("van");

		print("the game has started");

	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("A collision has happened");

		if(other.gameObject.tag == "van")
		{
			Destroy(this.gameObject);
			inventory = (Inventory)van.GetComponent(typeof(Inventory));
			inventory.numOfItem += 1;

			Debug.Log("this Item has been picked up" + inventory.numOfItem);
		}
	}

}
