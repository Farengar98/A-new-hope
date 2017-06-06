using UnityEngine;
using System.Collections;

public class DestroyByArea1 : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D other)
    {
        
        if (other.tag == "noDestruir") return;
        if (other.tag == "LimitMap") return;
        
        Destroy(other.gameObject);

    }

}
