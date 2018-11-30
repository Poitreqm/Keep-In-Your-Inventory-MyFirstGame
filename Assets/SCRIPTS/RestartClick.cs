using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartClick : MonoBehaviour
{
	
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
		Physics2D.gravity = new Vector2(0f, -1f);
		Physics2D.IgnoreLayerCollision(8, 9, false);
		//HeroController.Score = 5;
		//SceneManager.LoadScene(1);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		PauseClick.gameIsPaused = false;
		Time.timeScale = 1f;
	}
}
