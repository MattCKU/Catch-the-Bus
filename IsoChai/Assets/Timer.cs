using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	int countDownStartValue = 120; //limit time to two minutes
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
			timerUI.text = "GameOver!";
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
