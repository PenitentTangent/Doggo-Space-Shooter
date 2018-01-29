using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MnuManager : MonoBehaviour {

	public void MyLoadScene(string sceneName) {

		SceneManager.LoadScene (sceneName);

	}
}
