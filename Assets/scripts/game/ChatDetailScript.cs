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

	public bool getSaved = false;

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

		// headerBar.GetComponent<Image>().overrideSprite =  Resources.Load<Sprite>(character.imagePath);

		nextMessage = 0;

		ArrayList messagens = new ArrayList();
		if (SaveChats.chats.TryGetValue(characterModel.name, out messagens)) {
			foreach (string message in messagens) {
				chatContent.text += message + "\n";
				getSaved = true;
			}
		}

		int number = 0;
		if (SaveChats.chatsNextMessage.TryGetValue(characterModel.name, out number)) {
			nextMessage = number;
			for(int i = 0; i < number; i++) {
				RemoveMessage(i - 1);
			}
		}

		if (character != null)
			initialized = true;
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

		if (user) {
			TimeScript.ReduceTime();
			userInteration = true;

			switch(character.name) {
			case "Vona":
				message = Vona(message.ToUpper(), currentMessage.number);
			break;
			case "Helgos":
				message = Helgos(message.ToUpper(), currentMessage.number);
			break;
			case "Clark K":
				message = Clark(message.ToUpper(), currentMessage.number);
			break;
			case "Ga'Taah":
				message = GaTaah(message.ToUpper(), currentMessage.number);
			break;
			case "Incognito":
				message = Incognito(message.ToUpper(), currentMessage.number);
			break;
			}
		} else {
			message += "\n";
		}

		chatContent.text += message;
		if (enter) {
			chatContent.text += "\n";
		}
		
		SaveChat(message);
	}

	public void SaveChat(string message) {
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

		if (SaveChats.chatsNextMessage == null) {
			SaveChats.chatsNextMessage = new Dictionary<string, int>();
		}

		int number = 0;
		if (SaveChats.chatsNextMessage.TryGetValue(character.name, out number)) {
			SaveChats.chatsNextMessage.Remove(character.name);
			SaveChats.chatsNextMessage.Add(character.name, nextMessage);
		} else {
			SaveChats.chatsNextMessage.Add(character.name, nextMessage);
		}
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
			} else if (message.number == 99) {

			}
		}
	}

	private Message GetMessage(int number) {
		foreach(Message message in character.messages) {
			if (message.number == number)
				return message;
		}
		return null;
	}

	private void RemoveMessage(int number) {
		Message message = new Message();
		foreach(Message messagem in character.messages) {
			if (messagem.number == number)
				message = messagem;
		}
		character.messages.Remove(message);
	}

	private string Vona(string message, int number) {
		switch(number) {
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
			case 14:
				message = Puzzle.CipherVeryEasy(message);
			break;

			case 15:
			case 16:
			case 17:
				Constants.CHARACTER_1_DEATH = true;
			break;
			case 18:
				Constants.CHARACTER_1_ENDING3 = true;
			break;
			case 19:
			Constants.CHARACTER_1_ENDING1 = true;
			break;
			case 20:
				Constants.CHARACTER_1_ENDING2 = true;
			break;
		}
		if (currentMessage.responses.Length == 1) {
			nextMessage = currentMessage.responses[0].unlock;
		} else {
			if (message == currentMessage.responses[0].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[0].unlock;
			} else if (message == currentMessage.responses[1].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[1].unlock;
			} else {
				nextMessage = currentMessage.responses[currentMessage.responses.Length -1].unlock;
			}
		}
		return message + "\n";
	}

	private string Helgos(string message, int number) {
		switch(currentMessage.number) {
			case 1:
			if (message.Equals(currentMessage.responses[0].reponse)) {
				TimeScript.IncreaseTime();
			}
			break;
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			break;
			case 20:
				Constants.CHARACTER_2_DEATH = true;
			break;
		}
		if (currentMessage.responses.Length == 1) {
			nextMessage = currentMessage.responses[0].unlock;
		} else {
			if (message == currentMessage.responses[0].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[0].unlock;
			} else if (message == currentMessage.responses[1].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[1].unlock;
			} else {
				nextMessage = currentMessage.responses[currentMessage.responses.Length -1].unlock;
			}
		}
		return message + "\n";
	}

	public string Clark(string message, int number) {
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
			case 14:
			case 15:
			case 16:
			case 17:
				message = Puzzle.CipherMedium(message);
			break;
			case 18:
			case 19:
			case 20:
				Constants.CHARACTER_3_DEATH = true;
			break;
		}

		if (currentMessage.responses.Length == 1) {
			nextMessage = currentMessage.responses[0].unlock;
		} else {
			if (message == currentMessage.responses[0].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[0].unlock;
			} else if (message == currentMessage.responses[1].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[1].unlock;
			} else {
				nextMessage = currentMessage.responses[currentMessage.responses.Length -1].unlock;
			}
		}
		return message + "\n";
	}

	public string GaTaah(string message, int number) {
		switch(currentMessage.number) {
			default:
				Constants.CHARACTER_4_DEATH = true;
			break;
		}

		if (currentMessage.responses.Length == 1) {
			nextMessage = currentMessage.responses[0].unlock;
		} else {
			if (message == currentMessage.responses[0].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[0].unlock;
			} else if (message == currentMessage.responses[1].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[1].unlock;
			} else {
				nextMessage = currentMessage.responses[currentMessage.responses.Length -1].unlock;
			}
		}
		return message + "\n";
	}

	public string Incognito(string message, int number) {
		if (currentMessage.responses.Length == 1) {
			nextMessage = currentMessage.responses[0].unlock;
		} else {
			if (message == currentMessage.responses[0].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[0].unlock;
			} else if (message == currentMessage.responses[1].reponse.ToUpper()) {
				nextMessage = currentMessage.responses[1].unlock;
			} else {
				nextMessage = currentMessage.responses[currentMessage.responses.Length -1].unlock;
			}
		}
		return message + "\n";
	}
}
