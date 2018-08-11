using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptManos : MonoBehaviour
{ 
    public Image[] manos;
    public Sprite manoAtaque, manoEsquive, manoReposo;

    GameObject cuboJ1;
    GameObject cuboJ2;

    GameObject cuboEndGame;

    void CrearJugadores()
    {
        cuboJ1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cuboJ1.GetComponent<Transform>().position = new Vector3(1, 0, 0);

        cuboJ2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cuboJ2.GetComponent<Transform>().position = new Vector3(3, 0, 0);

        CambiarColor();
    }

    //Jugador 1
    int vidaJ1 = 100; //Vida J1
    int fuerzaJ1 = 10; //Fuerza de daño que hace el J1
    int defensaJ1 = 0; //Defensa de daño del J1

    //bool golpeJ1 = false; //Define si esta golpeando o no
    //bool esquiveJ1 = false; //Define si esta esquivando o no

    //Jugador 2
    int vidaJ2 = 100; //Vida J1
    int fuerzaJ2 = 10; //Fuerza de daño que hace el J1
    int defensaJ2 = 0; //Defensa de daño del J1

    //Colores
    Color end = new Color(0, 0, 0);
    Color defensa = new Color(0, 0, 255);
    Color ataque = new Color(255, 0, 0);

    //bool golpeJ2 = false; //Define si esta golpeando o no
    //bool esquiveJ2 = false; //Define si esta esquivando o no

    //Tiempo
    float tiempoRegeneracion;
    float tiempoDelayJ1;
    float tiempoDelayJ2;
    float delayAtaque;

    //Rol
    bool rol = true; //Rol de los jugadores: true = J1 Ataca // false = J2 Ataca
    bool atacado = false;
    bool atacar = false;

    //Funciones
    void CambiarColor()
    {
        if (rol == true)
        {
            cuboJ1.GetComponent<MeshRenderer>().material.color = ataque;
            cuboJ2.GetComponent<MeshRenderer>().material.color = defensa;
        }

        else if (rol == false)
        {
            cuboJ1.GetComponent<MeshRenderer>().material.color = defensa;
            cuboJ2.GetComponent<MeshRenderer>().material.color = ataque;
        }
    }

    void RegenerarVida() //Funcion regenerar vida
    {
        if (tiempoRegeneracion >= 1)
        {
            if (vidaJ1 <= 99)
            {
                vidaJ1++;
            }
            if (vidaJ2 <= 99)
            {
                vidaJ2++;
            }

            tiempoRegeneracion = 0;
        }

        if (tiempoRegeneracion >= 1 && vidaJ2 <= 99)
        {
            vidaJ2++;

            tiempoRegeneracion = 0;
        }
    }

    void StopJuego()
    {
        if (vidaJ2 <= 0)
        {
            Debug.Log("GANA EL J1");
            Time.timeScale = 0;
            cuboJ2.GetComponent<MeshRenderer>().material.color = end;
        }

        else if (vidaJ1 <= 0)
        {
            Debug.Log("GANA EL J2");
            Time.timeScale = 0;
            cuboJ1.GetComponent<MeshRenderer>().material.color = end;
        }
    }
    void Start()
    {
        CrearJugadores();
    }

    void Update()
    {
        tiempoDelayJ1 += Time.deltaTime;
        tiempoDelayJ2 += Time.deltaTime;
        tiempoRegeneracion += Time.deltaTime;
        delayAtaque += Time.deltaTime;

        RegenerarVida();

        Debug.Log("Vida J1 = " + vidaJ1);
        Debug.Log("Vida J2 = " + vidaJ2);

        if (rol == true) //El J1 ataca y el J2 defiende
        {
            if (Input.GetKeyDown(KeyCode.Space) && tiempoDelayJ1 >= 1f && manos[0].sprite == manoReposo) //Si J1 pulsa el boton para atacar...
            {
                manos[0].sprite = manoAtaque;

                delayAtaque = 0;
                tiempoDelayJ1 = 0;

                atacado = false;
                atacar = true;

                StartCoroutine(VolverReposo());
                StopCoroutine(VolverReposo());
            }

            if (!Input.GetKeyDown(KeyCode.Z) && delayAtaque >= 0.5f && atacado == false && atacar == true) //J2 no esquiva
            {
                vidaJ2 -= (fuerzaJ1 - defensaJ2); //J1 le quita vida a J2
                Debug.Log("J1 golpea a J2 y le quita " + (fuerzaJ1 - defensaJ2) + " puntos de vida");

                atacado = true;
                atacar = false;

                StartCoroutine(VolverReposo());
                StopCoroutine(VolverReposo());
            }
            
            if (Input.GetKeyDown(KeyCode.Z) && delayAtaque <= 2f && atacado == false) //J2 esquiva
            {
                manos[1].sprite = manoEsquive;
                

                rol = false; //Se cambian los roles
                Debug.Log("J1 falla. Ahora ataca J2.");

                atacado = true;

                StartCoroutine(VolverReposo());
                StopCoroutine(VolverReposo());
            }
        }

        else //El J1 defiende y el J2 ataca
        {
            if (Input.GetKeyDown(KeyCode.Z) && tiempoDelayJ2 >= 1f && manos[1].sprite == manoReposo) //Si J2 pulsa el boton para atacar...
            {
                manos[1].sprite = manoAtaque;

                delayAtaque = 0;
                tiempoDelayJ2 = 0;

                atacado = false;
                atacar = true;

                StartCoroutine(VolverReposo());
                StopCoroutine(VolverReposo());
            }

            if (!Input.GetKey(KeyCode.Space) && delayAtaque >= 0.5f && atacado == false && atacar == true) //J1 no esquiva
            {
                vidaJ1 -= (fuerzaJ2 - defensaJ1); //J2 le quita vida a J1
                Debug.Log("J2 golpea a J1 y le quita " + (fuerzaJ2 - defensaJ1) + " puntos de vida");

                atacado = true;
                atacar = false;

                StartCoroutine(VolverReposo());
                StopCoroutine(VolverReposo());
            }

            if (Input.GetKeyDown(KeyCode.Space) && delayAtaque <= 2f && atacado == false) //J2 esquivas
            {
                manos[0].sprite = manoEsquive;

                rol = true; //Se cambian los roles
                Debug.Log("J2 falla. Ahora ataca J1.");

                atacado = true;
                StartCoroutine(VolverReposo());
                StopCoroutine(VolverReposo());
            }
        }

        


        CambiarColor();

        StopJuego();


    }

    IEnumerator VolverReposo()
    {
        yield return new WaitForSeconds(0.75f);
        manos[0].sprite = manoReposo;
        manos[1].sprite = manoReposo;
    }
}
