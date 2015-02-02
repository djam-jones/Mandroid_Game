using UnityEngine;
using System.Collections;

public class LevelMove : MonoBehaviour {

	public float lvlSpeed = 0.002f;

	private FlappyController death;

	void Start()
	{
		death = GameObject.Find("DickButt").GetComponent<FlappyController> ();
	}

	void Update()
	{
		if(death != null)
		{
			if(death.deadd == false)
				transform.Translate (Vector3.left * lvlSpeed);
			else
				Time.timeScale = 0;
		}
	}
}
