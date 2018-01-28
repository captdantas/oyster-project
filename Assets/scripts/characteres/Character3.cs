using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character3 : CharacterModel {

	public Character3() {
		name = "Clark K";
		job = "Specialist";
		imagePath = "";
		messages = new Message[] {
			new Message(0, "You are receiving a new message from: Clark K. \n This message may contain unknown characters, the system is unable to translate. \n Do you want to read the message?", new Response[] { new Response("No", true, 20), new Response("Yes", true, 1)}),
			new Message(1, "Come In! Oster Ship, do you copy? \n I’m on the Star Station next to you. \n %]+ª;/!%\\?_* \n any problems \n ]+%(?_*[!?} \n message?", new Response[] { new Response("", true, 2)}),
			new Message(2, ";/]}!?:@/}[ \n Exploded \n ?}+\\+]ª;_+ \n All right?", new Response[] { new Response("", true, 3)}),
			new Message(3, "?&&[]ª[;=?§[!+:];$&+-=];-!+]+ \n )%_ª;/ \n Restart \n ;/] \n Comunication System?", new Response[] { new Response("No", true, 20), new Response("Yes", true, 4)}),
			new Message(4, "Oh, it’s good to talk normally again. I don’t know what happened. Your messages were being translated to a totally different language. It was pretty hard to understand anything. The problem must be solved but I think we might still get some minor issues here and there.", new Response[] { new Response("", true, 5)}),
			new Message(5, "Are you still stuck in the Ship? Everyone was separated in the explosion yesterday but your cabin was still attached to the ship’s structure. \n That damn vortex… Showed up out of nowhere and suddenly everything was torn apart. I’ve heard about that kind of event happening in some places of the universe but, never expected to happen to us! Some theories even say that it’s a terrorist group that keeps destroying planets with some kind of generator, that reacts to the vacuum in space and creates the vortex… Do you think that’s real?", new Response[] { new Response("", true, 6)}),
			new Message(6, "I know right? That’s messed up, why would they do that? Maybe they just want to see everything burn. \n Damn terrorists, who do they think they are, right?", new Response[] { new Response("", true, 7)}),
			new Message(7, "I know what you’re thinking, “why would an ex-space pirate think like that”? Well, I’ve told you before, I’ve changed… I’m different now, things are not all about stealing and running away, and I still learn a lot from you every single day.", new Response[] { new Response("", true, 8)}),
			new Message(8, "Things around here are a little bit boring, nothing happens around the station, they basically transfer calls from one place, to another all day. \n But that might be good, I mean, that explosion gave me an adventure for at least three days after all.", new Response[] { new Response("", true, 9)}),
			new Message(9, "Well, I need to get you here, our ship’s totally wrecked and I need to get you out of there. What can you see from where you are?", new Response[] { new Response("Nothing", true, 10)}),
			new Message(10, "That’s… totally expected, you’re in space after all. \n Well, I need to find out where you are. Your transmitter should have a serial number, can you tell me what it is?", new Response[] { new Response("CT-9901", true, 11), new Response("", true, 19)}),
			new Message(11, "I’ll try to track our call from here. \n Have you talked to the others? Vona? Holges? Ga’taah? Are they with you already? I couldn’t reach any of them, but somehow, your transmitter showed up online here, that’s how we’re talking. \n The Star System is almost done recognizing your Transmitter. Maybe a few more hours… It’s pretty hard tracking people all around space, so many devices, addresses, and even people trying to hack information out of nowhere…", new Response[] { new Response("", true, 12)}),
			new Message(12, "OK! We’re done, now can you… \n What happend? I just…. Just heard an explosion. I’ll go see what it is. \n Captain! Captain can you hear me?", new Response[] { new Response("", true, 13)}),
			new Message(13, "The Star Station is under attack, they’re… They’re killing everyone. I don’t know what they are after, and I don’t really think I want to find out… \n They are surrounding the building, it’s a Transmission Station for Cthulhu’s sake… What would they…. Oh…. I’m receiving a video message…. \n Their Leader… They did all this to broadcast a message. They are threatening an entire Planet!! Asking for the crown of it’s king. What the hell is wrong with these guys? ‘Surrender the throne peacefully or we’ll conquer you…?’ Who does he think he is? \n I wish you were here to see this… We should totally get these guys.", new Response[] { new Response("", true, 14)}),
			new Message(14, "WAIT!! They are resisting!! Ahahaha There’s still some hope. Some local ships showed up, things are about to get hot. \n Captain! I found an abandoned ship during the invasion. What should I do? Should I ESCAPE and find you, or help them and FIGHT against the terrorist group?", new Response[] { new Response("ESCAPE", true, 15), new Response("FIGHT", true, 16)}),
			new Message(15, "OK! I’ll be going to your location soon. Wait for me in there. \n Geez, I really hope these people get to manage the situation. I pray for their planet’s sake, that’s the first time I saw an actual Space Terrorist group. That’s such an antiquated idea, killing people, wars… Conquering entire species just for slavery… That’s so damn wrong. I wish we could do more for those people…. Maybe when we all meet again, we can chase those criminals and deal with the ourselves.", new Response[] { new Response("", true, 99)}),
			new Message(16, "OK Cap! I promise to do my very best!! I’ll try to deal with them from inside the station, find their leader and make him pay for that. \n It may be the perfect time to show everyone how great I can be for our team! I’ll finally show Ga’Taah my real potential!! She’ll never make fun of me again after this haha.", new Response[] { new Response("", true, 17)}),
			new Message(17, "Wish Me luck captain! I really hope to see you again!", new Response[] { new Response("", true, 18)}),
			new Message(18, "Over and out!", new Response[] { new Response("", true, 99)}),
			new Message(19, "Cap, something’s going on around here, I don’t really know what it is but…. I wish I had found you before. \n Wish Me luck captain! I really hope to see you again!", new Response[] { new Response("", true, 99)}),
			new Message(20, ".....................", new Response[] { new Response("", true, 99)})
		};
	}
}
