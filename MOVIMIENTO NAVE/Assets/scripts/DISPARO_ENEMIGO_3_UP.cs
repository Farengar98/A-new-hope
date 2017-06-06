using UnityEngine;
using System.Collections;

public class DISPARO_ENEMIGO_3_UP : MonoBehaviour {

    public float speed;

    private Rigidbody2D rig;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        rig.velocity = new Vector2(0, speed);
    }

}
