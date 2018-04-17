using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {

	public GameObject control;

	// Use this for initialization
	void Start () {
		control.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
		
	}
	

}

