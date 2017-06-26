using UnityEngine;
using System.Collections;


/*
1.Collision dectection with the shpere and 2.adjust the points value
 */

public class Get50 : MonoBehaviour {
	
	
	//public GameObject player;
	
	void OnCollisionEnter(Collision collision) {
		
		if (collision.gameObject.name  == "BALL") {
			
			Debug.Log ("Hit the target 50");
			Data.P1_score +=50;
			
		}
	}
	
}
