using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatDetailScript : MonoBehaviour {

	public GameObject gameObject;

	private CharacterModel character;

	bool isLoaded = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLoaded) {
			// GetComponent<Sprite>().
			isLoaded = true;
		}
	}

	public void ReceiveModel(CharacterModel characterModel) {
		character = characterModel;
	}
}
