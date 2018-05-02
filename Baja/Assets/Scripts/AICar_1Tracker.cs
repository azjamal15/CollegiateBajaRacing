using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar_1Tracker : MonoBehaviour {

	public GameObject theTracker; 
	public GameObject theTracker2;
	public GameObject wp1; 
	public GameObject wp2; 
	public GameObject wp3;
	public GameObject wp4; 
	public GameObject wp5; 
	public GameObject wp6; 
	public GameObject wp7;
	public GameObject wp8; 

	public int wpTracker;
	public int wpTracker2;

	void Start() { 
		AudioListener.volume = 0.25f;

	}

	void Update() { 


		//Debug.Log ("Test"); 
		if (wpTracker == 0) {  
			theTracker.transform.position = wp1.transform.position;

		}
		if (wpTracker == 1) {
			theTracker.transform.position = wp2.transform.position;
		}
		if (wpTracker == 2) {
			theTracker.transform.position = wp3.transform.position;
		}
		if (wpTracker == 3) {
			theTracker.transform.position = wp4.transform.position;
		}
		if (wpTracker == 4) {
			theTracker.transform.position = wp5.transform.position;
		}
		if (wpTracker == 5) {
			theTracker.transform.position = wp6.transform.position;
		}
		if (wpTracker == 6) {
			theTracker.transform.position = wp7.transform.position;
		}
		if (wpTracker == 7) { 
			theTracker.transform.position = wp8.transform.position;
		} 

		if (wpTracker == 0) {  
			theTracker2.transform.position = wp1.transform.position;

		}
		if (wpTracker2 == 1) {
			theTracker2.transform.position = wp2.transform.position;
		}
		if (wpTracker2 == 2) {
			theTracker2.transform.position = wp3.transform.position;
		}
		if (wpTracker2 == 3) {
			theTracker2.transform.position = wp4.transform.position;
		}
		if (wpTracker2 == 4) {
			theTracker2.transform.position = wp5.transform.position;
		}
		if (wpTracker2 == 5) {
			theTracker2.transform.position = wp6.transform.position;
		}
		if (wpTracker2 == 6) {
			theTracker2.transform.position = wp7.transform.position;
		}
		if (wpTracker2 == 7) { 
			theTracker2.transform.position = wp8.transform.position;
		} 


	} //end Update() 

	IEnumerator OnTriggerEnter(Collider collision) { 
		Debug.Log ("Test 2");
		if (collision.gameObject.tag == "AICar01") { 
			this.GetComponent<BoxCollider> ().enabled = false;
			wpTracker += 1; 

			if (wpTracker == 8) {
				wpTracker = 0; 
			}

			yield return new WaitForSeconds (1); 
			this.GetComponent<BoxCollider> ().enabled = true; 
		}

		if (collision.gameObject.tag == "AICar02") { 
			this.GetComponent<BoxCollider> ().enabled = false;
			wpTracker2 += 1; 

			if (wpTracker2 == 8) {
				wpTracker2 = 0; 
			}

			yield return new WaitForSeconds (1); 
			this.GetComponent<BoxCollider> ().enabled = true; 
		}  
			
	
	}
}
