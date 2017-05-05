using UnityEngine;
using System.Collections;

public class Spawn_Shoot_Enemy : MonoBehaviour {

    [Header("Shooting")]
    public GameObject shot;    
    public GameObject Enemy;
    public float fireRate;
    public float fireLife;

    float posicionX;
    float posicionY;

    void Start()
    {
        StartCoroutine(ShootSpawn());


    }

    
   IEnumerator ShootSpawn () {
    
        while (true)
        {
            
            posicionX = (Enemy.transform.position.x);
            posicionY = (Enemy.transform.position.y);
            GameObject newShot = Instantiate(shot);
            newShot.transform.position = new Vector2(posicionX - 8, posicionY);
            newShot.GetComponent<Shoot_Movement>().Enemy = this.gameObject;
            yield return new WaitForSeconds(fireRate);
        } 
    }
}
