using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoscript : MonoBehaviour {
	public int health;
	public int speed;
	public GameObject enemyLaser;



	// Use this for initialization
	void Start () {
		health = 1;
		InvokeRepeating ("shooter", 0.2f, 0.8f);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * Time.deltaTime * speed);

		//if (!GetComponent<Renderer>().isVisible) {
		//	Destroy (gameObject);
			
		//}
	}


	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.tag == "Lazer") {
			//destroy the laser first
			Destroy (coll.gameObject);
			//destroy this ufo
			Destroy (gameObject);

		}
	}


	IEnumerator shooter(){
		for (int i = 0; i < 3; i++) {
			Instantiate (enemyLaser, transform.position, Quaternion.identity);
			yield return new WaitForSeconds (0.2f);
		}

	}



}
