using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedText: MonoBehaviour {
	public Text theText; 

	int strIndex = 0; 
	int charIndex = 0;

	public string [] strings; 
	public float speed = 0.1f; 



	// Use this for initialization
	void Start () {
		StartCoroutine (DisplayTimer ());
	}

	IEnumerator DisplayTimer() { 
		while (1 == 1) { 
			yield return new WaitForSeconds(speed);

			if (charIndex > strings [strIndex].Length) { 
				continue; 
			}

			theText.text = strings[strIndex].Substring(0, charIndex);
			charIndex++;
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) { 
			if (charIndex < strings [strIndex].Length) { 
				charIndex = strings[strIndex].Length;
			}
			else if (strIndex < strings.Length) { 
				strIndex++; 
				charIndex = 0;
			}
		}
	}
}
