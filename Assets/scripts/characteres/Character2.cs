using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 : CharacterModel {

	public Character2() {
		name = "Helgos";
		job = "Engineer";
		imagePath = "";
		messages = new ArrayList() {
			new Message(0, "I know you are there! I can see the cAmeras from here. Get UP!! If you didn’t breathe this heavy, I would actually think you were dead. I can get to the ship’s Xtea64 Energy Storage from my cabin... And I have terrible News my friend. The battery fluid is leaking, we don’t have much time. Can you hear me??", new Response[] { new Response("", true, 1)}),
			new Message(1, "Can you tell me the Battery Model? I just can’t remember, and the fluid destroyed the box!! The others are just like it! Totally destroyed. I need it to keep up alive.", new Response[] { new Response("oxt98", true, 5), new Response("", true, 2)}),
			new Message(2, "Nope, didn't work. If I keep missing it I'll be in trouble!", new Response[] { new Response("oxt98", true, 5), new Response("", true, 3)}),
			new Message(3, "Fuck, Fuck, Fuck! Last time, please get it right", new Response[] { new Response("oxt98", true, 5), new Response("", true, 4)}),
			new Message(4, "HOLY SHIT, It didn't explode! It think I might still fix this.", new Response[] { new Response("", true, 5)}),
			new Message(5, "Man, if you could see the situation around here... It’s a shame that only I have the cameras, and they don’t even have colors, not even the basic ones! Can you tell if there is any light sparkling around there? What’s its color?", new Response[] { new Response("Red", true, 6)}),
			new Message(6, "6gSdd/duB1nFyVIo6PEySmdpIv3DsMnAnYiZ2ejJ3bAtb8EQgf3CcA==", new Response[] { new Response("Yes", true, 7)}),
			new Message(7, "By the way, where is that guy? Have you talked to him? It’s not like he’s a close friend of mine but, you know, I’m worried about everyone, we are a team. \n The Five of us… \n I mean, \n six… \n I still forget about the last girl. She’s a lil bit strange. Don’t talk that much to her… \n Anyway, should I turn off our system for a while to take off the battery? That could expose us for a while but… you know...", new Response[] { new Response("Yes", true, 8), new Response("No", true, 24)}),
			new Message(8, "Man, that’s sick!! I almost exploded here… It wouldn’t change that much, would it? Haha! Wish I never tried that... Vona would make this an easy ride. . Did you talk to her?", new Response[] { new Response("", true, 9)}),
			new Message(9, "Forget it... We don’t have time for this, we will talk about it later. We need to FOCUS!!", new Response[] { new Response("", true, 10)}),
			new Message(10, "Well, I think we should be able to communicate a little better from now on.", new Response[] { new Response("", true, 11)}),
			new Message(11, "I saw that... light… Yesterday. How did it happen? I just... Remember seeing the ship exploding, and then... You were there... Still... wouldn’t move a muscle... How did you recovered that quickly? Also... You were the only one I could see in the cameras... Wish I had seen what happened to the others... Vona’s cabin was totally destroyed, Clark just had some minor scratches, Ga’Taah’s is simply gone... But HER cabin was.............", new Response[] { new Response("", true, 12)}),
			new Message(12, "HEY! HEEEY. Something’s going on here!! Be careful driving our ship! The hole cabin was shaking and I think some parts are still breaking.", new Response[] { new Response("", false, 13)}),
			new Message(13, "What was I talki.... Oh, Vona, of course.... Man, I know that I... I really screwed up but, she... wouldn’t even look at me... The whole thing wasn’t ALL my fault... You know that, right?", new Response[] { new Response("", true, 14)}),
			new Message(14, "Come ON! I think we are almost fixing this thing!!", new Response[] { new Response("", true, 15)}),
			new Message(15, "It’s FINALLY OVER!!! We did it! We should have a little bit more battery now... I’m totally exhausted. Now I need to go up there with you. I might take some risks but, worst case scenario, I would freeze to death out there, with no air, or friends... Nah, no big deal.", new Response[] { new Response("", true, 16)}),
			new Message(16, "How do you do it?? It’s taking me HUGE effort to take it like this... Everyone... separated like this... I wonder if they are still alive. I... saw that vortex on one of the câmeras. What in HELL was that? What that thing did to us? I have SO many questions... I’m almost losing it thinking about this stuff.", new Response[] { new Response("", true, 17)}),
			new Message(17, "What if... That’s why you are able to text everyone? The Vortex itself is helping you communicate with everyone else... A curse always come with some kind of bless huh?", new Response[] { new Response("", false, 18)}),
			new Message(18, "I need to get the hell out of here. The cabin... It looks like it’s going to rip off from the rest of the ship... I can try to find you, or fix the motor... What do you think? What should I do? Just can’t think straight locked away like this!! \n CHOICE and WRITE: \n MEET or \n FIX THE MOTOR", new Response[] { new Response("MEET", true, 19), new Response("FIX THE MOTOR", true, 20)}),
			new Message(19, "I hope I can meet you again someday pal!! Good Luck on the rest of your Journey! And... If you ever find Vona again, tell her that I’m sorry...", new Response[] { new Response("", false, 99)}),
			new Message(20, "SHIT!! It’s all wrecked ‘round here. But I think I can fix this... Still, the heat is UNBEARABLE down here. I might not stand even five minutes... \n Do you remember when the ‘little boy’ around here became a Motor Engineer? You just wouldn’t believe it!", new Response[] { new Response("", true, 21)}),
			new Message(21, "Well... I think that makes my death even more Iconic. \n Make sure they sing about me after this!! \n I’m almost there pal. And here’s my last goodbye. Make sure that you live to tell our stories to your siblings and everyone else hahaaa.", new Response[] { new Response("", true, 98)}),
			new Message(22, "I’ll miss you all guys!! If there’s something after this, I hope that I... \n WAIT... IT’S WORKING!!! \n WOOOHOOO!!!", new Response[] { new Response("", true, 23)}),
			new Message(23, ".............................", new Response[] { new Response("", false, 99)}),
			new Message(24, "Fuck dude, I tried to fix it alone... I think I messed up... Do you k.. ho... \n .....", new Response[] { new Response("", false, 99)}),
		};
	}
}
