using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidwayTrigger : MonoBehaviour {

	public GameObject midwayTrigger; 
	public GameObject completeLapTrigger; 

	void OnTriggerEnter() { 
		completeLapTrigger.SetActive (true); 
		midwayTrigger.SetActive (false);
	
	} 
}
