﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene("main");
	}

	public void QuitGame()
	{
		Debug.Log("Quit!");
		Application.Quit();
	}
}
