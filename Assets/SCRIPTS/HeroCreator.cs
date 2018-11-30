using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroCreator : MonoBehaviour
{
    public GameObject Character;

	// Use this for initialization
	void Start ()
    {
		Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3((0 + Camera.main.pixelWidth) / 2, (0 + Camera.main.pixelHeight) / 2, 0)); //Camera.main.farClipPlane / 2)
		Instantiate(Character, position, Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}
}
