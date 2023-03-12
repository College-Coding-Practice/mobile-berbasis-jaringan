using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public GameObject [] buah;
	public GameObject karakter;
	public Text Score;
	public int ScoreValue;

	// Use this for initialization
	void Start () {
		ScoreValue = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs(karakter.transform.position.x - buah[0].transform.position.x) <= 1 &&
			Mathf.Abs(karakter.transform.position.y - buah[0].transform.position.y) <= 1){
				ScoreValue = ScoreValue+1; 
				buah[0].transform.position = new Vector3(15,0,0);
				buah[0].SetActive(false);
		}
		if (Mathf.Abs(karakter.transform.position.x - buah[1].transform.position.x) <= 1 &&
			Mathf.Abs(karakter.transform.position.y - buah[1].transform.position.y) <= 1){
				ScoreValue = ScoreValue+1; 
				buah[1].transform.position = new Vector3(15,0,0);
				buah[1].SetActive(false);
		}
		if (Mathf.Abs(karakter.transform.position.x - buah[2].transform.position.x) <= 1 &&
			Mathf.Abs(karakter.transform.position.y - buah[2].transform.position.y) <= 1){
				ScoreValue = ScoreValue+1; 
				buah[2].transform.position = new Vector3(15,0,0);
				buah[2].SetActive(false);
		}
		Score.text = "Score: "+ ScoreValue;
	}
}
