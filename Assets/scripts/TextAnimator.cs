using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimator : MonoBehaviour {

	public float letterPause = 1.5f;

     string message;
     Text textComp;
     public bool trigger = false;
     private bool happenedTrigger = false;
 
     // Use this for initialization
     void Start () {
         textComp = GetComponent<Text>();
         message = textComp.text;
         textComp.text = "";

     }

     void FixedUpdate ()
	{
		if (trigger && !happenedTrigger ) {
			trigger = false;
			happenedTrigger = true;

			StartCoroutine(TypeText ());
			Debug.Log("test");

		}

     }
 
     IEnumerator TypeText () {
         foreach (char letter in message.ToCharArray()) {
             textComp.text += letter;

             yield return new WaitForSeconds (letterPause);
         }
     }
}
