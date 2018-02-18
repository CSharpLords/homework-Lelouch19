﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour {
	
	Renderer colour;
	float a = 0;
	float time = 0;

	void Start () 
	{
		colour = GetComponent<Renderer>();
		//colour.material.color =  Color.red;
	}

	void Update () 
	{
		time = time + Time.deltaTime;
		int seconds = (int)time;
		int r = seconds % 2;
		if (r == 0) 
		{
			colour.material.color = new Color (255, a + 1, a + 1);
			if (a == 255) 
			{
				a = 0;
			}
		}

	}

}
