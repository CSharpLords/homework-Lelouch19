using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Transform player;
	public Transform SecretObject;
	float time = 0;
	void start()
	{
		transform.position = Vector3.zero;
	}
	void Update () 
	{
		float dist = Vector3.Distance(SecretObject.position, player.position);
		time = time + Time.deltaTime;
		int seconds = (int)time;
		print (seconds);	
		if (seconds > 15) 
		{
			transform.position = new Vector3(0, 1, 0);
			print ("Заново!");
			seconds = 0;
		}
		if(dist < 2)
		{
			print ("Победа!Победа вместо обеда!");
		}
		
	}
}
