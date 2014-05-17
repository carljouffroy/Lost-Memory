using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public bool openInventory = false;
	public static bool hasLoungeKey;
	public Texture invBackground, kitchenKeyIcon, bathroomKeyIcon;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.I))
		{
			openInventory = !openInventory;
		}
	}

	void OnGUI()
	{
		if (openInventory) 
		{
			GUI.BeginGroup (new Rect (Screen.width / 2 - invBackground.width / 2, Screen.height / 2 - invBackground.height / 2, invBackground.width, invBackground.height));
			GUI.DrawTexture (new Rect(0, 0, invBackground.width, invBackground.height), invBackground);
			if (Inventory.hasLoungeKey) 
			{
				GUI.DrawTexture (new Rect(10, 10, kitchenKeyIcon.width, kitchenKeyIcon.height), kitchenKeyIcon);
			}
			GUI.EndGroup();
		}
	}
}
