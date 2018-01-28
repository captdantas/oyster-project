using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character4 : CharacterModel {

	public Character4() {
		name = "Ga'Taah";
		job = "Pilot";
		imagePath = "";
		messages = new Message[] {
			new Message(0, "Hey Cap! How are you doing? So… About that Vortex… thing, yesterday... Do you actually know anything about it? In one moment everything was fine but out of nowhere… Well… I can’t really remember much, except for high noises and that… Black rift reaching for us.", new Response[] { new Response("", false, 1)}),
			new Message(1, "That thing showed up out of nowhere… I was so scared, ended up in a strange planet with a lot of… Humans…? I thought they were Extint, well, no offense of course. After all you are the best captain we could ever have, we’re all really grateful for having you.", new Response[] { new Response("", false, 2)}),
			new Message(2, "I’ve been thinking these days… What you REALLY think about the ‘Vonda and Helgos’ situation? Of course that she’s right not wanting to talk to him but... \n We’re a team!", new Response[] { new Response("", false, 3)}),
			new Message(3, "We should be working together and supporting each other, no matter what happens! At least that’s what I think.", new Response[] { new Response("", false, 4)}),
			new Message(4, "But the situation is getting a lot more complicated. Aborting a mission because of relationship problems…? That’s pretty complicated. Maybe today we would be in a totally different path, maybe, if we had taken Norion to our side, any of this would’ve happened.", new Response[] { new Response("", false, 5)}),
			new Message(5, "Anyway, the situation is pretty bad around here…. Apparently I’m not welcome around here… Everyone looks me like I’m some kind of freak, with strange eyes and judging me… I don’t understand… Earth used to be so empty and peaceful since the last humans left. It used to be one of my favorite places with all those forests, lakes, fields…. Now, all I can see are Buildings and Metal Vehicles. I really miss the old scenario…", new Response[] { new Response("", false, 6)}),
			new Message(6, "It’s been a while since I last tried contact, I’ve been even more worried since the last time I made and entry. Maybe the worst had actually happened… \n NO!! I won’t be able to accept something like this… I need to find you….", new Response[] { new Response("", false, 7)}),
			new Message(7, "Captain… I’m really sorry for not sending you reports lately. I’m still not getting answers from you but… I don’t really want you to think about me as someone irresponsible like Helgos... I’d never abandon an ally in battle.", new Response[] { new Response("", false, 8)}),
			new Message(8, "Putting everyone in danger… How could he? After all those years by our side. That’s why Vona is the second in command, she’s the light that guides us every time, even when you are around, we need her just like everyone else in our team.", new Response[] { new Response("", false, 9)}),
			new Message(9, "I can’t believe that I am… Still stuck in this situation… I can’t think of anything else. I know it’s complicated but… I can only think that it’s all his faul…. Their, fault…", new Response[] { new Response("", false, 10)}),
			new Message(10, "I’ve been hiding a lot lately, stuck, for days. Ended up being caught while trying to steal food in a Fair. It caused a huge commotion… People looking at my like I’m some kind of monster, running away like their lives depends on it… You know… I’m not even aggressive like that unless.. Unless it’s really necessary.", new Response[] { new Response("", false, 11)}),
			new Message(11, "I can still control my instincts like you teach me but… And I’m really grateful for that, but still… I’ve been starving, and even ended up losing control. I don’t think I can keep this for long… Maybe some days, or even less…", new Response[] { new Response("", false, 12)}),
			new Message(12, "Hello Captain… Something quite strange happened todar… A huge event was being prepared by the Humans around town. Streets were totally empty, I thought it was a great opportunity to get out and search for food, and for the first time in a while, I took off my Mantle…", new Response[] { new Response("", false, 13)}),
			new Message(13, "Some groups were gathering in strange places and heading to a Stadium, somehow that place was calling for me. As soon as I entered, I could see a huge crowd cheering, the floor had red and white lines that made an oval shape crossing around the Stadium. I’ve never seen a place like that before.", new Response[] { new Response("", false, 14)}),
			new Message(14, "Some other humans, female humans, with some kind of uniform, entered and putted themselves in a strange position. I felt attracted by the act and did the same, one step ahead of some blocks, resting, but at the same time, expecting some kind of attack. I thought I was safe, for a second, lowered my guard somehow, when I suddenly heard a loud noise, like an old gun being shot, and felt trapped. The humans might be against me, but how could they set such a trap? Was all that commotion just for catching me? So I ran… And felt like one of the humans on the other day, running like there’s no tomorrow. I couldn’t find an exit, and some other humans were chasing me in a strange rhythm, but I could easily outrun them.", new Response[] { new Response("", false, 15)}),
			new Message(15, "I finally noticed an opening right behind two other female humans holding a long white ribbon. I’ve ran right through them, ripping the ribbon and running outside. I was almost getting out when suddenly two humans caught me by the arm, they were telling me to wait, and they wouldn’t let go of me by any means. Suddenly I realized, I dropped my mantle while running, and everyone was looking at me, in absolute silence. I waited for the worse, thought I’d die right there, but suddenly, the crowd started cheering for me, screaming and clapping their hands, I just couldn’t understand…", new Response[] { new Response("", false, 16)}),
			new Message(16, "Maybe, after today, things start getting better. I can feel it in the bottom of my heart. They even looked at me with a nice smile for the first time.", new Response[] { new Response("", false, 17)}),
			new Message(17, "Well… I think that’s might be my destiny. I promise to do my best Cap!", new Response[] { new Response("", false, 18)}),
			new Message(18, "I hope I can see you soon, I really miss you guys…", new Response[] { new Response("", false, 19)}),
			new Message(19, "See you later, MEOW", new Response[] { new Response("", false, 20)}),
			new Message(20, "^u^", new Response[] { new Response("", false, 99)})
		};
	}
}
