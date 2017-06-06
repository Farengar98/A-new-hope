using UnityEngine;
using System.Collections;

public class Enemy1_Follow : MonoBehaviour {
    public float vel = 10f;
	// Use this for initialization
	void Awake () {
        transform.FollowPath("Enemy_1_Path",vel,Mr1.FollowType.Loop);
	
	}
}
