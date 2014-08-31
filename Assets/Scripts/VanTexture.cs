using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VanTexture : MonoBehaviour 
{
<<<<<<< HEAD
	public string wolf = "file://C:/Users/Dori/Desktop/TheVan_copy/Assets/Textures/wolf.jpg";
	public string cartman = "file://C:/Users/Dori/Desktop/TheVan_copy/Assets/Textures/cartman.png";
=======
	public string wolf = "file://D:/GitHub/TheVan/Assets/Textures/wolf.jpg";
	public string cartman = "file://D:/GitHub/TheVan/Assets/Textures/cartman.png";
>>>>>>> origin/master

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
<<<<<<< HEAD
		gameObject.transform.FindChild("Mesh").renderer.material.mainTexture = www.texture;
=======
		renderer.material.mainTexture = www.texture;
>>>>>>> origin/master

		if(clicks == 1) {
			clicks = -1; // wtf
		}
	}
}