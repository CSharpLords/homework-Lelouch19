using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	public Transform cub;
	void Update () 
	{
		Vector3 direction  = cub.position - transform.position;
		direction.Normalize ();
		transform.Translate(direction * 5 * Time.deltaTime);
	}
}
