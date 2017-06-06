using UnityEngine;
using System.Collections;

public class DESTROY_ENEMY_3 : MonoBehaviour {

    private GameController gameController;
    public GameObject explosion;
    [Header("Transforms")]
    public Transform L;
    public Transform L_UP;
    public Transform UP;
    public Transform R_UP;
    public Transform R;
    public Transform R_DOWN;
    public Transform DOWN;
    public Transform L_DOWN;
    [Header("Shoots")]
    public GameObject D_L;
    public GameObject D_L_UP;
    public GameObject D_UP;
    public GameObject D_R_UP;
    public GameObject D_R;
    public GameObject D_R_DOWN;
    public GameObject D_DOWN;
    public GameObject D_L_DOWN;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet" || other.tag == "LimitMap") return;
        Destroy(other.gameObject);
        Destroy(gameObject);
        Instantiate(D_L, L.position, L.rotation);
        Instantiate(D_L_UP, L_UP.position, L_UP.rotation);
        Instantiate(D_UP, UP.position, UP.rotation);
        Instantiate(D_R_UP, R_UP.position, R_UP.rotation);
        Instantiate(D_R, R.position, R.rotation);
        Instantiate(D_R_DOWN, R_DOWN.position, R_DOWN.rotation);
        Instantiate(D_DOWN, DOWN.position, DOWN.rotation);
        Instantiate(D_L_DOWN, L_DOWN.position, L_DOWN.rotation);
        Destroy(Instantiate(explosion, transform.position, transform.rotation), 2);
        //ScoreMng.GetComponent<GameController>().Score += 1;
        gameController.Score += 20;

    }
}
