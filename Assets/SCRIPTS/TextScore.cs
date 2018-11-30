using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScore : MonoBehaviour
{

	public Text txt;
	// Use this for initialization
	void Start ()
	{
		txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		txt.text = HeroController.Score.ToString();

	}
}
