using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject Asteorid;
    public Vector3 spawnValues;
    public int totalAsteoirds;
    public float spawnDelay;
	
	void Start ()
    {
           StartCoroutine( SpawnAteroids());         
        
 
	}
	
	IEnumerator SpawnAteroids()
    {
        for (int i = 0; i < totalAsteoirds; i++)
        {
            Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
            Instantiate(Asteorid, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
	  }
}
