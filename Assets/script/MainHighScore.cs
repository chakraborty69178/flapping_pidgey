using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class MainHighScore : MonoBehaviour {

	public Text HighscoreText;
	void Start () {
		StartCoroutine (ShowAds ());
		if (HighscoreText != null) {
			HighscoreText.text = "H.S = " + GameData.Instance.HighScore;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (HighscoreText != null) {
			HighscoreText.text = "H.S = " + GameData.Instance.HighScore;
		}
	}
	IEnumerator ShowAds()
	{
		yield return new WaitForSeconds (1);
	//	if (Advertisement.IsReady())
		//{
		//	Advertisement.Show();
		//}
	}


}
