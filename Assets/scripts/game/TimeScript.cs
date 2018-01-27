using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript {

	public static int TIME_LEFT = 50;

	public static int DEFAULT_TIME_REDUCE = 2;

	public static bool BATTERY = false;

	public static void ReduceTime() {
		TIME_LEFT -= DEFAULT_TIME_REDUCE;
	}

	public static void IncreaseTime() {
		TIME_LEFT += 12;
	}

}
