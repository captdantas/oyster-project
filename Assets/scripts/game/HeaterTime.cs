using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeaterTime : MonoBehaviour {

	public GameObject text;

	void OnMouseDown ()
	{
		if (text.activeSelf) {
			text.SetActive (false);
		} else {
			text.SetActive(true);
		}
 
 }
}
