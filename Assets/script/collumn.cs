using UnityEngine;
using System.Collections;

public class collumn : MonoBehaviour {
	AudioSource audio;
	public AudioClip score;

	void Awake()
	{
		audio = GetComponent<AudioSource> ();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		audio.clip = score;
		if (other.GetComponent<bird_script>()!=null) {
			audio.Play ();
			GAmeController.Instance.birdScored ();
		}	
	}
}
