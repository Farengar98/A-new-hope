using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public GameObject Asteorid;
    public GameObject AsteoridPowerUp;
    public Vector3 spawnValues;
    public int totalAsteoirds;
    public float spawnDelay;
    public float waitHorde;
    int counter = 0;
    public int spawnPowerUp;

    //UI PUNTUACION
    private int Wave = 0;
    public Text puntuacion;
	
	void Start ()
    {
           StartCoroutine( SpawnAteroids());
           puntuacion.text = "WAVE: " + Wave;


    }
	
	IEnumerator SpawnAteroids()
    {
        
            while (true)
            {

                for (int i = 0; i < totalAsteoirds; i++)
                {


                    Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                    Instantiate(Asteorid, spawnPosition, Quaternion.identity);
                    yield return new WaitForSeconds(spawnDelay);
                }

                yield return new WaitForSeconds(waitHorde);


                /*if (counter == spawnPowerUp)
                {
                    Asteorid.GetComponent<Renderer>().material.color = Color.red;
                    Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                    Instantiate(AsteoridPowerUp, spawnPosition, Quaternion.identity);

                }*/
                Wave++;
                puntuacion.text = "WAVE: " + Wave;

            }
        
        
	  }
}
