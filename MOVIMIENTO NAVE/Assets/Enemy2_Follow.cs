using UnityEngine;
using System.Collections;

public class Enemy2_Follow : MonoBehaviour {

    public float vel = 10f;
    // Use this for initialization
    void Awake()
    {
        transform.FollowPath("Enemy_2_Path", vel, Mr1.FollowType.Loop);

    }
}
