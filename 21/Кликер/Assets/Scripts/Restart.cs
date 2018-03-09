using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	
	public Button restartButton;
	public Button exitButton;

	void Start () 
	{
		restartButton.onClick.AddListener(RestartGame);
		exitButton.onClick.AddListener (ExitGame);
	}
	void RestartGame()
	{
		SceneManager.LoadScene("Clicker");
	}
	void ExitGame()
	{
		Application.Quit();
	}
}
