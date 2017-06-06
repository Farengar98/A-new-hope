using UnityEngine;
using System.Collections;

public class movimentTest : MonoBehaviour {


    public float currentPosX;
    public float currentPosY;


	// Use this for initialization
	void Start () {
        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        currentPosX -= 0.1f;
      this.transform.position = new Vector2(currentPosX, currentPosY);
		/*
        if(this.transform.position.x < -200)
        {
            Destroy(this.gameObject);
        }
        */
	}
}
