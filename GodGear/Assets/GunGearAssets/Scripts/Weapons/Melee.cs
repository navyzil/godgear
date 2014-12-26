using UnityEngine;
using System.Collections;

public class Melee : MonoBehaviour{//,iProjectileMelee {
	public GameObject explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider collider){
		Debug.Log("Melee Colided");
		excuteCollision(collider);
	}
	public void excuteCollision(Collider collider){
		GameObject instantiatedExplosion = (GameObject)Instantiate(explosion,transform.position,transform.rotation);
	}
	
}
