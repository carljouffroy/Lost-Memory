using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Onmousedown()
	{
		rigidbody.AddForce (-transform.forward * 500);
		rigidbody.useGravity = true;
	}
}
