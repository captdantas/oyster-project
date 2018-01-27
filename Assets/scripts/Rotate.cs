using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
private bool turnedOn = true;
public int speed = 1;

    void FixedUpdate ()
	{
    	
		// Rotate the object around its local X axis at 1 degree per second
		if (turnedOn) {
			transform.Rotate(Vector3.forward, Time.deltaTime * speed);
		}


    }
}

