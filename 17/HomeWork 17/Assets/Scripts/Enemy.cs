using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	public Transform player;
	float time = 20;
	void Start () 
	{
		print ("Найди врага!");
	}

	void Update () 
	{
		time = time - Time.deltaTime;
		float seconds = (int)time;
		print (seconds);
		float dist = Vector3.Distance(player.position,transform.position);
		if (dist <= 5) 
		{
			print ("Вы нашли его!");
		}
		if(seconds == 0)
		{
			print ("Время вышло!");
			time = 20;
		}
	}
}
