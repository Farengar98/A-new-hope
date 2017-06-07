using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AsteroidController : MonoBehaviour
{
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
    public int Score = 0;
    public Text waveText;
    public Text scoreText;


    void Start()
    {
        Score = 0;
        StartCoroutine(SpawnAteroids());
        waveText.text = "WAVE: " + Wave;
        scoreText.text = "SCORE: " + Score;



    }

    void Update()
    {

        if (Wave == 4)
        {
            SceneManager.LoadScene(3);
        }

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
                scoreText.text = "SCORE: " + Score;
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