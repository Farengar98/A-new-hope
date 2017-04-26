using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject Asteorid;
    public GameObject AsteoridPowerUp;
    public Vector3 spawnValues;
    public int totalAsteoirds;
    public float spawnDelay;
    public float waitHorde;
    int counter = 0;
    public int spawnPowerUp;
    private int Wave = 0;
	
	void Start ()
    {
           StartCoroutine( SpawnAteroids());         
        
 
	}
	
	IEnumerator SpawnAteroids()
    {
        while (true)
        {
            print("Wave: "+ Wave);


            for (int i = 0; i < totalAsteoirds; i++)
            {
                
                //Asteorid.GetComponent<Renderer>().material.color = Color.red;
                Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Instantiate(Asteorid, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnDelay);
            }
            Wave++;
            yield return new WaitForSeconds(waitHorde);

            
            if (counter == spawnPowerUp)
            {
                Asteorid.GetComponent<Renderer>().material.color = Color.red;
                Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Instantiate(AsteoridPowerUp, spawnPosition, Quaternion.identity);

            }

            counter++;
        }
        
	  }
}
