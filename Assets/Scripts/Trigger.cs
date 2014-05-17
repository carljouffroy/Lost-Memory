using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public bool doOnce = true;
	public GameObject actionObject; //gameobject you want to communicate with. This object holds the function for the event.
	public string functionToRun; //this is the name of the function you want to call on the actionObject

	// Use this for initialization
	void Start ()
	{
		renderer.enabled = false;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			if(actionObject != null)
			{
				actionObject.BroadcastMessage(functionToRun);
			}
			else
			{
				Debug.Log ("Nothing assigned for ActionObject! Assign a gameobject to this variable on the Trigger object.");
			}
		}
		if (doOnce) 
		{
			Destroy(this.gameObject);
		}
	}
}
