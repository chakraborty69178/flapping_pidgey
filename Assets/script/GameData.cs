using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour {
	public static GameData Instance;
	public string bird;
	public int HighScore=0;
	public Text HighscoreText;

	void Awake () {
		if (Instance == null) {
			Instance = this;

		} 

		else if (Instance != this) {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (this);
	}


	void Start()
	{
		HighScore=PlayerPrefs.GetInt ("HighScore");
		bird = PlayerPrefs.GetString ("bird");

	}

	public void PlayerSellect(string str)
	{
		bird = str;
		PlayerPrefs.SetString ("bird", bird);
	}
	

}
