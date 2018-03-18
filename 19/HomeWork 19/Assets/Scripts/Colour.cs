using System.Collections;
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
		int r = seconds % 1;
		if (r == 0) 
		{
			a = a + 0.01F;
			colour.material.color = new Color (1, a, a);
			print (a);
			if (a >= 1) 
			{
				a = 0;
			}
		}

	}
}
