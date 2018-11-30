using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPlay : MonoBehaviour
{
	public GameObject pauseMenu;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OnMouseDown()
	{
		pauseMenu.SetActive(false);
		PauseClick.gameIsPaused = false;
		Time.timeScale = 1f;
		Debug.Log("PAUSED");
	}
}
