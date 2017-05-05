using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DestroyEnemy : MonoBehaviour
{
    
    public GameObject explosion;
    public GameObject ScoreMng;

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet" || other.tag == "LimitMap") return;
        Destroy(other.gameObject);
        Destroy(gameObject);
        Destroy(Instantiate(explosion, transform.position, transform.rotation), 2);
        ScoreMng.GetComponent<GameController>().Score += 1;


    }

}
