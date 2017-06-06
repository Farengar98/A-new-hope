using UnityEngine;
using System.Collections;

public class DISPARANDO_ENEMIGO_4 : MonoBehaviour {

    public GameObject shot;
    public GameObject shotUp;
    public GameObject shotDown;
    public Transform shootSpawn;
    public Transform shotSpawnUp;
    public Transform shotSpawnDown;
    public float FireRate;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ShootSpawn());
    }

    // Update is called once per frame
    IEnumerator ShootSpawn()
    {
        while (true)
        {
            Instantiate(shot, shootSpawn.position, shootSpawn.rotation);
            Instantiate(shotUp, shotSpawnUp.position, shotSpawnUp.rotation);
            Instantiate(shotDown, shotSpawnDown.position, shotSpawnDown.rotation);

            yield return new WaitForSeconds(FireRate);
        }
    }
}
