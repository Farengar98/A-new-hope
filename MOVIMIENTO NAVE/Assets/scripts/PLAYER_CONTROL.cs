using UnityEngine;
using System.Collections;

public class PLAYER_CONTROL : MonoBehaviour {
    //CONTROL TECLAS APRETADAS
    
    bool buttonPressed;

    //VELOCIDAD MOVIMIENTO
    [Header("Movement")]
    public float GoUp = 40;
    public float GoDown = -40;
    public float GoLeft = -40;
    public float GoRigh = 40;

    public float speed = 40;
    public float finalSpeed;

    public float limiteX;
    public float limiteY;
    //VELOCIDAD BOOST
    public float BoostUp = 40;
    public float BoostDown = -40;
    public float BoostLeft = -40;
    public float BoostRigh = 40;
    



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
            //AQUI DESBLOQUEAMOS CUALQUIER EJE
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;

            //SI LA NAVE LLEGA AL LIMITE SUPERIOR LA ELOCIADA PASA A 0 Y BLOQUEAMOS EL MOVIMIENO EN Y          
             if (transform.localPosition.y >= limiteY)
                {
                    finalSpeed = 0;

                    GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;

                    //AQUI COMPROBAMOS QUE SI A PARTE DE ESTAR EN EL LIMITE SUPERIOR TAMBIEN ESTAMOS EN UN LIMETE DE DERECHA O IZQUIERDA 
                    //BLOQUEAMOS TANTO EL MOVIMIENTO EN Y COMO EN X
                    if (transform.localPosition.x <= -limiteX || transform.localPosition.x >= limiteX)
                    {
                        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX |
                              RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                    }
                }
                //SI NO ESTA LLEGANDO A NINGUN LIMITE finalSpeed PASA A TENER EL VALOR QUE DEBERIA
                else
                {
                    finalSpeed = speed;

                }
            

  
            //AQUI IMPLEMENTAMOS EL MOVIMENT (PARECIDO A COMO LO HACIAMOS ANTES PERO CON UNA SOLA VARIABLE, totalSpeed, Y NO
            // CON UNAVARIABLE PARA CADA DIRECCION COMO HACIAMOS ANTES)
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, finalSpeed)*Time.deltaTime;

            if(GetComponent<Rigidbody2D>().velocity.y > GoUp)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GoUp);
            }
            buttonPressed = true;
            
        }

        //OESTE
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //AQUI DESBLOQUEAMOS CUALQUIER EJE
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;

            if (transform.localPosition.x <= -limiteX)
            {
                finalSpeed = 0;
               
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;

                if (transform.localPosition.y >= limiteY || transform.localPosition.y <= -limiteY)
                {
                    GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX |
                    RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                }           
                
            }
            else
            {
                finalSpeed = speed;
            }

            GetComponent<Rigidbody2D>().velocity += new Vector2(-finalSpeed, 0)*Time.deltaTime;

            if (GetComponent<Rigidbody2D>().velocity.x < GoLeft)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GoLeft, GetComponent<Rigidbody2D>().velocity.y);
            }

            buttonPressed = true;
            
        }

        //SUD
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //AQUI DESBLOQUEAMOS CUALQUIER EJE
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;

            if (transform.localPosition.y <= -limiteY)
            {
                finalSpeed = 0;
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;

                if (transform.localPosition.x <= -limiteX || transform.localPosition.x >= limiteX)
                {
                    GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX |
                    RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                }

            }
            else
            {
                finalSpeed = speed;

            }
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, -finalSpeed) * Time.deltaTime;
           

            if (GetComponent<Rigidbody2D>().velocity.y < GoDown)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GoDown);
            }


            buttonPressed = true;

           
        }

        //ESTE
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //AQUI DESBLOQUEAMOS CUALQUIER EJE
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;

            if (transform.localPosition.x >= limiteX)
            {
                finalSpeed = 0;

                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;

                if (transform.localPosition.y >= limiteY || transform.localPosition.y <= -limiteY)
                {
                    GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX |
                    RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                }

            }
            else
            {
                finalSpeed = speed;
            }

            GetComponent<Rigidbody2D>().velocity += new Vector2(finalSpeed, 0) * Time.deltaTime;
            
            if (GetComponent<Rigidbody2D>().velocity.x > GoRigh)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GoRigh, GetComponent<Rigidbody2D>().velocity.y);
            }

            buttonPressed = true;

            
        }  

        //FRENAR
        if (!buttonPressed)
        {                

           GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
           GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            
        }



        //DISPARO
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot,shotSpawn.position,shotSpawn.rotation);
        }



    }
}
