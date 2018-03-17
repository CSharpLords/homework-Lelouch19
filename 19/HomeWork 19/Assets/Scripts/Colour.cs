using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour {
	
	Renderer rend;
	float time = 0;

	void Start () 
	{
		rend = GetComponent<Renderer>();
	}
		
	void Update () 
	{

		if (time > 5)
		{
			time = 0;
			time = time + Time.deltaTime;
			rend.material.color = Color.Lerp(Color.white, Color.red, time / 5);
		}
		time = time + Time.deltaTime;
		rend.material.color = Color.Lerp(Color.red, Color.white, time / 5);
	}

}
