using UnityEngine;
using System.Collections;

public class ToucanWatcher : MonoBehaviour
{
	public Transform toucanController;

	void LateUpdate ()
	{
		if (toucanController)
		{
			Vector3 watchPoint = toucanController.GetComponent<ToucanController>().flockCenter;
			transform.LookAt(watchPoint+toucanController.transform.position);
		}
	}
}

