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

	public GameObject lapCount;
	public int lapComplete; 

	void OnTriggerEnter() { 
		lapComplete += 1; 
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

		milliDisplay.GetComponent<Text> ().text = "" + LapManager.MilliCount + ".";

		LapManager.MinuteCount = 0; 
		LapManager.SecondCount = 0; 
		LapManager.MilliCount = 0;

		lapCount.GetComponent<Text> ().text = "" + lapComplete; 

		midwayTrigger.SetActive (true); 
		lapCompleteTrigger.SetActive (false);



	} 
}
