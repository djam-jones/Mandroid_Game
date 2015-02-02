using UnityEngine;
using System.Collections;

public class FlappyController : MonoBehaviour {

	private ScoreController score;

	private Vector2 force = new Vector2( 0,100);
	
	public GameObject deathPlayer;
	public AudioSource hitmark;

	public GameObject death;
	public GameObject start;

	public bool deadd = false;


	void Awake()
	{
		score = GetComponent<ScoreController> ();
		start = GameObject.Find ("BackGround");
		death = GameObject.Find ("Death");
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			rigidbody2D.AddForce(force,0);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Walls")
		{
			start.gameObject.SetActive(false);
			death.GetComponent<AudioSource>().Play();
			Destroy(GameObject.Find ("DickButt"));
			deadd = true;
			Instantiate(deathPlayer, this.transform.position, this.transform.rotation);
		}
	}

	void OnTriggerEnter2D(Collider2D scores)
	{
		if(scores.gameObject.tag == "ScoreAdd")
		{
			score.scoreValue += 10;
			if (score.hitmarks == true)
				audio.Play();
		}
	}
}
