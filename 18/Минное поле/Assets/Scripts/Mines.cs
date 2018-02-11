using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mines : MonoBehaviour 
{
	public Transform enemy;
	public Transform player;
	float time = 0;
	void Start () 
	{
		print ("Бегите!");
	}
	void Update () 
	{
		float dist = Vector3.Distance(player.position,enemy.position);
		if (dist < 2) 
		{
			transform.position = new Vector3 (0, 1, 0);
			print ("Заново!");
		}

	}
}
