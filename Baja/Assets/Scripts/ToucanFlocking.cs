using UnityEngine;
using System.Collections;

public class ToucanFlocking : MonoBehaviour
{
	private GameObject Controller;
	private bool inited = false;
	private float minVelocity;
	private float maxVelocity;
	private float randomness;
	private GameObject chasee;
	private Rigidbody rigidbody; 

	void Start ()
	{
		GameObject toucan = GameObject.FindGameObjectWithTag ("toucan1");
		rigidbody = toucan.GetComponent<Rigidbody>(); 
		StartCoroutine ("ToucanSteering");

	}

	IEnumerator ToucanSteering ()
	{
		while (true)
		{
			if (inited)
			{
				rigidbody.velocity = rigidbody.velocity + Calc () * Time.deltaTime;

				// enforce minimum and maximum speeds for the toucans
				float speed = rigidbody.velocity.magnitude;
				if (speed > maxVelocity)
				{
					rigidbody.velocity = rigidbody.velocity.normalized * maxVelocity;
				}
				else if (speed < minVelocity)
				{
					rigidbody.velocity = rigidbody.velocity.normalized * minVelocity;
				}
			}

			float waitTime = Random.Range(0.3f, 0.5f);
			yield return new WaitForSeconds (waitTime);
		}
	}

	private Vector3 Calc ()
	{
		Vector3 randomize = new Vector3 ((Random.value *2) -1, (Random.value * 2) -1, (Random.value * 2) -1);

		randomize.Normalize();
		ToucanController toucanController = Controller.GetComponent<ToucanController>();
		Vector3 flockCenter = toucanController.flockCenter;
		Vector3 flockVelocity = toucanController.flockVelocity;
		Vector3 follow = chasee.transform.localPosition;

		flockCenter = flockCenter - transform.localPosition;
		flockVelocity = flockVelocity - rigidbody.velocity;
		follow = follow - transform.localPosition;

		return (flockCenter + flockVelocity + follow * 2 + randomize * randomness);
	}

	public void SetController (GameObject theController)
	{
		Controller = theController;
		ToucanController toucanController = Controller.GetComponent<ToucanController>();
		minVelocity = toucanController.minVelocity;
		maxVelocity = toucanController.maxVelocity;
		randomness = toucanController.randomness;
		chasee = toucanController.chasee;
		inited = true;
	}
}