using UnityEngine;
using System.Collections;

public class Bottle : MonoBehaviour {


	public void Fall()
	{
		rigidbody.AddForce (transform.forward * 450f);
	}
}
