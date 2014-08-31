//using UnityEngine;
//using System.Collections;
//
//public class moveRoad : MonoBehaviour {
//	
//	public float speed;
//	public int curr;
//
//	// add the roads to the array to be checked
//	public GameObject[] roads;
//
//
//	// Original Position of the Road
//	private float originalX = 34.7832f;
//	private float originalY = 1f;
//	private float originalZ = 18.19556f;
//
//	// The positon of the next roads
//
//
//
//
//	// End of positions
//
//
//	// Use this for initialization
//	void Start () {
//
//
//		roads = GameObject.FindGameObjectsWithTag("Road");
//
//		for (int i  = 0; i < roads.Length; i++) 
//		{
//			Debug.Log("the roads are " + i + roads[i].name);
//		}
//	}
//
//	void Update()
//	{
//
//	}
//
//
//}

using UnityEngine;
using System.Collections;

public class moveRoad : MonoBehaviour {
	
	
	
	// making the game objects
	public GameObject Road_1;
	public GameObject Road_2;
	public GameObject Road_3;
	public GameObject Road_4;
	public GameObject Road_5;
	
	
	//speed of objects
	private float speed = 0.5f;
	
	
	private int points =0;
	
	//original postitions
	public float original_x = 60.0f;
	public float original_y = 55.0f;
	public float original_z = 0.0f;
	
	
	// variables / positions of each Road
	
	public float x_1 = -60.0f;
	public float x_2 = -60.0f;
	public float x_3 = -60.0f;
	public float x_4 = -60.0f;
	public float x_5 = -60.0f;
	
	public float y_1 = 67.0f;
	public float y_2 = 70.0f;
	public float y_3 = 73.0f;
	public float y_4 = 76.0f;
	public float y_5 = 79.0f;
	
	public float z_1 = 0.0f;
	public float z_2 = 0.0f;
	public float z_3 = 0.0f;
	public float z_4 = 0.0f;
	public float z_5 = 0.0f;
	
	
	
	//movement switches
	
	private bool move_1 = false;
	private bool move_2 = false;
	private bool move_3 = false;
	private bool move_4 = false;
	private bool move_5 = false;
	
	
	
	
	int random_Road()
	{
		int pick = Random.Range(1,6);
		
		
		
		
		return pick;
	}
	
	////////////////////////////////////////////////////////////////////////
	int random_start()
	{
		int first = Random.Range(1,6);	
		int second = Random.Range(1,6);
		int third = Random.Range(1,6);
		
		
		while ( second == first)
		{
			second = Random.Range(1,6);
		}
		
		while ( third == first || third == second)
		{
			third = Random.Range(1,6);
		}

		
		///////////////////////////////
		
		if (first == 1)
		{
			x_1 = 0.0f;
			y_1 = 0.0f;
			z_1 = 0.0f;
			
			move_1 = true;
		}
		
		if (first == 2)
		{
			x_2 = 0.0f;
			y_2 = 0.0f;
			z_2 = 0.0f;
			
			move_2 = true;
		}
		
		if (first == 3)
		{
			x_3 = 0.0f;
			y_3 = 0.0f;
			z_3 = 0.0f;
			
			move_3 = true;
		}
		
		if (first == 4)
		{
			x_4 = 0.0f;
			y_4 = 0.0f;
			z_4 = 0.0f;
			
			move_4 = true;
		}
		
		if (first == 5)
		{
			x_5 = 0.0f;
			y_5 = 0.0f;
			z_5 = 0.0f;
			
			move_5 = true;
		}
		////////////////////////////////////
		
		if (second == 1)
		{
			x_1 = 0.0f;
			y_1 = 0.0f;
			z_1 = 280.0f;
			
			move_1 = true;
		}
		
		if (second == 2)
		{
			x_2 = 0.0f;
			y_2 = 0.0f;
			z_2 = 280.0f;
			
			move_2 = true;
		}
		
		if (second == 3)
		{
			x_3 = 0.0f;
			y_3 = 0.0f;
			z_3 = 280.0f;
			
			move_3 = true;
		}
		
		if (second == 4)
		{
			x_4 = 0.0f;
			y_4 = 0.0f;
			z_4 = 280.0f;
			
			move_4 = true;
			
		}
		
		if (second == 5)
		{
			x_5 = 0.0f;
			y_5 = 0.0f;
			z_5 = 280.0f;
			
			move_5 = true;
			
		}
		
		////////////////////////////////////
		
		if (third == 1)
		{
			x_1 = 0.0f;
			y_1 = 0.0f;
			z_1 = 560.0f;
			
			move_1 = true;
		}
		
		if (third == 2)
		{
			x_2 = 0.0f;
			y_2 = 0.0f;
			z_2 = 560.0f;
			
			move_2 = true;
		}
		
		if (third == 3)
		{
			x_3 = 0.0f;
			y_3 = 0.0f;
			z_3 = 560.0f;
			
			move_3 = true;
			
		}
		
		if (third == 4)
		{
			x_4 = 0.0f;
			y_4 = 0.0f;
			z_4 = 560.0f;
			
			move_4 = true;
			
		}
		
		if (third == 5)
		{
			x_5 = 0.0f;
			y_5 = 0.0f;
			z_5 = 560.0f;
			
			move_5 = true;
		}
		
		
		
		return 1;
	}
	
	////////////////////////////////////////////////////////////////////////
	
	
	
	////////////////////////////////////////////////////////////////////////
	
	// Use this for initialization
	void Start () {
		
		
		random_start();
		
		
		//finding the game objects
		Road_1 = GameObject.Find("Road_1");
		Road_2 = GameObject.Find("Road_2");
		Road_3 = GameObject.Find("Road_3");
		Road_4 = GameObject.Find("Road_4");
		Road_5 = GameObject.Find("Road_5");
		
		
		Road_1.transform.position = new Vector3(x_1,y_1,z_1);
		Road_2.transform.position = new Vector3(x_2,y_2,z_2);
		Road_3.transform.position = new Vector3(x_3,y_3,z_3);
		Road_4.transform.position = new Vector3(x_4,y_4,z_4);
		Road_5.transform.position = new Vector3(x_5,y_5,z_5);
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		////////////////////////////////////////////////////////////////////////
		if(move_1 == true)
		{
			z_1 -= speed;
		}
		
		if(z_1 <= -280)
		{
			points += 1;
			
			move_1 = false; // reset values
			x_1 = original_x;
			y_1 = original_y;
			z_1 = original_z;
			
			int next = Random.Range(1,6);
			
			while (true) //now we check for the next piece 
			{
				
				////////////////////////////////////
				if(next == 1)
				{
					if(move_1 == false)
					{
						x_1= 0.0f;
						y_1= 0.0f;
						z_1= 560.0f;
						move_1 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 2)
				{
					if(move_2 == false)
					{
						x_2= 0.0f;
						y_2= 0.0f;
						z_2= 560.0f;
						move_2 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 3)
				{
					if(move_3 == false)
					{
						x_3= 0.0f;
						y_3= 0.0f;
						z_3= 560.0f;
						move_3 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 4)
				{
					if(move_4 == false)
					{
						x_4= 0.0f;
						y_4= 0.0f;
						z_4= 560.0f;
						move_4 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 5)
				{
					if(move_5 == false)
					{
						x_5= 0.0f;
						y_5= 0.0f;
						z_5= 560.0f;
						move_5 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				
			}
		}
		////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////
		
		if(move_2 == true)
		{
			z_2 -= speed;
		}
		
		if(z_2 <= -280)
		{
			points += 1;
			
			move_2 = false;
			x_2 = original_x;
			y_2 = original_y;
			z_2 = original_z;
			
			int next = Random.Range(1,6);
			
			while (true) //now we check for the next piece 
			{
				
				////////////////////////////////////
				if(next == 1)
				{
					if(move_1 == false)
					{
						x_1= 0.0f;
						y_1= 0.0f;
						z_1= 560.0f;
						move_1 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 2)
				{
					if(move_2 == false)
					{
						x_2= 0.0f;
						y_2= 0.0f;
						z_2= 560.0f;
						move_2 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 3)
				{
					if(move_3 == false)
					{
						x_3= 0.0f;
						y_3= 0.0f;
						z_3= 560.0f;
						move_3 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 4)
				{
					if(move_4 == false)
					{
						x_4= 0.0f;
						y_4= 0.0f;
						z_4= 560.0f;
						move_4 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 5)
				{
					if(move_5 == false)
					{
						x_5= 0.0f;
						y_5= 0.0f;
						z_5= 560.0f;
						move_5 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				
			}
			
			
		}
		////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////
		if(move_3 == true)
		{
			z_3 -= speed;
		}
		
		if(z_3 <= -280)
		{
			points += 1;
			
			move_3 = false;
			x_3 = original_x;
			y_3 = original_y;
			z_3 = original_z;
			
			int next = Random.Range(1,6);
			
			while (true) //now we check for the next piece 
			{
				
				////////////////////////////////////
				if(next == 1)
				{
					if(move_1 == false)
					{
						x_1= 0.0f;
						y_1= 0.0f;
						z_1= 560.0f;
						move_1 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 2)
				{
					if(move_2 == false)
					{
						x_2= 0.0f;
						y_2= 0.0f;
						z_2= 560.0f;
						move_2 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 3)
				{
					if(move_3 == false)
					{
						x_3= 0.0f;
						y_3= 0.0f;
						z_3= 560.0f;
						move_3 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 4)
				{
					if(move_4 == false)
					{
						x_4= 0.0f;
						y_4= 0.0f;
						z_4= 560.0f;
						move_4 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 5)
				{
					if(move_5 == false)
					{
						x_5= 0.0f;
						y_5= 0.0f;
						z_5= 560.0f;
						move_5 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				
			}
		}
		////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////
		if(move_4 == true)
		{
			z_4 -= speed;
		}
		
		if(z_4 <= -280)
		{
			points += 1;
			
			move_4 = false;
			x_4 = original_x;
			y_4 = original_y;
			z_4 = original_z;
			
			int next = Random.Range(1,6);
			
			while (true) //now we check for the next piece 
			{
				
				////////////////////////////////////
				if(next == 1)
				{
					if(move_1 == false)
					{
						x_1= 0.0f;
						y_1= 0.0f;
						z_1= 560.0f;
						move_1 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 2)
				{
					if(move_2 == false)
					{
						x_2= 0.0f;
						y_2= 0.0f;
						z_2= 560.0f;
						move_2 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 3)
				{
					if(move_3 == false)
					{
						x_3= 0.0f;
						y_3= 0.0f;
						z_3= 560.0f;
						move_3 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 4)
				{
					if(move_4 == false)
					{
						x_4= 0.0f;
						y_4= 0.0f;
						z_4= 560.0f;
						move_4 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 5)
				{
					if(move_5 == false)
					{
						x_5= 0.0f;
						y_5= 0.0f;
						z_5= 560.0f;
						move_5 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				
			}
		}
		////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////
		
		if(move_5 == true)
		{
			z_5 -= speed;
		}
		
		if(z_5 <= -280)
		{
			points += 1;
			
			move_5 = false;
			x_5 = original_x;
			y_5 = original_y;
			z_5 = original_z;
			
			int next = Random.Range(1,6);
			
			while (true) //now we check for the next piece 
			{
				
				////////////////////////////////////
				if(next == 1)
				{
					if(move_1 == false)
					{
						x_1= 0.0f;
						y_1= 0.0f;
						z_1= 560.0f;
						move_1 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 2)
				{
					if(move_2 == false)
					{
						x_2= 0.0f;
						y_2= 0.0f;
						z_2= 560.0f;
						move_2 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 3)
				{
					if(move_3 == false)
					{
						x_3= 0.0f;
						y_3= 0.0f;
						z_3= 560.0f;
						move_3 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 4)
				{
					if(move_4 == false)
					{
						x_4= 0.0f;
						y_4= 0.0f;
						z_4= 560.0f;
						move_4 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				if(next == 5)
				{
					if(move_5 == false)
					{
						x_5= 0.0f;
						y_5= 0.0f;
						z_5= 560.0f;
						move_5 = true;
						
						break;
					}
					
					else
					{
						next = Random.Range(1,6);
					}
					
				}
				////////////////////////////////////
				
				
			}
		}
		
		
		////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////
		Road_1.transform.position = new Vector3(x_1,y_1,z_1);
		Road_2.transform.position = new Vector3(x_2,y_2,z_2);
		Road_3.transform.position = new Vector3(x_3,y_3,z_3);
		Road_4.transform.position = new Vector3(x_4,y_4,z_4);
		Road_5.transform.position = new Vector3(x_5,y_5,z_5);
		
		//Debug.Log(points);
	}
	
	

}

