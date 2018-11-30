using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HeroController : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{


    protected Joystick joystick;

    public static int Score = 5;
    public float moveSpeed = 12f;

	// Use this for initialization
	void Start ()
    {
		
		Score = 5;
        joystick = FindObjectOfType<Joystick>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Score < 0)
		{

			ReloadLevel();
		}

		{

			var rigidbody = GetComponent<Rigidbody2D>();
			rigidbody.velocity = new Vector3(joystick.Horizontal * moveSpeed, joystick.Vertical * moveSpeed);
		}


	}



    public void OnCollisionEnter2D(Collision2D collision)
    {


		if (collision.gameObject.tag == "Axe")
		{
			if (Score > 15)
			{
				Destroy(collision.gameObject);
				Score = Score - 4;
			}
			else if (Score > 30)
			{
				Destroy(collision.gameObject);
				Score = Score - 5;
			}
			else
			{
				Destroy(collision.gameObject);
				Score = Score - 3;

			}

        }

		if (collision.gameObject.tag == "Apple")
		{
			Destroy(collision.gameObject);
			Score++;
		}
		if (collision.gameObject.tag == "Meat")
		{
			Destroy(collision.gameObject);
			Score = Score + 2;
		}


		if (collision.gameObject.tag == "ShieldPotion")
		{
			StartCoroutine(ShieldPotionSkill());
			Destroy(collision.gameObject);

		}

		if (collision.gameObject.tag == "GravityScroll")
		{

			StartCoroutine(GravityScrollSkill());
			Destroy(collision.gameObject);
		}

		if(collision.gameObject.tag == "SpeedPotion")
		{
			StartCoroutine(SpeedPotionSkill());
			Destroy(collision.gameObject);
		}

		else
		{

		}
	}

    public void ReloadLevel() // перезагрузка сцены в случае смерти
    {
		Physics2D.gravity = new Vector2(0f, -1f);
		Physics2D.IgnoreLayerCollision(8, 9, false); // слои персонажа и топоров*
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}



	IEnumerator GravityScrollSkill()
	{
		Physics2D.gravity = new Vector2(0f, -0.3f);
		yield return new WaitForSeconds(7f);
		Physics2D.gravity = new Vector2(0f, -1f);
	}

	IEnumerator ShieldPotionSkill()
	{
		this.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
		Physics2D.IgnoreLayerCollision(8, 9, true);
		yield return new WaitForSeconds(5f);
		Physics2D.IgnoreLayerCollision(8, 9, false);
		this.gameObject.GetComponent<Renderer>().material.color = Color.white;
	}


	IEnumerator SpeedPotionSkill()
	{
		this.gameObject.GetComponent<Renderer>().material.color = Color.red;
		moveSpeed = 17;
		yield return new WaitForSeconds(6f);
		moveSpeed = 12;
		this.gameObject.GetComponent<Renderer>().material.color = Color.white;
	}


	public virtual void OnDrag(PointerEventData eventData)
	{

	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{

	}

	public virtual void OnPointerUp(PointerEventData eventData)
	{

	}
}
