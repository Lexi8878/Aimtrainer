using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

	void Start()
	{
		RandomizePosition();
	}

	public void Hit()
	{
		RandomizePosition();
		ScoreCounter.instance.AddPoint();
	}

	void RandomizePosition()
	{
		transform.position = TargetBounds.Instance.GetRandomPosition();
	}
}
