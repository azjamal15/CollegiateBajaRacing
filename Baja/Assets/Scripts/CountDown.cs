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
	public GameObject AIControl; //for AI Car Controller
	public GameObject AIControl2; //for other AI Car controller 
	public AudioSource ChaLa; //Adding music to level :) #DBZ

	void Start () {
		StartCoroutine (CountStart ());

	}
	
	/* Starts the counter */
	IEnumerator CountStart() { 
		 
		AIControl2.SetActive (false);
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
		//countDown.GetComponent<Text> ().text = "GO!"; 
		go.Play ();

		ChaLa.Play ();
		timer.SetActive (true);
		control.SetActive (true);
		AIControl.SetActive (true);
		AIControl2.SetActive (true);

	} 
}
