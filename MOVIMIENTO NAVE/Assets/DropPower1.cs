using UnityEngine;
using System.Collections;

public class DropPower1 : MonoBehaviour {

    public GameObject powerUp;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        Destroy(gameObject);
        Destroy(other.gameObject);
        Instantiate(powerUp, transform.position, transform.rotation);

    }
}
