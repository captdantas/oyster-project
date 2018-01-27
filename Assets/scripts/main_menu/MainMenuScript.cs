using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour {

	public void BtnClickStart() {
		SceneManager.LoadScene(1);
	}

	public void BtnClickCredits() {
		SceneManager.LoadScene(4);
	}

	public void BtnClickExit() {
		Application.Quit();
	}
}
