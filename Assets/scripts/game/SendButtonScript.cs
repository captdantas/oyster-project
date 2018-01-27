using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendButtonScript : MonoBehaviour {

	public InputField InputField;
	public GameObject chatDetail;

	public void SendText() {
		ChatDetailScript chatDetailScript = chatDetail.GetComponent<ChatDetailScript>();
		chatDetailScript.writeMessage(InputField.text, true);
		InputField.text = "";
	}
}
