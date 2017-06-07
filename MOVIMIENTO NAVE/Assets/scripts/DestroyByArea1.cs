using UnityEngine;
using System.Collections;

public class DestroyByArea1 : MonoBehaviour {

    public GameObject destructor;
    public GameObject explosion;

    float coorX;
    float coorY;

    public void Start()
    {
        Physics2D.IgnoreCollision(destructor.GetComponent<EdgeCollider2D>(), GetComponent<EdgeCollider2D>());
    }


    void OnTriggerEnter2D (Collider2D other)
    {

        Physics2D.IgnoreCollision(destructor.GetComponent<EdgeCollider2D>(), GetComponent<EdgeCollider2D>());
        if (other.tag == "noDestruir") return;
        if (other.tag == "LimitMap") return;
        if (other.tag == "Energy") return;
        if (other.tag == "Power1") return;
        if (other.tag == "Power2") return;
//<<<<<<< HEAD
        if (other.tag == "ENEMY") return;
//=======
//>>>>>>> master


        coorX = (other.gameObject.transform.position.x);
        coorY = (other.gameObject.transform.position.y);

        if (other.tag == "Bullet" || other.tag == "Disparo Player")
        {
            Destroy(other.gameObject);
            return;
        }
        
        Destroy(other.gameObject);

        //explosion.transform.position = new Vector2(coorX, coorY);

        Destroy(Instantiate(explosion, other.gameObject.transform.position, transform.rotation), 2);

    }



}
