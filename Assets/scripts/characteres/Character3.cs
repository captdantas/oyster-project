using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character3 : CharacterModel {

	public Character3() {
		name = "Clark K";
		job = "Specialist";
		imagePath = "";
		messages = new Message[] {
			new Message(0, "You are receiving a new message from: Clark K. \n This message may contain unknown characters, the system is unable to translate. \n Do you want to read the message?", new Response[] { new Response("No", true, 21), new Response("Yes", true, 1)}),
			new Message(1, "", new Response[] { new Response("", false, 2)}),
			new Message(2, "", new Response[] { new Response("", false, 3)}),
			new Message(3, "", new Response[] { new Response("", false, 4)}),
			new Message(4, "", new Response[] { new Response("", false, 5)}),
			new Message(5, "", new Response[] { new Response("", false, 6)}),
			new Message(6, "", new Response[] { new Response("", false, 7)}),
			new Message(7, "", new Response[] { new Response("", false, 8)}),
			new Message(8, "", new Response[] { new Response("", false, 9)}),
			new Message(9, "", new Response[] { new Response("", false, 10)}),
			new Message(10, "", new Response[] { new Response("", false, 11)}),
			new Message(11, "", new Response[] { new Response("", false, 12)}),
			new Message(12, "", new Response[] { new Response("", false, 13)}),
			new Message(13, "", new Response[] { new Response("", false, 14)}),
			new Message(14, "", new Response[] { new Response("", false, 15)}),
			new Message(15, "", new Response[] { new Response("", false, 16)}),
			new Message(16, "", new Response[] { new Response("", false, 17)}),
			new Message(17, "", new Response[] { new Response("", false, 18)}),
			new Message(18, "", new Response[] { new Response("", false, 19)}),
			new Message(19, "", new Response[] { new Response("", false, 20)}),
			new Message(20, "", new Response[] { new Response("", false, 99)}),



			new Message(21, ".......................................", new Response[] { new Response("", false, 99)}),
			new Message(0, "", new Response[] { new Response("", false, 0)}),
			new Message(0, "", new Response[] { new Response("", false, 0)})	
		};
	}
}
