using UnityEngine;
using System.Collections;

public class ENEMIGO_DISPARANDO : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float FireRate;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(ShootSpawn());
	}
	
	// Update is called once per frame
	IEnumerator ShootSpawn() {
        while (true)
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            yield return new WaitForSeconds(FireRate);
        }
    }
}
