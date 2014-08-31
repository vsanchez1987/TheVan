using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterInventory: MonoBehaviour 
{	
	public GameObject item;
	public bool withinRange;
	public List<GameObject> inventory = new List<GameObject>();

	void Start()
	{
		item = GameObject.FindWithTag ("Item");
	}

	void Update()
	{
		if (withinRange) {
			if (Input.GetKeyDown (KeyCode.E)) {
				inventory.Add(item);
				item.gameObject.SetActive(false);
			}
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject == item) {
			withinRange = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == item) {
			withinRange = false;
		}
	}
}
