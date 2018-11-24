using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour {

	int countDownStartValue = 10; //limit time to two minutes
	public Text timerUI;
	void Start () {
		countDownTimer();
	}
	void countDownTimer()
	{
		if(countDownStartValue>0)
		{
			timerUI.text = "Time left:"+countDownStartValue;
			countDownStartValue--;
			Invoke("countDownTimer",1.0f);
		}
		else
		{
			SceneManager.LoadScene("final");
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
