using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cipher : MonoBehaviour {

	public static string cipherVeryEasy(string text) {
		string result = "";

		foreach (char letter in text) {
			int unicode = ((int)letter);

			if (unicode < 65 || unicode > 90)
				return "ERROR";
			else
				unicode += 1;

			if (unicode > 90)
				unicode = 65;

			result += (char) unicode;
		}
		return result;
	}

	public static string cipherEasy(string text) {
		string result = "";

		foreach (char letter in text) {
			int unicode = ((int)letter);

			if (unicode < 65 || unicode > 90)
				return "ERROR";

			result += unicode + " ";
		}
		return result;
	}

	public static string cipherMedium(string text) {
		string result = "";

		foreach (char letter in text) {
			switch (letter) {
				case 'A':
					result += "%";
				break;
				case 'B':
					result += "$";
				break;
				case 'C':
					result += ")";
				break;
				case 'D':
					result += "(";
				break;
				case 'E':
					result += "+";
				break;
				case 'F':
					result += "=";
				break;
				case 'G':
					result += "*";
				break;
				case 'H':
					result += "!";
				break;
				case 'I':
					result += "?";
				break;
				case 'J':
					result += "@";
				break;
				case 'K':
					result += "#";
				break;
				case 'L':
					result += "&";
				break;
				case 'M':
					result += "-";
				break;
				case 'N':
					result += "_";
				break;
				case 'O':
					result += ";";
				break;
				case 'P':
					result += ":";
				break;
				case 'Q':
					result += "{";
				break;
				case 'R':
					result += "]";
				break;
				case 'S':
					result += "}";
				break;
				case 'T':
					result += "[";
				break;
				case 'U':
					result += "/";
				break;
				case 'V':
					result += "\\";
				break;
				case 'W':
					result += "|";
				break;
				case 'X':
					result += "§";
				break;
				case 'Y':
					result += "ª";
				break;
				case 'Z':
					result += "º";
				break;
			}
		}
		return result;
	}

	public void openLink(string url) {
		Application.OpenURL(url);
	}
}
