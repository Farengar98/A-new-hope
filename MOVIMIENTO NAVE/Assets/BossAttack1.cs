using UnityEngine;
using System.Collections;

public class BossAttack1 : MonoBehaviour {


	private float timeAlive = 0.5f;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "BOSS")return;
		Destroy (other.gameObject);
		}

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 0.5f);
	}


	void Update () {
	}


}
