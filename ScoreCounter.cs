using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter instance;

	public TMP_Text text;
	public int score = 0;

    private void Awake() {
        instance = this;
    }

    void Start() {
        text.text = "Score: " + score.ToString();
    }

	public void AddPoint()
	{
		score++;
		text.text = "Score: " + score.ToString();
	}
}
