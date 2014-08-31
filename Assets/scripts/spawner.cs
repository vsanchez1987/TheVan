using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour 
	{
		public GameObject spawnedObject;
		public float numofwaves=1f;

		void Start ()
		{
			StartCoroutine(spawn());
		}


		IEnumerator spawn()
		{
		if(numofwaves==1){
			for (int i = 0; i < 3; i++)
				{
				Instantiate(spawnedObject, this.transform.position, this.transform.rotation);
				yield return new WaitForSeconds(1);
				}
			numofwaves++;
			}
		if(numofwaves==2){
			for (int i = 0; i < 3; i++)
			{
				Instantiate(spawnedObject, this.transform.position, this.transform.rotation);
				yield return new WaitForSeconds(3);
			}
			numofwaves++;
		}
		}


	}

