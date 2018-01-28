using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingText : MonoBehaviour {

	public GameObject vonaface;
	public GameObject heliosface;
	public GameObject clark;
	public GameObject gata;

	// Use this for initialization
	void Start ()
	{
		if (Constants.CHARACTER_1_DEATH) {
		vonaface.SetActive(false);
		}
		if (Constants.CHARACTER_2_DEATH) {
			heliosface.SetActive(false);
		}
		if (Constants.CHARACTER_3_DEATH) {
			clark.SetActive(false);
		}
		if (Constants.CHARACTER_4_DEATH) {
			gata.SetActive(false);
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
