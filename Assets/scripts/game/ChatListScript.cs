using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatListScript : MonoBehaviour {

	public GameObject character1;
	public GameObject character2;
	public GameObject character3;
	public GameObject character4;
	public GameObject character5;

	// Use this for initialization
	void Start () {
		if (Constants.openCharacter > 1)
			character2.SetActive(true);
		if (Constants.openCharacter > 2)
			character3.SetActive(true);
		if (Constants.openCharacter > 3)
			character4.SetActive(true);
		if (Constants.openCharacter > 4)
			character5.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {

		if (Constants.openCharacter > 1)
			if (!character2.active) 
				character2.SetActive(true);
		if (Constants.openCharacter > 2)
			if (!character3.active)
				character3.SetActive(true);
		if (Constants.openCharacter > 3)
			if (!character4.active)
				character4.SetActive(true);
		if (Constants.openCharacter > 4)
			if (!character5.active) 
				character5.SetActive(true);
	}
}
