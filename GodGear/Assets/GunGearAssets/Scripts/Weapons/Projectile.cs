using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour,iProjectileMelee {
	public GameObject explosion;
	
	// Use this for initialization
	void Start () {
		destroyWasteProjectile(0.5F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision){
		explodeOnCollision(collision);
	}
	
	public void explodeOnCollision(Collision collision){
		ContactPoint contact = collision.contacts[0];
		Quaternion rotation = Quaternion.FromToRotation(Vector3.up,contact.normal);
		GameObject instantiatedExplosion = (GameObject)Instantiate(explosion,contact.point,rotation);
		Destroy(gameObject);
	} 
	public IEnumerator destroyWasteProjectile(float idleTime){
		yield return new WaitForSeconds(idleTime); //if the projectile doesn't hit anything
		Destroy(gameObject);
	}
		
}
