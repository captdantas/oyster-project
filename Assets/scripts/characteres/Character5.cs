using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character5 : CharacterModel {

	public Character5() {
		name = "Incognito";
		job = "Incognito";
		imagePath = "/Assets/Icones Personagens/Character5/Character5.png";
		messages = new ArrayList() {
			new Message(0, "Are you happy now?", new Response[] { new Response("", true, 1) }),
			new Message(1, "That’s what you’ve done. \n That’s all YOUR fault!!", new Response[] { new Response("", true, 2) }),
			new Message(2, "Look what you did to your team… I Thought… I thought you cared about them… You were like family… Even I can feel it!!", new Response[] { new Response("", true, 3) }),
			new Message(3, "It ended up being all a lie.. A huge, fat lie. You moron, did you really think that ‘Norian Traitor’ was real? Look at their people! Their devotion…. Their HATE for your team and your cause… How could you…", new Response[] { new Response("", true, 4) }),
			new Message(4, "I should never have trusted you, but at least you’re alive. What about the others? Are they dead already?", new Response[] { new Response("No", true, 5), new Response("Yes", true, 15) }),
			new Message(5, "That’s good to hear, the others have nothing to do with all this… And you still involved them like this… How could you...", new Response[] { new Response("", true, 6) }),
			new Message(6, "You know what? I really wish I could kill you with my bare hands. Our lives are totally destroyed thanks to you. You should never have taken that stone from that ‘traitor’... It brought our doom… We just had to succeed in a negotiation, but you always have to think about yourself first right?", new Response[] { new Response("", false, 7) }),
			new Message(7, "I think I can see you from down here. Are you still inside the ship?", new Response[] { new Response("Yes", true, 8), new Response("No", true, 12) }),
			new Message(8, "HAHAHAHAHA That’s funny, you should be losing it up there. I hope you do!! Good Luck.", new Response[] { new Response("", true, 9) }),
			new Message(9, "It was good talking to you for the last time. I was a recent addition to the team, but I know I had my impact. I did my best and always based on my principles.", new Response[] { new Response("", true, 10) }),
			new Message(10, "I did the best for my people.", new Response[] { new Response("", true, 11) }),
			new Message(11, "Well, I should get going, still have some stuff to deal with around here. Some… How can I say? Norian Business……………………………….", new Response[] { new Response("", false, 99) }),
			new Message(12, "Then WHERE THE HELL ARE YOU??", new Response[] { new Response("", true, 13) }),
			new Message(13, "WHAT DID YOU DO?", new Response[] { new Response("", true, 14) }),
			new Message(14, "Your friends are dying, you should be ashamed… Running away like this… and leaving everyone behind…", new Response[] { new Response("", true, 15) }),
			new Message(15, "That’s what you get after all huh? Alone, somewhere in space… Killed your only friends in the entire galaxy, your only family… I really hope you die out there. Maybe a monstrous ship destroyer invades that sector and swallow you like you’re nothing.", new Response[] { new Response("", false, 99) })	
		};
	}
}
