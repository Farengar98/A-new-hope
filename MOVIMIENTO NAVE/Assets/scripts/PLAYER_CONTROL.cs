using UnityEngine;
using System.Collections;

public class PLAYER_CONTROL : MonoBehaviour {
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
    //VELOCIDAD BOOST
    public float BoostUp = 40;
    public float BoostDown = -40;
    public float BoostLeft = -40;
    public float BoostRigh = 40;
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




    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        buttonPressed = false;

        //NORTE, SUD, ESTE y OESTE


        //NORTE
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, GoUp)*Time.deltaTime;

            if(GetComponent<Rigidbody2D>().velocity.y > GoUp)
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
            GetComponent<Rigidbody2D>().velocity += new Vector2(GoLeft, 0)*Time.deltaTime;

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
            GetComponent<Rigidbody2D>().velocity += new Vector2(0,GoDown) * Time.deltaTime;

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

        //MOVIMIENTO EN DIAGONAL

        //NORTE-ESTE
        /*if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(GoRigh, GoUp) * Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.x > GoRigh && GetComponent<Rigidbody2D>().velocity.y > GoUp)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GoRigh, GoUp);
            }

            buttonPressed = true;

            UpPressed = true;
            DownPressed = false;
            LeftPressed = false;
            RightPressed = true;
        }

        //NORTE-OESTE
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(GoLeft, GoUp) * Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.x > GoLeft && GetComponent<Rigidbody2D>().velocity.y > GoUp)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GoLeft, GoUp);
            }

            buttonPressed = true;

            UpPressed = true;
            DownPressed = false;
            LeftPressed = true;
            RightPressed = false;
        }

        //SUD-ESTE
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(GoRigh, GoDown) * Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.x > GoRigh && GetComponent<Rigidbody2D>().velocity.y < GoDown)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GoRigh, GoDown);
            }

            buttonPressed = true;

            UpPressed = false;
            DownPressed = true;
            LeftPressed = false;
            RightPressed = true;
        }

        //SUD-OESTE
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(GoLeft, GoDown) * Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.x < GoLeft && GetComponent<Rigidbody2D>().velocity.y < GoDown)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GoLeft, GoDown);
            }

            buttonPressed = true;

            UpPressed = false;
            DownPressed = true;
            LeftPressed = true;
            RightPressed = false;

        }*/

                        //BOOST
                        
                        //NORTE BOOST
                        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.Space))
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(0, BoostUp);
                            buttonPressed = true;

                            UpPressed = true;
                            DownPressed = false;
                            LeftPressed = false;
                            RightPressed = false;
                        }

                        //OESTE BOOST
                        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space))
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(BoostLeft, 0);
                            buttonPressed = true;

                            UpPressed = false;
                            DownPressed = false;
                            LeftPressed = true;
                            RightPressed = false;
                        }

                        //SUD BOOST
                        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.Space))
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(0, BoostDown);
                            buttonPressed = true;

                            UpPressed = false;
                            DownPressed = true;
                            LeftPressed = false;
                            RightPressed = false;
                        }

                        //ESTE BOOST
                        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Space))
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(BoostRigh, 0);
                            buttonPressed = true;

                            UpPressed = false;
                            DownPressed = false;
                            LeftPressed = false;
                            RightPressed = true;
                        }

                        //MOVIMIENTOS EN DIAGONAL BOOST

                        
                        //NORTE-ESTE BOOST
                        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Space))
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(BoostRigh, BoostUp);
                            buttonPressed = true;

                            UpPressed = true;
                            DownPressed = false;
                            LeftPressed = false;
                            RightPressed = true;
                        }

                        //NORTE-OESTE BOOST
                        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space))
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(BoostLeft, BoostUp);
                            buttonPressed = true;

                            UpPressed = true;
                            DownPressed = false;
                            LeftPressed = true;
                            RightPressed = false;
                        }

                        //SUD-ESTE BOOST
                        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Space))
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(BoostRigh, BoostDown);
                            buttonPressed = true;

                            UpPressed = false;
                            DownPressed = true;
                            LeftPressed = false;
                            RightPressed = true;
                        }

                        //SUD-OESTE
                        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space))
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(BoostLeft, BoostDown);
                            buttonPressed = true;

                            UpPressed = false;
                            DownPressed = true;
                            LeftPressed = true;
                            RightPressed = false;

                        }

        //FRENAR
        if (!buttonPressed)
        {
            // NORTE, SUD, ESTE Y OESTE

            //NORTE
            if (UpPressed == true && DownPressed == false && LeftPressed == false && RightPressed == false)
            {
                GetComponent<Rigidbody2D>().velocity -= new Vector2(0, DownBreak)*Time.deltaTime;
                
             
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
                GetComponent<Rigidbody2D>().velocity = new Vector2( RightBreak , DownBreak );
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
            Instantiate(shot,shotSpawn.position,shotSpawn.rotation);
        }

    }
}
