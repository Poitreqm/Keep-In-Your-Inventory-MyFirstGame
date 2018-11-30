using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreator : MonoBehaviour
{

    public GameObject Axe;
    public GameObject Apple;
	public GameObject Meat;
	public GameObject ShieldPotion;
	public GameObject SpeedPotion;
	public GameObject GravityScroll;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(AxeCreator());
        StartCoroutine(AppleCreator());
		StartCoroutine(MeatCreator());
		StartCoroutine(SpeedPotionCreator());
        StartCoroutine(ShieldPotionCreator());
		StartCoroutine(GravityScrollCreator());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator AxeCreator()
    {
        while (true)
        {
			Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0 + 15, Screen.width - 15), Random.Range(Screen.height - 15, Screen.height - 15))); //Camera.main.farClipPlane / 2)
			Instantiate(Axe, position, Quaternion.identity);
            yield return new WaitForSeconds(0.7f);
            
        }
    }

    IEnumerator AppleCreator()
    {
        while(true)
        {
			Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0 + 15, Screen.width - 15), Random.Range(Screen.height - 15, Screen.height - 15))); //Camera.main.farClipPlane / 2)
			Instantiate(Apple, position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }


    IEnumerator ShieldPotionCreator()
    {
        while (true)
        {
			Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0 + 15, Screen.width - 15), Random.Range(Screen.height - 15, Screen.height - 15))); //Camera.main.farClipPlane / 2)
			Instantiate(ShieldPotion, position, Quaternion.identity);
            yield return new WaitForSeconds(12f);
        }
    }

	IEnumerator SpeedPotionCreator()
	{
		while(true)
		{
			Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0 + 15, Screen.width - 15), Random.Range(Screen.height - 15, Screen.height - 15))); //Camera.main.farClipPlane / 2)
			Instantiate(SpeedPotion, position, Quaternion.identity);
			yield return new WaitForSeconds(7f);
		}
	}

	IEnumerator MeatCreator()
	{
		{
			while(true)
			{
				Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0 + 15, Screen.width - 15), Random.Range(Screen.height - 15, Screen.height - 15))); //Camera.main.farClipPlane / 2)
				Instantiate(Meat, position, Quaternion.identity);
				yield return new WaitForSeconds(4f);
			}
		}
	}

	IEnumerator GravityScrollCreator()
	{
		while(true)
		{
			Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0 + 15, Screen.width - 15), Random.Range(Screen.height - 15, Screen.height - 15)));
			Instantiate(GravityScroll, position, Quaternion.identity);
			yield return new WaitForSeconds(15f);
		}
	}
}
