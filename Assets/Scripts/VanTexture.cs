using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VanTexture : MonoBehaviour 
{
	public string wolf = "file://C:/Users/Dori/Desktop/TheVan_copy/Assets/Textures/wolf.jpg";
	public string cartman = "file://C:/Users/Dori/Desktop/TheVan_copy/Assets/Textures/cartman.png";

	private int clicks = 0;

	public List<string> textures = new List<string>();

	void Start () 
	{
		textures.Add (wolf);
		textures.Add (cartman);
	}

	public void OnClick()
	{
		SwapTexture ();
		clicks = clicks + 1;
	}

	void SwapTexture()
	{
		WWW www = new WWW(textures[clicks]);
		gameObject.transform.FindChild("Mesh").renderer.material.mainTexture = www.texture;

		if(clicks == 1) {
			clicks = -1; // wtf
		}
	}
}