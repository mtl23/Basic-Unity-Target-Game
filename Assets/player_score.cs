using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player_score : MonoBehaviour {

	Text txt;
	void Start () {
		txt = gameObject.GetComponent<Text>(); 

	}

	void Update () {

		if(Data.P1_score <=0)
		txt.text=" TIME " + Data.minutes + ":" + Data.seconds;
		else{
			txt.text="SCORE : " + Data.P1_score + " TIME " + Data.minutes + ":" + Data.seconds; 
			}
		}
}
