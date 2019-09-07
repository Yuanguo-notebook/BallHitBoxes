using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	public BoxController boxController;


	public int row;
	public int col;
	public int power = 5;

	// Use this for initialization
	void Start () {
		boxController = new BoxController ();
		boxController.generate (row, col);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit)){
				ball (hit.point);
			}
		}
	}

	void ball(Vector3 vec){
		GameObject ball = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		ball.transform.position = Camera.main.transform.position;
		ball.AddComponent<BoxCollider> ();
		Rigidbody rb = ball.AddComponent<Rigidbody> ();
		rb.AddForce (power*(vec - ball.transform.position), ForceMode.Impulse); 
	}
		
}








































