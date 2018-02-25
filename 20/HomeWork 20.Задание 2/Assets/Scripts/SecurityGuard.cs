using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityGuard : MonoBehaviour 
{
	public Transform[] objects; 

	void Start () 
	{
		
	}

	void Update () 
	{
		for (int a = 0; a < objects.Length; a++) 
		{
			Vector3 direction  = objects[a].position - transform.position;
			direction.Normalize ();
			transform.Translate (direction * 5 * Time.deltaTime);
		}
	}
}
