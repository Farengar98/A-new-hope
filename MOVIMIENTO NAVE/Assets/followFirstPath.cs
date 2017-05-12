using UnityEngine;
using System.Collections;

public class followFirstPath : MonoBehaviour {

	public float vel = 20f;
	public string nameOfPath = "First 1";

	// Use this for initialization
	void Awake()
	{
		transform.FollowPath (nameOfPath, vel, Mr1.FollowType.PingPong);
	}
}
