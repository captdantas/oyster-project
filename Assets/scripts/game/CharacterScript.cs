using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

	public GameObject chatList;
	public GameObject chatDetail;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Select() {
		ChatDetailScript chatDetailScript = chatDetail.GetComponent<ChatDetailScript>();
		


		chatList.SetActive(false);
		
		


		chatDetail.SetActive(true);
	}
}
