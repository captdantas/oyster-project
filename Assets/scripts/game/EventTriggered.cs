using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggered{

	public static List<int> VONA_EVENT = new List<int>();

	public static void AddVonaEvent(int eventNumber){
		VONA_EVENT.Add(eventNumber);
	}

}
