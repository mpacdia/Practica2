using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
	public float timeRemaining = 0;
	public bool timeIsOn = true;
	public TMP_Text timeText;

	void Start()
	{
		timeIsOn = true;
	}

	void Update()
	{
		if (timeIsOn)
		{
			if (timeRemaining >= 0)
			{
				timeRemaining += Time.deltaTime;
				DisplayTime(timeRemaining);
			}
		}
	}

	void DisplayTime (float timeToDisplay)
	{
		timeToDisplay +=1;
		float minutes = Mathf.FloorToInt (timeToDisplay / 60);
		float seconds = Mathf.FloorToInt (timeToDisplay % 60);
		timeText.text = string.Format ("{00:00} : {01:00}", minutes, seconds);
	}
}
