using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1 : CharacterModel {

	public Character1() {
		name = "Vona";
		job = "Security Chief";
		imagePath = "";
		messages = new Message[] {
			new Message(0, "Hello?! Hello!? \n Is anyone there?", new Response[] { new Response("Yes", true, 1)}),
			new Message(1, "My God! You are alive! Do you have any idea how long I have been trying to contact someone?", new Response[] { new Response("Yes", true, 2)}),
			new Message(2, "Are getting my messages correctly? We are having transmission issues. Did you notice any difference?", new Response[] { new Response("Yes", true, 3)}),
			new Message(3, "I couldn’t understand! Can you repeat? Your voice is getting distorted.", new Response[] { new Response("Yes", true, 4)}),
			new Message(4, "What happened? That explosion was bizarre! I am a lot more calm now that I know our ship is fine. I have been worried that the worst had happened. I am in a strange planet, full of water and nature... Where am I?", new Response[] { new Response("Earth", false, 5)}),
			new Message(5, "I am on Earth? How did we get here? I believe this planet still have a lot of living creatures on it... I can see some destroyed structures from where I am. It is funny to see Feline Buildings. \n My locator is giving me strange values \n X= -21.805149 \n Y=-49.089977 \n. This is such a strange location, and there is a city nearby, I need to know it's name. Could you tell me?", new Response[] { new Response("Bauru", true, 6)}),
			new Message(6, "Hey, hey, I think I found some habitants, they look like they are hurt. I have talked to them and they said that there’s a lost Feline Ship and they are looking for a way out of here. I could take a look with them, do you think I should go?", new Response[] { new Response("Yes", true, 7), new Response("No", true, 16)}),
			new Message(7, "It’s odd talking to Feline Earthlings, they remind me of Ga’taah. How is she by the way? It would be funny talking to them about her. She would hate them HAHAHA! I hope someday I get out of here to meet all of you.", new Response[] { new Response("Yes", false, 8)}),
			new Message(8, "Remember when we were attacked by Space Pirates and almost lost our Ship?? If it wasn’t for my abilities, we would be doomed by now. You guys almost lost it. Clark even changed colors! Anyway, I need those coordenates, can you still get the for me?", new Response[] { new Response("yes", true, 9)}),
			new Message(9, "Thanks for listening. I think that I won’t be able to get out of here alive. We are going in the Meteor Crash direction. Earth is shaking and it could break at any moment. Do you think I should keep going?", new Response[] { new Response("Yes", true, 10), new Response("No", true, 11)}),
			new Message(10, "Hey, Hey! Are you there? We found the spaceship! But I don’t have much time!! The floor is breaking and it won’t stand. I need some urgent information, I can't remember the name of that energy stone Clark used that time... It's the same we need right now.", new Response[] { new Response("Jade", true, 99)}),
			new Message(11, "I am feeling a little lonely, I miss my feline friends company. I wonder if they are ok.", new Response[] { new Response("", false, 12)}),
			new Message(12, "Do you have a minute to talk? Remember that Space Dinner we always visited? I feel like I can’t even remember the taste of food... I think... I might be going crazy...", new Response[] { new Response("", true, 13), new Response("", true, 15)}),
			new Message(13, "Oh Commander, I am so grateful for everything we did together. I have no regrets. Lived a increadible life alongside you guys. It’s been so much sime since we met, hasn’t it? The more ironic it looks, my last view is... Pretty great, I have to admit! Oh, if you find Helgos, tell him I forgive him... Can’t take that out of my mind you know...? It’s pretty bizarre.", new Response[] { new Response("", false, 14)}),
			new Message(14, "Transmission... faili... I t..nk that’s it f... me. It’s ...od to h..r your v...ice one last t..e... Don’t ever g... up...", new Response[] { new Response("", false, 99)}),
			new Message(15, "The world has come to an end... I won’t make it alive, I am sorry... I think that’s our last conversation... I need this time alone, my head... It won’t let me........... Goodbye.", new Response[] { new Response("", false, 99)}),
			new Message(16, "I’m being chased! They are comming... TELL HELGOS THAT................................", new Response[] { new Response("", false, 99)})
		};
	}
}
