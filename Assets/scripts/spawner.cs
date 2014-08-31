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
				GameObject clone =(GameObject)Instantiate(spawnedObject, this.transform.position, this.transform.rotation);
				ZombieAIScript Clone = clone.GetComponent<ZombieAIScript>();
				GameObject thePlayer = GameObject.FindGameObjectWithTag("Player");
				charater_movement Charater_movement = thePlayer.GetComponent<charater_movement>();
				Clone.target = Charater_movement.playertransform;
				yield return new WaitForSeconds(3);
				}
			numofwaves++;
			}
		if(numofwaves==2){
			for (int i = 0; i < 3; i++)
			{
				GameObject clone =(GameObject)Instantiate(spawnedObject, this.transform.position, this.transform.rotation);
				ZombieAIScript Clone = clone.GetComponent<ZombieAIScript>();
				GameObject thePlayer = GameObject.FindGameObjectWithTag("Player");
				charater_movement Charater_movement = thePlayer.GetComponent<charater_movement>();
				Clone.target = Charater_movement.playertransform;
				yield return new WaitForSeconds(3);
			}
			numofwaves++;
		}
		}


	}

