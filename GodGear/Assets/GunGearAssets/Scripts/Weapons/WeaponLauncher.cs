using UnityEngine;
using System.Collections;

public class WeaponLauncher : MonoBehaviour,iWeaponLauncher {
	
	public Rigidbody projectile;
	public float speed = 20f;
	public bool isMelee = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!isMelee){
			weaponFire("Fire1");
		}
		else{
			meleeAttack("Fire1");
		}
		
	}
	
	public void weaponFire(string buttonName){
		if(Input.GetButtonDown(buttonName)){
			Rigidbody instantiatedProjectile = (Rigidbody)Instantiate(projectile,transform.position,transform.rotation);
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3( 0, 0, speed ) );
			Physics.IgnoreCollision(instantiatedProjectile.collider,transform.root.collider);
		}
	}
	
	public void meleeAttack(string buttonName){
		Debug.Log ("perform melee attack");

		if(Input.GetButtonDown(buttonName)){	
			transform.FindChild("arm").Rotate(new Vector3(60F,0,0),Space.Self);
		}
		if(Input.GetButtonUp(buttonName)){
			transform.FindChild("arm").Rotate(new Vector3(-60F,0,0),Space.Self);
		}
	}
}
