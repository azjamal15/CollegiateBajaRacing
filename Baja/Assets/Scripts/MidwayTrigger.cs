using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidwayTrigger : MonoBehaviour {

	public GameObject midwayTrigger; 
	public GameObject lapCompleteTrigger; 

	void OnTriggerEnter() { 
		lapCompleteTrigger.SetActive (true);
		midwayTrigger.SetActive (false);
	}
}
