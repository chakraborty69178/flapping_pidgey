using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GAmeController : MonoBehaviour {
	public static GAmeController Instance;
	public GameObject gameOverText;
	public bool GameOver = false;
	public float scrollSpeed = 1.5f;
	private int score = 0;
	public Text scoreText;
	public Text HighScoreText;

	void Awake () {
		if (Instance == null) {
			Instance = this;

		} 

		else if (Instance != this) {
			Destroy (gameObject);
		}
		//DontDestroyOnLoad (this);
	}


	void Start()
	{
		GameData.Instance.HighScore=PlayerPrefs.GetInt ("HighScore");
		if (HighScoreText != null) {
			HighScoreText.text = "H.S = " + GameData.Instance.HighScore;
		}
	}
	// Update is called once per frame
	void Update () {
		if (GameOver == false) {
			scrollSpeed = scrollSpeed + 0.000005f;
		}


		if (HighScoreText != null) {
			HighScoreText.text = "H.S = " + GameData.Instance.HighScore;
		}
	
	}
	public void birdScored()
	{
		if (GameOver) {
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString ();
	}
	public void birdDied()
	{
		
		StartCoroutine (birddied ());
		if (score > GameData.Instance.HighScore)
			GameData.Instance.HighScore = score;
		PlayerPrefs.SetInt ("HighScore", GameData.Instance.HighScore);
		GameData.Instance.HighScore=PlayerPrefs.GetInt ("HighScore");

	}
	IEnumerator birddied()
	{	
		GameOver = true;
		yield return new WaitForSeconds (2);
		gameOverText.SetActive (true);
	}
}
