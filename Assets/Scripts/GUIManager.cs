using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {

	private Button bEasy, bMed, bHard;

	// Use this for initialization
	void Start () {
		try
		{
			LoadButtonLevel();
			int levelstate = LoadLevel();
			switch (levelstate)
			{
				case 0:
					bEasy.interactable = true;
					break;
				case 1:
					bEasy.interactable = true;
					bMed.interactable = true;
					break;
				case 2:
					bEasy.interactable = true;
					bMed.interactable = true;
					bHard.interactable = true;
					break;
			}
		}
		catch(NullReferenceException e)
		{
			// biarkan kosong atau beri keterangan null
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static int LoadLevel()
	{
		int hg = 0;
		if (!PlayerPrefs.HasKey("level"))
			PlayerPrefs.SetInt("level", 0);
		else
			hg = PlayerPrefs.GetInt("level");
		return hg;
	}

	public static void saveLevel(int lvl)
	{
		if (!PlayerPrefs.HasKey("level"))
			PlayerPrefs.SetInt("level", 0);
		else
			PlayerPrefs.SetInt("level", lvl);
	}

	void LoadButtonLevel()
	{
		bEasy = GameObject.Find("Easy").GetComponent<Button>();
		bMed = GameObject.Find("Medium").GetComponent<Button>();
		bHard = GameObject.Find("Hard").GetComponent<Button>();
		bEasy.interactable = bMed.interactable = bHard.interactable = false;
	}

	public void OnPlay(){
		SceneManager.LoadScene("Multilevel");
	}

	public void OnLevel1()
	{
		SceneManager.LoadScene("Main");
	}

	public void OnLevel2()
	{
		SceneManager.LoadScene("Main");
		// seharusnya buat scene baru untuk level medium
	}

	public void OnLevel3()
	{
		SceneManager.LoadScene("Main");
		// seharusnya buat scene baru untuk level hard
	}

	public void OnCredit()
	{
		SceneManager.LoadScene("Credit");
	}

	public void OnHelp()
	{
		SceneManager.LoadScene("Help");
	}

	public void OnKembali()
	{
		SceneManager.LoadScene("Menu");
	}
}
