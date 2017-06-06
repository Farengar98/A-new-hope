using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DestroyEnemy : MonoBehaviour
{
    private GameController gameController;
    public GameObject explosion;
    public GameObject ScoreMng;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LimitMap" || other.tag == "Fondo")return;
        Destroy(other.gameObject);
        
        Destroy(gameObject);
        Destroy(Instantiate(explosion, transform.position, transform.rotation), 2);
        //ScoreMng.GetComponent<GameController>().Score += 1;
        gameController.Score += 20;

        if (other.tag == "Bullet") return;
        Destroy(Instantiate(explosion, other.gameObject.transform.position, transform.rotation), 2);


    }

}
