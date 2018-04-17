using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CountDown : MonoBehaviour {

	public GameObject countDown; 
	public AudioSource go;     //varible for 'GoAudio.wav'
	public AudioSource ready;  //variable for 'GetReady.wav' 
	public GameObject timer;   //timer for lap 
	public GameObject control; //for car controller 

	void Start () {
		StartCoroutine (CountStart ());

	}
	
	/* Starts the counter */
	IEnumerator CountStart() { 
		yield return new WaitForSeconds (0.5f); 
		countDown.GetComponent<Text> ().text = "3";
		ready.Play ();
		countDown.SetActive (true); 

		yield return new WaitForSeconds (1);
		countDown.SetActive (false); 
		countDown.GetComponent<Text> ().text = "2";
		ready.Play ();
		countDown.SetActive (true);

		yield return new WaitForSeconds (1);
		countDown.SetActive (false);
		countDown.GetComponent<Text> ().text = "1";
		ready.Play ();
		countDown.SetActive (true);

		yield return new WaitForSeconds (1);
		countDown.SetActive (false);
		countDown.GetComponent<Text> ().text = "GO!"; 
		go.Play ();

		timer.SetActive (true);
		control.SetActive (true);
	} 
}
