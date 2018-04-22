using UnityEngine;
using System.Collections;

public class collumnPool : MonoBehaviour {

	public int collumnpoolsize = 5;
	public GameObject collumnPrefab;
	public GameObject[] collumns;
	private Vector2 ObjectPosition = new Vector2 (15f, 25f);
	private float TimeScinceLastSpawn;
	private float spawnRate = 4f;
	public float collumnmin=-1f;
	public float collumnmax=-3.5f;
	private float spawnXposition = -14f;
	private int currentCollumn = 0;
	void Start () {
		collumns = new GameObject[collumnpoolsize];
		for (int i = 0; i < collumnpoolsize; i++) {
			collumns [i] = (GameObject)Instantiate (collumnPrefab, ObjectPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		TimeScinceLastSpawn += Time.deltaTime;
		if (GAmeController.Instance.GameOver==false&& TimeScinceLastSpawn>=spawnRate) {
			TimeScinceLastSpawn = 0;
			float spawnYposition = Random.Range (collumnmin, collumnmax);
			collumns [currentCollumn].transform.position = new Vector2 (spawnXposition, spawnYposition);
			currentCollumn++;
			if (currentCollumn>=collumnpoolsize) {
				currentCollumn = 0;
			}
		}
	}
}
