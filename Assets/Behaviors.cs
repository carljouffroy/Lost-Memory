using UnityEngine;
using System.Collections;

public class Behaviors : MonoBehaviour {
	public float distanceToSee = 4f;
	public float forceAmount = 1000f;
	RaycastHit whatIHit;
	public bool haswoodLog = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.blue);
		//"out" will store variables into whatIHit
		if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
		{
			if(Input.GetKeyDown(KeyCode.Keypad0))
			{
				if(whatIHit.collider.name == "frontdoorleft")
				{
					//you can also check for false in haswoodLog using !
					if(haswoodLog)
					{
						//whatIHit.collider.gameObject.GetComponent<Animator>().SetTrigger("doorOpener");
						whatIHit.collider.gameObject.rigidbody.AddForce(transform.forward * forceAmount, ForceMode.Force);
						whatIHit.collider.gameObject.rigidbody.rigidbody.useGravity = true;
						//haswoodLog = false;
						Debug.Log("The door is now open");
					}
					else
					{
						Debug.Log ("Dam that " +whatIHit.collider.name + " is closed and the pad lock is rusted. I need something to open it");
					}
				}
				if(whatIHit.collider.name == "woodLog")
				{
					Debug.Log ("1" +whatIHit.collider.name + " collected");
					haswoodLog = true;
					Destroy(whatIHit.collider.gameObject);
				}
			}
		}
	}
}

//Post it

