using UnityEngine;
using System.Collections;


public class ShootDestroy : MonoBehaviour
{
    public GameObject explosion;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LimitMap") return;
        if (other.tag == "ENEMY") return;
        if (other.tag == "Fondo") return;
        if (other.tag == "Bullet") return;
        if (other.tag == "PLAYER") return;
        if (other.tag == "Energy") return;
        if (other.tag == "Power1") return;
        if (other.tag == "Power2") return;
        Destroy(other.gameObject);
        Destroy(gameObject);
        Destroy(Instantiate(explosion, other.gameObject.transform.position, transform.rotation), 2);
    }

}
