using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendButtonScript : MonoBehaviour {

	public InputField InputField;
	public GameObject content;

	public void SendText() {
		Debug.Log(InputField.text);
		InputField.text = "";
	}
}
