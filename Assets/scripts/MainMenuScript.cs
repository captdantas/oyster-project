using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

	public void BtnClickStart() {
		Application.LoadLevel(1);
	}

	public void BtnClickCredits() {
		Application.LoadLevel(4);
	}

	public void BtnClickExit() {
		Application.Quit();
	}
}
