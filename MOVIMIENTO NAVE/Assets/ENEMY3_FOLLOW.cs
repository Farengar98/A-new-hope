using UnityEngine;
using System.Collections;

public class ENEMY3_FOLLOW : MonoBehaviour {

    public float vel = 10f;
    // Use this for initialization
    void Awake()
    {
        transform.FollowPath("Enemy_3_Path", vel, Mr1.FollowType.Loop);

    }
}
