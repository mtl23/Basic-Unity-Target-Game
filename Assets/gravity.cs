using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {
	public Rigidbody body;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		body.velocity = new Vector3 (0, -105, 0);
	}
}
