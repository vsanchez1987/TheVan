using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class VanCustomization : MonoBehaviour 
{
	public GameObject item;
	public Transform target;
	public bool isOn = false;
	public Camera vanCam;
	public Camera mainCamera;
	
	private GameObject van;
	private CharacterInventory playerInventory;

	public List<string> copyInventory = new List<string>();

	void Awake()
	{
		van = GameObject.FindGameObjectWithTag ("Van");
		playerInventory = GameObject.FindWithTag ("Player").GetComponent<CharacterInventory> ();
		DontDestroyOnLoad (van);

		foreach (var str in playerInventory.inventory) {
			copyInventory.Add (str.name);
		}
	}
	
	public void OnClick()
	{
		isOn = true;
		item = GameObject.Find ("Chainsaw");

		OnTarget ();
	}

	void OnTarget()
	{
		target = GameObject.Find (gameObject.name + "_gm").transform;

		if (isOn) {
			item.transform.position = target.transform.position;
			item.renderer.enabled = true;
		}
		isOn = false;
	}

	public void OnExit()
	{
		vanCam.enabled = false;
		mainCamera.enabled = true;
	}
}