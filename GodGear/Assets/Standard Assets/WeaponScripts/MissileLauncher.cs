using UnityEngine;
using System.Collections;

public class MissileLauncher : MonoBehaviour {
	
	public Rigidbody projectile;
	private float speed = 20;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		fireWeapon ();
	}

	void fireWeapon ()
	{
		if(Input.GetButtonDown("Fire1")){
			Rigidbody instantiatedProjectile = (Rigidbody)Instantiate(projectile,transform.position, transform.rotation);
			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,speed));
			Physics.IgnoreCollision(instantiatedProjectile.collider,transform.root.collider);
		}
	}
}
