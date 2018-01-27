using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatDetailScript : MonoBehaviour {

	public GameObject headerBar;
	public Text chatContent;
	public GameObject footerBar;

	private CharacterModel character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ReceiveModel(CharacterModel characterModel) {
		character = characterModel;
		chatContent.text = "";

		ArrayList messagens = new ArrayList();
		if (SaveChats.chats.TryGetValue(characterModel.name, out messagens)) {
			foreach (string message in messagens) {
				chatContent.text += message + "\n";
			}
		}
	}

	public void writeMessage(string message, bool enter) {
		chatContent.text += message;
		if (enter) {
			chatContent.text += "\n";
		}
		
		if (SaveChats.chats == null) {
			SaveChats.chats = new Dictionary<string, ArrayList>();
		}

		ArrayList messagens = new ArrayList();
		if (SaveChats.chats.TryGetValue(character.name, out messagens)) {
			messagens.Add(message);
			SaveChats.chats.Remove(character.name);
			SaveChats.chats.Add(character.name, messagens);
		} else {
			messagens = new ArrayList();
			messagens.Add(message);
			SaveChats.chats.Add(character.name, messagens);
		}

		TimeScript.ReduceTime();
	}
}
