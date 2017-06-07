using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    [Header("ENEMIGOS")]
    public GameObject Asteorid;
    public GameObject AsteoridPowerUp;
    public GameObject player;
    public Vector3 spawnValues;
    public GameObject Enemigo1;
    public GameObject Enemigo2;
    public GameObject Enemigo3;
    public GameObject Enemigo4;
    [Header("Spawn control")]
    public int totalAsteoirds;
    public float spawnDelay;
    public float waitHorde;
    int counter = 0;
    public int spawnPowerUp;

    //UI PUNTUACION
    [Header("SCORE")]
    private int Wave = 0;
    public int Score = 0;
    public Text waveText;
    public Text scoreText;
    public int enemyTurn = 0;


    void Start ()
    {
        Score = 0;
           StartCoroutine( SpawnAteroids());
           waveText.text = "WAVE: " + Wave;
           scoreText.text = "SCORE: " + Score;



    }

    void Update()
    {
            if (player == null)
            {
                SceneManager.LoadScene(0);
            }

        if (Wave == 4)
        {
            SceneManager.LoadScene(3);
        }

    }

    IEnumerator SpawnAteroids()
    {

        while (true)
        {

            for (int i = 0; i < 4; i++)
            {

                if (i == 0)
                {
                    Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                    Instantiate(Enemigo1, spawnPosition, Quaternion.identity);
                }
                else if (i == 1)
                {
                    Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                    Instantiate(Enemigo2, spawnPosition, Quaternion.identity);
                }
                else if (i == 2)
                {
                    Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                    Instantiate(Enemigo3, spawnPosition, Quaternion.identity);
                }
                else if (i == 4)
                {
                    Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                    Instantiate(Enemigo3, spawnPosition, Quaternion.identity);
                }
                yield return new WaitForSeconds(spawnDelay);

            }
            scoreText.text = "SCORE: " + Score;
            yield return new WaitForSeconds(waitHorde);
        

                /*if (counter == spawnPowerUp)
                {
                    Asteorid.GetComponent<Renderer>().material.color = Color.red;
                    Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                    Instantiate(AsteoridPowerUp, spawnPosition, Quaternion.identity);

                }*/
                Wave++;
                waveText.text = "WAVE: " + Wave;
                scoreText.text = "SCORE: " + Score;

        }
        
        
	  }
}
