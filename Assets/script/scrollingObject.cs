using UnityEngine;
using System.Collections;

public class scrollingObject : MonoBehaviour {

	private Rigidbody2D rb;
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (GAmeController.Instance.scrollSpeed, 0);
	}
	

	void Update () {
		rb.velocity = new Vector2 (GAmeController.Instance.scrollSpeed, 0);
		if (GAmeController.Instance.GameOver == true) {
			
			rb.velocity = Vector2.zero;
		}
	}
}
