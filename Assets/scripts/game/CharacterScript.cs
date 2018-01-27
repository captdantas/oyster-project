using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

	public GameObject chatList;
	public GameObject chatDetail;

	public CharacterModel characterModel;

	// Use this for initialization
	void Start () {
		switch(transform.root.name) {
			case "Character1":
			characterModel = new Character1();
			break;
			case "Character2":
			characterModel = new Character2();
			break;
			case "Character3":
			characterModel = new Character3();
			break;
			case "Character4":
			characterModel = new Character4();
			break;
			case "Character5":
			characterModel = new Character5();
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Select() {
		ChatDetailScript chatDetailScript = chatDetail.GetComponent<ChatDetailScript>();
		chatDetailScript.ReceiveModel(characterModel);

		chatList.SetActive(false);
		chatDetail.SetActive(true);
	}
}
