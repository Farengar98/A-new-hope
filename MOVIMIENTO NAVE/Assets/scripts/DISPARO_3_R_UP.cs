using UnityEngine;
using System.Collections;

public class DISPARO_3_R_UP : MonoBehaviour {

    public float speed;

    private Rigidbody2D rig;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        rig.velocity = new Vector2(speed, speed);
    }

}
