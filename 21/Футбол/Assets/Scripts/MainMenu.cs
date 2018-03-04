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
		startButton.onClick.AddListener(LoadGame);
		exitButton.onClick.AddListener(ExitGame);
		creditsButton.onClick.AddListener(LoadCredits);
	}
	void LoadCredits()
	{
		SceneManager.LoadScene("Credits");
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
