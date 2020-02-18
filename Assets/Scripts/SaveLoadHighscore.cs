using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighscore : MonoBehaviour
{
	public Text teksHighScore;
    // Start is called before the first frame update
    void Start()
    {
		teksHighScore.text = "High Score = " + LoadHighScore().ToString();
    }

	public static int LoadHighScore()
	{
		int hg = 0;
		if (!PlayerPrefs.HasKey("high score"))
			PlayerPrefs.SetInt("high score", 0);
		else
			hg = PlayerPrefs.GetInt("high score");
		return hg;
	}
	
	public static void SaveHighScore(int score)
	{
		int hg = 0;
		if (!PlayerPrefs.HasKey("high score"))
			PlayerPrefs.SetInt("high score", 0);
		else
		{
			hg = PlayerPrefs.GetInt("high score");
			hg += score;
			PlayerPrefs.SetInt("high score", hg);
		}
	}
}
