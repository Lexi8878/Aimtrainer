using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndPanel : MonoBehaviour
{
	[SerializeField] TMP_Text accuracyText;

	void Start()
	{
		CalculateAccuracy();
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void GoMain() {
		SceneManager.LoadSceneAsync(0);
	}

	public void OnGameEnded()
	{
		SceneManager.LoadSceneAsync(1);
	}

	public void CalculateAccuracy()
	{
		float accuracy = (float)ScoreCounter.instance.score / (float)(ScoreCounter.instance.score + MissCounter.Misses);
		accuracy *= 100f;
		accuracyText.text = $"Accuracy: {accuracy.ToString("0")}%";
	}
}
