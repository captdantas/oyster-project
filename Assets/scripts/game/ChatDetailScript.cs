using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatDetailScript : MonoBehaviour {

	public GameObject headerBar;
	public Text chatContent;
	public GameObject footerBar;

	public CharacterModel character;

	public bool userInteration = false;

	public bool initialized = false;

	public static int nextMessage;

	public Message currentMessage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (initialized) {
			StartCoroutine("DialogueStart");  
			initialized = false;
		}
	}

	void OnDisable() {
		if (character.name.Equals("Helgos") && currentMessage.number >= 3) {
			if (!chatContent.IsActive() || !headerBar.activeSelf || !footerBar.activeSelf) {
				Constants.CHARACTER_2_DEATH = true;
			}
		}
	}

	public void ReceiveModel(CharacterModel characterModel) {
		character = characterModel;
		chatContent.text = "";

		nextMessage = 0;

		ArrayList messagens = new ArrayList();
		if (SaveChats.chats.TryGetValue(characterModel.name, out messagens)) {
			foreach (string message in messagens) {
				chatContent.text += message + "\n";
			}
		}

		if (character != null)
			initialized = true;

		// DialogueStart();
	}

	public void writeMessage(string message, bool enter, bool user) {
		switch(character.name) {
			case "Vona":
				if (Constants.CHARACTER_1_DEATH)
					return; 
			break;
			case "Helgos":
				if (Constants.CHARACTER_2_DEATH)
					return;
			break;
			case "Clark K":
				if (Constants.CHARACTER_3_DEATH)
					return;
			break;
			case "Ga'Taah":
				if (Constants.CHARACTER_4_DEATH)
					return;
			break;
			case "Incognito":
				if (Constants.CHARACTER_5_DEATH)
					return;
			break;
		}



		message = message.ToUpper();

		if (user) {
			switch(character.name) {
			case "Vona":
				switch(currentMessage.number) {
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 13:
						message = Puzzle.CipherVeryEasy(message);
					break;
					case 14:
					case 15:
					case 16:
						Constants.CHARACTER_1_DEATH = true;
					break;
				}
			break;
			case "Helgos":
				 
				switch(currentMessage.number) {
					case 1:
						if (message.Equals(currentMessage.responses[0].reponse)) {
							TimeScript.IncreaseTime();
						}
					break;
					case 2:
						
					break;
					case 3:
						
					break;
					case 4:
						
					break;
					case 5:
						
					break;
					case 6:
						
					break;
					case 8:
						
					break;
					case 9:
						
					break;
					case 10:
						
					break;
					case 11:
						
					break;
					case 12:
						
					break;
					case 13:
						
					break;
					case 14:
					break;
					case 15:
					break;
					case 16:
					break;
				}
			break;
			case "Clark K":
			break;
			case "Ga'Taah":
			break;
			case "Incognito":
			break;
			}
		}

		if (currentMessage.responses.Length == 1) {
			nextMessage = currentMessage.responses[0].unlock;
		} else {
			if (message == currentMessage.responses[0].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[0].unlock;
			} else if (message == currentMessage.responses[1].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[1].unlock;
			}
		}
		

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

		if (user)
			userInteration = true;
	}

	IEnumerator DialogueStart() {
		foreach(Message message in character.messages) {
			currentMessage = message;
			if (message.number == nextMessage) {
				writeMessage(message.message, true, false);
				if (message.responses.Length == 1) {
					if (!message.responses[0].interation) {
						writeMessage(message.responses[0].reponse, true, false);
						nextMessage = message.responses[0].unlock;
					} else {
						while (!userInteration) {
							yield return null;
						}
						userInteration = false;
					}
				} else {
					while (!userInteration) {
						yield return null;
					}
					userInteration = false;
				}
				// foreach (Response response in message.responses) {
				// 	nextMessage = response.unlock;
				// 	if (!response.interation) {
				// 		writeMessage(response.reponse, true, false);
				// 	} else {
				// 		while (!userInteration) {
				// 			yield return null;
				// 		}
						
				// 	}
				// }
			} else if (message.number == 99) {

			}
		}
	}
}
