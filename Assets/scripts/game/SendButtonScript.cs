using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendButtonScript : MonoBehaviour {

	public InputField InputField;
	public GameObject content;

	public void SendText() {
		Text text = content.GetComponent<Text>();
		text.text += InputField.text + "\n";
		InputField.text = "";

		TimeScript.ReduceTime();

		Debug.Log(TimeScript.TIME_LEFT);
	}
}
