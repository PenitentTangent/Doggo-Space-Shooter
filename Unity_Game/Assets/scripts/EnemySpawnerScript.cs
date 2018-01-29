using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnEnemies", 3f, 6f);
	}

	// Update is called once per frame
	void Update () {

	
	}
		
	void SpawnEnemies(){
		Debug.Log ("in spawn enemies");
		Vector2 spawnPosition = new Vector2(Random.Range(-8f, 8f), transform.position.y);
		Instantiate (enemy, spawnPosition, Quaternion.identity);

	
	}
}



