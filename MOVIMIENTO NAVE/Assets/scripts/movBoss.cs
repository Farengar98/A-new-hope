using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class movBoss : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D other){
		Destroy (other.gameObject);

		if (other.tag == "Disparo Player") {
			health--;
		}
	}

	public float amplitud = 2.0f;
	public float vel = 0.5f; 
	public float delay;
	private int nextAttack=0;
	private int health = 25;

	public GameObject disparo1Prefab;
	public GameObject disparo2Prefab;
	public GameObject disparo3Prefab;
	public GameObject disparo4Prefab;
    public GameObject benzina;

	private movBoss bounceObject; //for caching this transform

	private int TimeToNextAttack=3; 

	Vector2 startPosition; //used to cache the start position of the transform



	void Start(){

		InvokeRepeating("attack", delay, 3.0f);

		bounceObject = this;
		startPosition = bounceObject.transform.position;
	}


	void Update(){
		if (health < 0) {
            SceneManager.LoadScene(0);
            Destroy (this.gameObject);


		}
		bounceObject.transform.position = startPosition + Vector2.up * (amplitud * Mathf.Sin(Time.timeSinceLevelLoad * vel));
	}

	void attack()
	{
		switch (nextAttack) {
		case 0:
			Instantiate (disparo1Prefab);
			nextAttack++;
			break;
		case 1:
			Instantiate (disparo2Prefab);
            Instantiate(benzina);
            nextAttack++;
			break;
		case 2:
			Instantiate (disparo3Prefab);
			nextAttack++;
			break;
		case 3:
			Instantiate (disparo4Prefab);
            Instantiate(benzina);
            nextAttack = 0;
			break;

	}


		
	}
}

