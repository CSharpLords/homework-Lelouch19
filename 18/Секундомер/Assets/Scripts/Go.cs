using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour {
	
	float time = 0;
	void Start()
	{
		print ("Начинаем!");
	}
	void Update () 
	{
		transform.Rotate(new Vector3(0, 6, 0) * Time.deltaTime);

		time = time + Time.deltaTime;
		float seconds = (int)time;
		float r = seconds % 10;
		if (r == 0) 
		{
			print ("Прошло - " + seconds + " секунд.");
		}

	}
}
