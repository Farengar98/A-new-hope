using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PLAYER_CONTROL : MonoBehaviour
{
    //CONTROL TECLAS APRETADAS

    bool buttonPressed;

    bool UpPressed = false;
    bool DownPressed = false;
    bool LeftPressed = false;
    bool RightPressed = false;
    //VELOCIDAD MOVIMIENTO
    [Header("Movement")]
    public float GoUp = 40;
    public float GoDown = -40;
    public float GoLeft = -40;
    public float GoRigh = 40;
    public GameObject PLAYER;
    public float limiteX;
    public float limiteY;
    public float Dash;
    public GameObject flash;

    //VELOCIDAD BOOST
    public float BoostUp = 40;
    public float BoostDown = -40;
    public float BoostLeft = -40;
    public float BoostRigh = 40;


    float posicionX;
    float posicionY;

    //FRENADA
    float UpBreak = 20;
    float DownBreak = -20;
    float LeftBreak = -20;
    float RightBreak = 20;



    //CONTROL DEL DISPARO
    [Header("Shooting")]
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    //BENZINA
    [Header("Benzina")]
    [SerializeField]
    private Image healthBarImg;




    // Use this for initialization
    void Start()
    {
        InvokeRepeating("restarBez", 3.0f, 0.3f);
    }

    void restarBez()
    {
        healthBarImg.fillAmount -= 0.015f;
        if(healthBarImg.fillAmount <= 0)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
       
       

        buttonPressed = false;

        posicionX = (PLAYER.transform.position.x);
        posicionY = (PLAYER.transform.position.y);

        if (posicionX > limiteX)
        {
            PLAYER.transform.position = new Vector3(limiteX, PLAYER.transform.position.y, PLAYER.transform.position.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);

        }

        else if (posicionX < -limiteX)
        {
            PLAYER.transform.position = new Vector3(-limiteX, PLAYER.transform.position.y, PLAYER.transform.position.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);

        }

        if (posicionY > limiteY)
        {
            PLAYER.transform.position = new Vector3(PLAYER.transform.position.x, limiteY, PLAYER.transform.position.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);

        }

        else if (posicionY < -limiteY)
        {
            PLAYER.transform.position = new Vector3(PLAYER.transform.position.x, -limiteY, PLAYER.transform.position.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
        }

        //NORTE, SUD, ESTE y OESTE


        //NORTE
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, GoUp) * Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.y > GoUp)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GoUp);
            }
            buttonPressed = true;

            UpPressed = true;
            DownPressed = false;
            LeftPressed = false;
            RightPressed = false;
        }

        //OESTE
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(GoLeft, 0) * Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.x < GoLeft)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GoLeft, GetComponent<Rigidbody2D>().velocity.y);
            }

            buttonPressed = true;

            UpPressed = false;
            DownPressed = false;
            LeftPressed = true;
            RightPressed = false;
        }

        //SUD
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, GoDown) * Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.y < GoDown)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GoDown);
            }


            buttonPressed = true;

            UpPressed = false;
            DownPressed = true;
            LeftPressed = false;
            RightPressed = false;
        }

        //ESTE
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(GoRigh, 0) * Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.x > GoRigh)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GoRigh, GetComponent<Rigidbody2D>().velocity.y);
            }

            buttonPressed = true;

            UpPressed = false;
            DownPressed = false;
            LeftPressed = false;
            RightPressed = true;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
 
            Destroy(Instantiate(flash, transform.position, transform.rotation), 1);
            PLAYER.transform.position = new Vector2(PLAYER.transform.position.x + ((Dash / 40) * GetComponent<Rigidbody2D>().velocity.x), PLAYER.transform.position.y + ((Dash / 40) * GetComponent<Rigidbody2D>().velocity.y));
            Destroy(Instantiate(flash, transform.position, transform.rotation), 1);
             
            
        }
 


        

            //FRENAR
            if (!buttonPressed)
        {
            // NORTE, SUD, ESTE Y OESTE

            //NORTE
            if (UpPressed == true && DownPressed == false && LeftPressed == false && RightPressed == false)
            {
                GetComponent<Rigidbody2D>().velocity -= new Vector2(0, DownBreak) * Time.deltaTime;


                if (UpBreak <= 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    UpBreak = 40;

                }
            }

            //OESTE
            if (UpPressed == false && DownPressed == false && LeftPressed == true && RightPressed == false)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(LeftBreak, 0);
                LeftBreak += 1;
                if (LeftBreak >= 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    LeftBreak = 10;
                }
            }

            //SUD
            if (UpPressed == false && DownPressed == true && LeftPressed == false && RightPressed == false)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, DownBreak);
                DownBreak += 1;
                if (DownBreak >= 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    DownBreak = -10;
                }
            }

            //ESTE
            if (UpPressed == false && DownPressed == false && LeftPressed == false && RightPressed == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(RightBreak, 0);
                RightBreak -= 1;
                if (RightBreak <= 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    RightBreak = -10;
                }
            }


            //FRENAR MOVIMIENTOS EN DIAGONAL

            //NORTE-ESTE
            if (UpPressed == true && DownPressed == false && LeftPressed == false && RightPressed == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(RightBreak, UpBreak);
                RightBreak -= 1;
                UpBreak -= 1;
                if (UpBreak <= 0 || RightBreak <= 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    UpBreak = 10;
                    RightBreak = -10;
                }
            }

            //NORTE-OESTE
            if (UpPressed == true && DownPressed == false && LeftPressed == true && RightPressed == false)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(LeftBreak, UpBreak);
                UpBreak -= 1;
                LeftBreak += 1;
                if (UpBreak <= 0 || LeftBreak >= 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    UpBreak = 10;
                    LeftBreak = 10;
                }
            }

            //SUD-OESTE
            if (UpPressed == false && DownPressed == true && LeftPressed == true && RightPressed == false)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(LeftBreak, DownBreak);
                DownBreak += 1;
                LeftBreak += 1;
                if (DownBreak >= 0 || LeftBreak >= 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    DownBreak = -10;
                    LeftBreak = 10;
                }
            }

            //SUD-ESTE
            if (UpPressed == false && DownPressed == true && LeftPressed == false && RightPressed == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(RightBreak, DownBreak);
                DownBreak += 1;
                RightBreak -= 1;
                if (DownBreak >= 0 || RightBreak <= 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    DownBreak = -10;
                    RightBreak = -10;
                }
            }

            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
        }




        //DISPARO
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }

    }
}
