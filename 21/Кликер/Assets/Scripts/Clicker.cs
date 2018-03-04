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
	void Update()
	{
		time = time - Time.deltaTime;
		timeField.text = ((int)time).ToString();
		if(time < 0 )
		{
			End ();
		}
	}
	void Score()
	{
		click = click + 1; 
		scoreField.text = click.ToString();
	}
	void End()
	{
		SceneManager.LoadScene("End");
	}

}
