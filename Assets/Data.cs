using UnityEngine;
using System.Collections;

public class Data : MonoBehaviour {

	public GameObject player;
	public static int P1_score;
	public float ptime;
	public static int minutes;
	public static int seconds;
	Vector3 start = new Vector3(0,-1200f,60f);
	void Start () {

		Data.P1_score =0;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (ptime >= 0) {
			ptime -= Time.deltaTime;
			Data.minutes = Mathf.FloorToInt (ptime / 60F);
			Data.seconds = Mathf.FloorToInt (ptime - Data.minutes * 60);
						}// TIMES UP	
		else if(ptime <0)
		{
			Respawn();
		}
					}//end Update


void Respawn(){
	
		ptime = 25;
		transform.position = start;
			  }

								}// end Data














