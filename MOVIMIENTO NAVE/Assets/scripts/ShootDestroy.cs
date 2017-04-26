using UnityEngine;
using System.Collections;


public class ShootDestroy : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LimitMap") return;
        else if (other.tag == "ENEMY") return;
        Destroy(other.gameObject);        
    }

}
