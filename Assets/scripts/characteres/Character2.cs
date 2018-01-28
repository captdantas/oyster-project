using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 : CharacterModel {

	public Character2() {
		name = "Helgos";
		job = "Engineer";
		imagePath = "";
		messages = new Message[] {
			new Message(0, "I know you are there! I can see the câmeras from here. Get UP!! If you didn’t breathe this heavy, I would actually think you were dead. I can get to the ship’s Energy Storage from my cabin... And I have terrible News my friend. The battery fluid is leaking, we don’t have much time. Can you hear me??", new Response[] { new Response("Yes", false, 1)}),
			new Message(1, "Can you tell me the Battery Model? I just can’t remember, and the fluid destroyed the box!! The others are just like it! Totally destroyed. I need it to keep up alive.", new Response[] { new Response("", true, 2)}),
			new Message(2, "Man, if you could see the situation around here... It’s a shame that only I have the câmeras, and they don’t even have colors! Can you tell if there is a little light sparkling around there? What’s its color?", new Response[] { new Response("Red", true, 3)}),
			new Message(3, "That’s sure is bizarre, did you just feel this? The interference? Anyway, I have everything ready around here to fix the battery. This is gonna get serious! I need you to stay with me all the time ok? I really need your help! Luckily you are not Clark, or else, I would be totally dead!!", new Response[] { new Response("Yes", false, 4)}),
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
			new Message(20, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
			new Message(0, "", new Response[] { new Response("", false, 1)}),
						
		};
	}
}
