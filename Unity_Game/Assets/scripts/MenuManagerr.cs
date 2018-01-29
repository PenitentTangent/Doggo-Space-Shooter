using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerr : MonoBehaviour {

	public void ChangeScene(string arloscene) {

		SceneManager.LoadScene (arloscene);

	}
}
