using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonScript : MonoBehaviour {

	public GameObject chatList;
	public GameObject chatDetail;

	public void ActionBack() {
		chatDetail.SetActive(false);
		chatList.SetActive(true);
	}
}
