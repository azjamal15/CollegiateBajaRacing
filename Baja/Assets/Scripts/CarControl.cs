using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {

	public GameObject control;
	public GameObject AIControl;
	public GameObject AIControl2; 

	// Use this for initialization
	void Start () {
		control.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
		AIControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController> ().enabled = true; 
		AIControl2.GetComponent<UnityStandardAssets.Vehicles.Car.CarController> ().enabled = true; 

		
	}
	

}

