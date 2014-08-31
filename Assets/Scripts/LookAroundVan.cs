using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LookAroundVan : MonoBehaviour 
{
	public float currentValue;
	public Transform target;
	public Slider slider;

	void Start()
	{
		target = GameObject.Find ("Van").transform;
		slider = GameObject.Find ("Slider").GetComponent<Slider> ();
	}

	void Update()
	{
		currentValue = slider.value;
	}

	public void OnClick()
	{
		RotateView ();
		currentValue = 0;
	}

	void RotateView()
	{
		if (slider != null) {
			if(slider.value > currentValue) {
				transform.RotateAround (target.position, Vector3.up, 360 * Time.deltaTime);
			}
			if(slider.value < currentValue) {
				transform.RotateAround (target.position, -Vector3.up, 360 * Time.deltaTime);
			}
		}
	}
}
