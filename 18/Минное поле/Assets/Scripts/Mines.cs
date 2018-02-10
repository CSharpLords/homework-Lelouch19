using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mines : MonoBehaviour 
{
	public Transform player;
	public Transform enemy;
	public Transform secret;
	float time = 0;
	float x = -12.19f;
	float y = 0.91f;
	float z = -0.93f;

	void Start () 
	{
		print ("Бегите!");
	}
	void Update () 
	{
		float dist = Vector3.Distance(enemy.position, player.position);
		float WinDist = Vector3.Distance(secret.position, player.position);
		time = time + Time.deltaTime;
		int seconds = (int)time;
		print (seconds);

		if(seconds > 15)
		{
			transform.position = new Vector3 (z, x, y);
			print ("Заново!");
			seconds = 0;
		}
		if (dist < 2) 
		{
			transform.position = new Vector3 (z ,x, y);
			print ("Заново!");
			seconds = 0;
		}
		if(WinDist < 2)
		{
			print ("Победа!Победа вместо обеда!");
		}
	}
}
