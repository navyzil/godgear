using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	private float moveSpeed = 1F;
	private float sensitivity = 5F;
	private float mouseLook;
	// Use this for initialization
	void Start () {
		moveSpeed = moveSpeed*Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		basicMovements ();
		characterRotation ();
			
	}

	private void basicMovements ()
	{
		if(Input.GetKey(KeyCode.A)){
			transform.Translate(new Vector3(-moveSpeed,0,0),Space.Self);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(new Vector3(moveSpeed,0,0),Space.Self);
		}
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(new Vector3(0,0,moveSpeed),Space.Self);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(new Vector3(0,0,-moveSpeed),Space.Self);
		}
	}

	private void characterRotation ()
	{
		mouseLook = sensitivity*Input.GetAxis("Mouse X");
		transform.Rotate(new Vector3(0,mouseLook,0),Space.World);
	}
}
