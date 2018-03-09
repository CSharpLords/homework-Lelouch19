using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	public Transform[] cubs;
	float a = 0;

	void Update () 
	{
		for(int x = 0; x < cubs.Length; x ++) //Передвижение объектов
		{
			Vector3 direction  = transform.position - cubs[x].position;
			direction.Normalize ();
			cubs[x].Translate(direction * 5 * Time.deltaTime);
		}

		for(int y = 0; y < cubs.Length; y ++) //Проверка расстояния
		{ 
			float dist = Vector3.Distance(cubs[y].position, transform.position);
			if (dist < 2) 
			{
				a = 1;
			} 
			else 
			{
				a = 0;
			}
		}

		if (a == 1) 
		{
			print ("Все на месте!");
		}
	}
}
