using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseClick : MonoBehaviour
{
	public GameObject pauseMenu;
	public static bool gameIsPaused = false;

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
		if (!gameIsPaused)
		{
			pauseMenu.SetActive(true);
			gameIsPaused = true;
			Time.timeScale = 0f;
			Debug.Log("PAUSED");
		}

		else
		{
			pauseMenu.SetActive(false);
			gameIsPaused = false;
			Time.timeScale = 1f;
			Debug.Log("Play");
		}
	}

	


}
