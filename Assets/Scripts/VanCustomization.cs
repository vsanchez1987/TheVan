using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class VanCustomization : MonoBehaviour 
{
	public GameObject item;
	public Transform target;
	public bool isOn = false;

	public void OnClick()
	{
		isOn = true;
		item = GameObject.Find ("Chainsaw");
		Debug.Log (item);
	}

	void Update()
	{
		target = GameObject.Find (gameObject.name + "_gm").transform;

		if (isOn) {
			item.transform.position = target.transform.position;
			item.renderer.enabled = true;
		}
		isOn = false;
	}
}