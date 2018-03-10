using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	public Transform[] cubs;
	void Update () 
	{
		for(int x = 0; x < cubs.Length; x ++) //Передвижение объектов
		{
			Vector3 direction  = transform.position - cubs[x].position;
			direction.Normalize ();
			cubs[x].Translate(direction * 5 * Time.deltaTime);
		}
			
	}
}
