using UnityEngine;
using System.Collections;


public class DestroyEnemy : MonoBehaviour
{
    
    public GameObject explosion;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet" || other.tag == "LimitMap") return;
        Destroy(other.gameObject);
        Destroy(gameObject);
        Destroy(Instantiate(explosion, transform.position, transform.rotation), 2);
        
        
    }

}
