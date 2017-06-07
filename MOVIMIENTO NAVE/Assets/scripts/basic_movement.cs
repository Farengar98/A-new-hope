using UnityEngine;
using System.Collections;

public class basic_movement : MonoBehaviour {

     public int speed;

    private Rigidbody2D rig;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        rig.velocity = new Vector2(-speed, 0);
    }
}
