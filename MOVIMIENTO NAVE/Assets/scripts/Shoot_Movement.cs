using UnityEngine;
using System.Collections;

public class Shoot_Movement : MonoBehaviour {
    public GameObject shot;
    public GameObject Enemy;
    public float velocity;


	
	void Start () {
	
	}
	
	
	void Update ()
    {
        //shot.transform.position = new Vector2 (Enemy.transform.position.x - 8 , Enemy.transform.position.y);
        //GetComponent<Rigidbody2D>().velocity = new Vector2(-20, 0);
        transform.position = new Vector2(Enemy.transform.position.x - 8, Enemy.transform.position.y);
    }
}
