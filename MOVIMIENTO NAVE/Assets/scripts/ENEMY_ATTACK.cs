using UnityEngine;
using System.Collections;

public class ENEMY_ATTACK : MonoBehaviour {

    //CONTROL DEL DISPARO
    [Header("Shooting")]
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire ;
    
    

    // Use this for initialization
    void Start ()
    {
        //StartCoroutine(shootSpawn());	
	}

    // Update is called once per frame
    //IEnumerator shootSpawn () {
    void Update()
    {
        
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
          
    }
        
    }

