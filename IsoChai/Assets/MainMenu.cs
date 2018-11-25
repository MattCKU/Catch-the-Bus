﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene("level_1");
	}

	public void QuitGame()
	{
		Debug.Log("Quit!");
		Application.Quit();
	}
	public void back()
	{
		SceneManager.LoadScene("menu");
	}
	public void introduction()
	{
		SceneManager.LoadScene("introduction");
	}
}
