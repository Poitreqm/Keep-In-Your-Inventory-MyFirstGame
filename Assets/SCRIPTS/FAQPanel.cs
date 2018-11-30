using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAQPanel : MonoBehaviour
{
	public GameObject faqPanel;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnMouseDown()
	{
		faqPanel.SetActive(true);
	}
}
