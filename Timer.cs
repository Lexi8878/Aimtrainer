using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	[SerializeField] TMP_Text timerText;
	float endTime;
	const float gameTime = 60f;

	void Start()
	{
		endTime = Time.time + gameTime;
	}

	void Update()
	{
		float timeLeft = endTime - Time.time;

		if(timeLeft <= 0)
		{	
			SceneManager.LoadSceneAsync(2);
		}

		timerText.text = $"Time Left: {timeLeft.ToString("0.0")}";
	}
}
