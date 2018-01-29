using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupSpawner : MonoBehaviour {

	public GameObject doggo;
	void Start () {
		InvokeRepeating ("SpawnDoggos", 3f, 1f);
	}

	// Update is called once per frame
	void Update () {


	}

	void SpawnDoggos(){
		Vector2 spawnPosition = new Vector2(Random.Range(-8f, 8f), transform.position.y);
		Instantiate (doggo, spawnPosition, Quaternion.identity);


	}
}
