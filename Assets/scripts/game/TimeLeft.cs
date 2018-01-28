using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour {

	Text textComp;


	void Start(){
		textComp = GetComponent<Text>();

	}

	void Update ()
	{
		textComp.text = TimeScript.TIME_LEFT + "Hours Left";
	}
}

