using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterInventory: MonoBehaviour 
{	
	public GameObject item = null;
	public bool withinRange;
	public List<GameObject> existing = new List<GameObject> ();
	public List<GameObject> inventory = new List<GameObject>();

	void Start()
	{
		GameObject[] items = GameObject.FindGameObjectsWithTag ("Item");

		foreach (var i in items) {
			existing.Add(i);
			Debug.Log ("Added: " + i);
		}

		withinRange = false;
		item = null;
	}

	void Update()
	{
		if (withinRange && (existing.Contains(item))) {
			if (Input.GetKeyDown (KeyCode.E)) {
				inventory.Add(item);

				if(item != null) {
					item.gameObject.SetActive(false);
				}

				withinRange = false;
			}
		}
		item = null;
	}

	void OnTriggerStay(Collider other)
	{
		if (existing.Contains(other.gameObject)) {
			withinRange = true;
			item = other.gameObject;
		}
	} 

	void OnTriggerExit(Collider other)
	{
		if(existing.Contains(other.gameObject)) {
			withinRange = false;
			item = null;
		}
	}

}
