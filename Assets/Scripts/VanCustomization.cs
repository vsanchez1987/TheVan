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
	public int index;
	public Text text;

	private CharacterInventory player;

	void Start()
	{
		index = 0;

		player = GameObject.FindWithTag ("Player").GetComponent<CharacterInventory>();
		text = GameObject.Find("Canvas").transform.FindChild("Text").GetComponent<Text> ();
	}
	
	public void OnClick(GameObject _sender)
	{
		isOn = true;
		OnTarget (_sender);
	}
	
	void Update()
	{
		if(index <= player.inventory.Capacity) {
			if(Input.GetKeyDown (KeyCode.RightArrow)) {
				index++;
				item = player.inventory[index];
			}
			if(Input.GetKeyDown (KeyCode.LeftArrow)) {
				index--;
				item = player.inventory[index];
			}
		}

		text.text = "Current Item: " + item.ToString();
	}

	void OnTarget(GameObject _sender)
	{
		if (isOn) {
			target = GameObject.Find (_sender.name + "_gm").transform;
			item = GameObject.Find(item.name + "_van");
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