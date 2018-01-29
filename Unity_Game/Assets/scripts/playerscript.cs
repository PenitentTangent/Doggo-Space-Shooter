using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour 
{

	public int speed;
	public GameObject lazer;
	public int health;

	// Use this for initialization
	void Start () {

		health = 3;
		
	}
	
	// Update is called once per frame
	void Update () {




		// This is for laser creation!!
		if (Input.GetKeyDown(KeyCode.Space)){
			StartCoroutine ("fireLazer");
			//Instantiate (lazer, transform.position, Quaternion.identity);

		}
			









		//this is for player movement upwards!
		if (Input.GetKey(KeyCode.UpArrow)){

			transform.Translate (Vector2.up * Time.deltaTime * speed);

		}



		//
		if (Input.GetKey(KeyCode.DownArrow)){

			transform.Translate (Vector2.down * Time.deltaTime * speed);

		}

		if (Input.GetKey(KeyCode.LeftArrow)){

			transform.Translate (Vector2.left * Time.deltaTime * speed);

		}

		if (Input.GetKey(KeyCode.RightArrow)){

			transform.Translate (Vector2.right * Time.deltaTime * speed);

		}



			
	}

	IEnumerator fireLazer() {
		for (int i = 0; i < 3; i++) {
			Instantiate (lazer, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(0.05f);
		}
	}
		

	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.tag == "Enemy") {
			health = health - 1;
			Destroy (coll.gameObject);
			Debug.Log ("i lost a heart :( ");

			if (health == 0) {
				Destroy (gameObject);
				Debug.Log("and I died OOH");
			}

		}
	}


}
