using System.Collections;
using System.Collections.Generic;

public class Message  {

	public int number;
	public string message;
	public Response[] responses;

	public Message() { }
	public Message(int number, string message, Response[] responses) {
		this.number = number;
		this.message = message;
		this.responses = responses;
	}
}
