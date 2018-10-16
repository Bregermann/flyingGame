using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultsScreen : MonoBehaviour {

	public Text resultsText;
	public float timeEndScreen;

	void Start (){
		timeEndScreen = timeEndScreen;
	}
	void Update () {
		timeEndScreen += Time.deltaTime;
		print (timeEndScreen);
		if (timeEndScreen >= 100.0f){
		resultsText.text = "You collected " + Collectibles.numberOfCollectibles + " out of 100";
			}
		if (timeEndScreen >= 110.0f) {
			SceneManager.LoadScene ("winScreen");
		}
	}
}