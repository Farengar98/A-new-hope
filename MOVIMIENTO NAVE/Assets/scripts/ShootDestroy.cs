using UnityEngine;
using System.Collections;


public class ShootDestroy : MonoBehaviour
{
    public GameObject explosion;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LimitMap") return;
        else if (other.tag == "ENEMY") return;
        else if (other.tag == "Fondo") return;
        else if (other.tag == "Bullet") return;
        Destroy(other.gameObject);
        Destroy(gameObject);
        Destroy(Instantiate(explosion, other.gameObject.transform.position, transform.rotation), 2);
    }

}
