using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Response {

	public string reponse;

	public bool interation;

	public int unlock;

	public CharacterFlag flag;

	public Response(string response, bool interation, int unlock, CharacterFlag flag) {
		this.reponse = response;
		this.interation = interation;
		this.unlock = unlock;
		this.flag = flag;
	}

	public Response(string response, bool interation, int unlock) {
		this.reponse = response;
		this.interation = interation;
		this.unlock = unlock;
	}
}
