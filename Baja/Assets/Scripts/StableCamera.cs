using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableCamera : MonoBehaviour {

	public GameObject Car;
	public float CarXAxis;
	public float CarYAxis;
	public float CarZAxis;


	// Update is called once per frame
	void Update () {
		CarXAxis = Car.transform.eulerAngles.x;
		CarYAxis = Car.transform.eulerAngles.y;
		CarZAxis = Car.transform.eulerAngles.z;

		transform.eulerAngles = new Vector3 (CarXAxis - CarXAxis, CarYAxis, CarZAxis - CarZAxis);

		
	}
}
