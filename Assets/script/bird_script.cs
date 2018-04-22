using UnityEngine;
using System.Collections;

public class bird_script : MonoBehaviour {
	private bool isDead = false;
	[SerializeField]
	private float jumpforce = 200f;
	private Rigidbody2D rb;
	private Animator anim;
	bool played=false;
	AudioSource audio;
	public AudioClip Hit;
	public AudioClip fly;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim=GetComponent<Animator> ();
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead == false) {
		
			if (Input.GetButtonDown("Fire1"))
			{
				audio.clip = fly;
				audio.Play ();
				rb.velocity = Vector2.zero;
				rb.AddForce (new Vector2 (0, jumpforce));
			}

		}

	}
	void OnCollisionEnter2D()
	{
		audio.clip = Hit;
		if (played == false) {
			audio.Play ();
			played = true;
		}
		isDead = true;
		anim.SetBool ("isDead", true);
		GAmeController.Instance.birdDied ();
		rb.velocity = Vector2.zero;
		//yield WaitForSeconds (audio.clip.length);
		//audio.clip=null;

	}
}
