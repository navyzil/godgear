using UnityEngine;
using System.Collections;

public class PlayerWeapons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		selectWeapon(0);
	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetButton("Fire1")){
//			BroadcastMessage("Fire");
//		}
		if (Input.GetKeyDown("1")){
			  selectWeapon(0);
		}    
		else if (Input.GetKeyDown("2")){
			  selectWeapon(1);
		}
		else if (Input.GetKeyDown("3")){
			selectWeapon(2);
		}
	}
	
	private void selectWeapon(int weaponIndex) 
	{
	 for (int i=0;i<transform.childCount;i++)
	  {
			//Debug.Log(transform.GetChild(i).transform.GetChild(0).n);
	  // Activate the selected weapon
		  if (i == weaponIndex){
		  	 transform.GetChild(i).gameObject.SetActiveRecursively(true);
			//transform.GetChild(i).FindChild("Launcher").gameObject.SetActiveRecursively(true);
		  }
		  // Deactivate all other weapons
		  else{
		   transform.GetChild(i).gameObject.SetActiveRecursively(false);
		 }
	  }
	}
}
