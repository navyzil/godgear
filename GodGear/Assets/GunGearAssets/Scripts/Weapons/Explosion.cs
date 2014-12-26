using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	
	public float explosionTime = 1.0f;
	public float explosionRadius = 5.0f;
	public float explosionPower = 2000.0f;
	// Use this for initialization
	IEnumerator Start () {
		Destroy( gameObject, explosionTime );
		Collider[] colliders = Physics.OverlapSphere(transform.position,explosionRadius); 	
		foreach (Collider hit in colliders){
			if(hit.rigidbody){
				hit.rigidbody.AddExplosionForce(explosionPower,transform.position,explosionRadius);
			}
			if(particleEmitter){
				particleEmitter.emit = true;
				yield return new WaitForSeconds(0.5F);
				particleEmitter.emit = false;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
