﻿using UnityEngine;
using System.Collections;

public class DestroyByArea : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "PLAYER") return;
        if (other.tag == "noDestruir") return;
        if (other.tag == "Fondo") return;
        if (other.tag == "Energy") return;
        if (other.tag == "Power1") return;

        Destroy(other.gameObject);

    }

}
