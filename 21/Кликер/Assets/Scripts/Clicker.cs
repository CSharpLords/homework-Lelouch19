using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clicker : MonoBehaviour {
	
	public Button clickButton;
	public Text scoreField;
	public Text timeField;
	public float time = 30;
	public int click = 0;

	void Start () 
	{
		clickButton.onClick.AddListener(Score);
	}
	void Score()
	{
		click = click + 1; 
		scoreField.text = click.ToString();
	}
	void Update()
	{
		time = time - Time.deltaTime;
		timeField.text = ((int)time).ToString();

	    if (time < 0 && click >= 30) 
		{
			End ();
		}
		else if(time < 0 && click < 30)
		{
			Loss ();
		}
	}
	void End()
	{
		SceneManager.LoadScene("End");
	}
	void Loss()
	{
		SceneManager.LoadScene ("Loss");
	}
}
