using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public Text score;
	public Text statetxt;

	public int scoreValue = 0;
	public string state = "NormalFlap";

	public GameObject helmet;
	public GameObject schwarz;
	public GameObject intervention;
	public GameObject glasses;
	public GameObject spliff;

	public ParticleSystem money;

	public bool hitmarks = false;

	void Awake()
	{
		money = GetComponent<ParticleSystem> ();
	}

	void Update()
	{
		score.text = "Score : " + scoreValue.ToString ("F0");
		statetxt.text = "State : " + state;

		if (scoreValue >= 5)
		{
			state = "HelmetFlap";
			helmet.SetActive(true);
		}
		if (scoreValue >= 10)
		{
			state = "SchwarzFlap";
			schwarz.SetActive(true);
		}
		if (scoreValue >= 15)
		{
			state = "SniperFlap";
			intervention.SetActive(true);
		}
		if (scoreValue >= 20)
		{
			state = "CoolFlap";
			glasses.SetActive(true);
		}
		if (scoreValue >= 25)
		{
			state = "SpliffFlap";
			spliff.SetActive(true);
		}
		if (scoreValue >= 30)
		{
			state = "MoneyFlap";
			money.emissionRate = 10;
		}
		if (scoreValue >= 35)
		{
			state = "wat";
			hitmarks = true;
		}
	}
}
