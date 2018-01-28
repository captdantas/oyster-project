using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour {

	public GameObject spaceship;
	public GameObject heaterL;
	public GameObject heaterR;
	private SpriteRenderer spaceshipSprite;
	private SpriteRenderer heaterLSprite;
	private SpriteRenderer heaterRSprite;
	private int totalTime;
	private float percentagetimeleft;
	private Color tmp;

	// Use this for initialization
	void Start () {
		
		spaceshipSprite = spaceship.GetComponent<SpriteRenderer>();
		heaterLSprite = heaterL.GetComponent<SpriteRenderer>();
		heaterRSprite = heaterR.GetComponent<SpriteRenderer>();

		totalTime = TimeScript.TIME_LEFT;

		tmp = spaceship.GetComponent<SpriteRenderer>().color;

				
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		percentagetimeleft = TimeScript.TIME_LEFT * 100 / totalTime;
		tmp.r = 1 * percentagetimeleft/100;
		tmp.g = 1 * percentagetimeleft/100;
		tmp.b = 1 * percentagetimeleft/100;

		spaceshipSprite.color = tmp;
		heaterLSprite.color = tmp;
		heaterRSprite.color =  tmp;

		if (TimeScript.TIME_LEFT <= 0) {
			SceneManager.LoadScene(2);
		}
	}
}
