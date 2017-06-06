using UnityEngine;
using System.Collections;

public class Basic_Movment1 : MonoBehaviour
{

    public float speed;

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

    private void Update()
    {
        if (gameObject.transform.position.x < -84)
        {
            rig.velocity = new Vector2(0, 0);
        }
          
          
    }

}