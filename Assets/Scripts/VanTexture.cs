using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VanTexture : MonoBehaviour 
{
	public string wolf = "file://D:/GitHub/TheVan/Assets/Textures/wolf.jpg";
	public string cartman = "file://D:/GitHub/TheVan/Assets/Textures/cartman.png";

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
		renderer.material.mainTexture = www.texture;

		if(clicks == 1) {
			clicks = -1; // wtf
		}
	}
}