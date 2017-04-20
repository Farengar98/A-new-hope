using UnityEngine;
using System.Collections;

public class DestroyByArea : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "PLAYER") return;
        Destroy(other.gameObject);
    }

}
