using UnityEngine;
using System.Collections;

public class ToucanController : MonoBehaviour
{
	public float minVelocity = 5;
	public float maxVelocity = 20;
	public float randomness = 1;
	public int flockSize = 20;
	public GameObject prefab;
	public GameObject chasee;

	public Vector3 flockCenter;
	public Vector3 flockVelocity;

	private GameObject[] toucans;

	void Start()
	{
		 
		toucans = new GameObject[flockSize];
		for (var i=0; i<flockSize; i++)
		{
			Debug.Log ("Test");
			Vector3 position = new Vector3 (
				Random.value * GetComponent<Collider>().bounds.size.x,
				Random.value * GetComponent<Collider>().bounds.size.y,
				Random.value * GetComponent<Collider>().bounds.size.z
			) - GetComponent<Collider>().bounds.extents;

			GameObject toucan = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
			toucan.transform.parent = transform;
			toucan.transform.localPosition = position;
			toucan.GetComponent<ToucanFlocking>().SetController (gameObject);
			toucans[i] = toucan;
		}
	}

	void Update ()
	{
		Vector3 theCenter = Vector3.zero;
		Vector3 theVelocity = Vector3.zero;

		foreach (GameObject toucan in toucans)
		{
			theCenter = theCenter + toucan.transform.localPosition;
			theVelocity = theVelocity + toucan.GetComponent<Rigidbody>().velocity;
		}

		flockCenter = theCenter/(flockSize);
		flockVelocity = theVelocity/(flockSize);
	}
}