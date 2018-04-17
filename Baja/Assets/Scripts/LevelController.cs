using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public AudioSource GreenHill; 

	// Use this for initialization
	void Start () {
		GreenHill.GetComponent<AudioSource>().enabled = true;


	}


}