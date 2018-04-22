using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour {
	//private BoxCollider2D GroundCollider;
	private float GroundLength=25.48f;

	void Start () {
		//GroundCollider = GetComponent<BoxCollider2D> ();
		//GroundLength = GroundCollider.size.x;
	}
	

	void Update () {
		if (transform.position.x > GroundLength) {
			reposition ();
		}
	}

	void reposition()
	{
		Vector2 GroundOfset = new Vector2 (GroundLength * 2f, 0);
		transform.position = (Vector2)transform.position - GroundOfset;
	}
}
