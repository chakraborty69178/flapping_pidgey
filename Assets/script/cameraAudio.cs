using UnityEngine;
using System.Collections;

public class cameraAudio : MonoBehaviour {

	public AudioClip Opening;
	AudioSource audio;
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GAmeController.Instance.GameOver == true) {
			audio.Stop();
		}
	}
}
