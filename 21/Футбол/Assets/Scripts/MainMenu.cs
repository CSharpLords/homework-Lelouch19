using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Button startButton;
	public Button creditsButton;
	public Button exitButton;

	void Start () 
	{
		Button startButton = GetComponent<Button> (); 
		Button creditsButton = GetComponent<Button> (); 
		Button exitButton = GetComponent<Button> (); 

		startButton.onClick.AddListener(LoadGame);
		exitButton.onClick.AddListener(ExitGame);
	}
	void LoadGame() 
	{
		SceneManager.LoadScene("Field");
	}
	void ExitGame() 
	{
		Application.Quit();
	}
}
