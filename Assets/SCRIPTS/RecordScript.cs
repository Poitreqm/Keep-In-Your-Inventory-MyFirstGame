using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordScript : MonoBehaviour
{
	public int score;
	public int record = 5;
	public Text txt;
	// Use this for initialization
	void Start ()
	{
		txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		score = HeroController.Score;
		if (score > record)
		{
			PlayerPrefs.SetInt("record", score);
			PlayerPrefs.Save();

		}

		record = PlayerPrefs.GetInt("record");
		txt.text = record.ToString();
	}
}
