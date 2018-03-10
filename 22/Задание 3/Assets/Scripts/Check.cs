using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour 
{
	public Transform[] cubs;

	float max = 0;
	int c;
	void Start()
	{
		for (int x = 0; x < cubs.Length; x++) //Ищем самый дальний куб
		{ 
			float dist = Vector3.Distance (cubs [x].position, transform.position);
			if (dist > max) 
			{
				c = x;
				max = dist;
			}
		}
	}
	void Update() //Ждём пока дальний куб долетит
	{
		float dist = Vector3.Distance (cubs[c].position, transform.position);
		if (dist < 2) 
		{
			print ("Все на месте!");
		}
	}
}
