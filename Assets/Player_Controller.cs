using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {
	public Rigidbody body;
	public int force;

	// Use this for initialization
	void Start () {
	// foward

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			print ("space key was pressed");
			}
		if (Input.GetKey ("a")) { // foward
			print ("a key was pressed");
			body.GetComponent<Rigidbody>().AddForce(-force,0,0);
			
		}
		if (Input.GetKey ("w")) { // right

			print ("w key was pressed");
			body.GetComponent<Rigidbody>().AddForce(0,-(force/8),force);
			
		}
		if (Input.GetKey ("d")) {// down

			print ("d key was pressed");
			body.GetComponent<Rigidbody>().AddForce(force,0,0);
						
		}
		if (Input.GetKey ("s")) {// left

			print ("s key was pressed");
			body.GetComponent<Rigidbody>().AddForce(0,(force/8),-(force/2));
			
		}		
	}

		
	}
	

