using UnityEngine;
using System.Collections;

public class PlayerInteractions : MonoBehaviour {

	float interactDistance = 3f;
	RaycastHit whatITouched;

	void Start()
	{
		//Screen.lockCursor = true;
	}

	void Update () 
	{
		if (Physics.Raycast (transform.position, transform.forward, out whatITouched, interactDistance)) 
		{
			if(Input.GetKeyDown(KeyCode.E))
			{
				#region Kitchen Room
				if(whatITouched.collider.name == "Painting")
				{
					//Narration is fired here
				}
				if(whatITouched.collider.name == "Book")
				{
					//What do you want to do here?
				}
				#endregion

				if(whatITouched.collider.name == "Key")
				{
					Inventory.hasLoungeKey = true;
					Destroy (whatITouched.collider.gameObject);
				}
				if(whatITouched.collider.name == "Door")
				{
					if(Inventory.hasLoungeKey == true)
					{
						whatITouched.collider.gameObject.GetComponent<Animator>().SetBool("KitchenDoorOpen", true);
						Inventory.hasLoungeKey = false;
					}
				}
			}
		}
	}
}
