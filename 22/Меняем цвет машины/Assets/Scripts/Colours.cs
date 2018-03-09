using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colours : MonoBehaviour {

	public Button GreenButton;
	public Button BlueButton;
	public Button RedButton;
	public Renderer rend;

	void Start () 
	{
		GreenButton.onClick.AddListener(Green);
		BlueButton.onClick.AddListener(Blue);
		RedButton.onClick.AddListener(Red);
	}
	void Red () 
	{
		rend.material.color = Color.red;
	}
	void Green () 
	{
		rend.material.color = Color.green;
	}
	void Blue () 
	{
		rend.material.color = Color.blue;
	}
}
