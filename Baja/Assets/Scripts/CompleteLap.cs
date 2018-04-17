using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CompleteLap : MonoBehaviour {

	public GameObject midwayTrigger;
	public GameObject lapCompleteTrigger; 

	public GameObject minDisplay; 
	public GameObject secDisplay; 
	public GameObject milliDisplay; 

	public GameObject lapBox; 

	void OnTriggerEnter() { 
		if (LapManager.SecondCount <= 9) { 
			secDisplay.GetComponent<Text> ().text = "0" + LapManager.SecondCount + ".";
		} 
		else { 
			secDisplay.GetComponent<Text> ().text = "" + LapManager.SecondCount + "."; 
		}

		if (LapManager.MinuteCount <= 9) { 
			minDisplay.GetComponent<Text> ().text = "0" + LapManager.MinuteCount + ".";
		} 
		else { 
			minDisplay.GetComponent<Text> ().text = "" + LapManager.MinuteCount + "."; 
		}


	} 
}
