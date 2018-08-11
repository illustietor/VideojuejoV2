using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RPG : MonoBehaviour {

	public Image imagen;
    public Sprite circulo, cuadrado, pentagono, peneKawaii, linea, triangulo;
    Sprite[] imagenes = new Sprite[6];

    float tiempo;
    public float tiempoTotal;

    public int puntuacion;
    public int vidas = 3;

    void AleatorizarImagenes()
    {
        imagen.sprite = imagenes[Random.Range(0, imagenes.Length)];
    }

    void FinalJuego()
    {
        if (vidas == 0)
        {
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
                Time.timeScale = 1;
            }
        }
    }

    void ElegirOpciones()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (imagen.sprite == triangulo) //Elige la primera opcion (Triangulo)
            {
                puntuacion++;
                AleatorizarImagenes();
                tiempo = 0;
            }
            else
            {
                vidas--;
                AleatorizarImagenes();
                tiempo = 0;
            }
        }
        

        if (Input.GetKeyDown(KeyCode.UpArrow)) //Elige la segunda opcion (Circulo)
        {
            if (imagen.sprite == circulo)
            {
                puntuacion++;
                AleatorizarImagenes();
                tiempo = 0;
            }
            else
            {
                vidas--;
                AleatorizarImagenes();
                tiempo = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) //Elige la tercera opcion (Cuadrado)
        {
            if (imagen.sprite == cuadrado)
            {
                puntuacion++;
                AleatorizarImagenes();
                tiempo = 0;
            }
            else
            {
                vidas--;
                AleatorizarImagenes();
                tiempo = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //Elige la cuarta opcion (Mierda Pura)
        {
            if (imagen.sprite == linea || imagen.sprite == peneKawaii || imagen.sprite == pentagono)
            {
                puntuacion++;
                AleatorizarImagenes();
                tiempo = 0;
            }
            else
            {
                vidas--;
                AleatorizarImagenes();
                tiempo = 0;
            }
        }
    }


    void Start()
    {
        //Al inicio del juego se activa una imagen

        imagenes[0] = triangulo;
        imagenes[1] = circulo;
        imagenes[2] = cuadrado;
        imagenes[3] = linea;
        imagenes[4] = peneKawaii;
        imagenes[5] = pentagono;
    }

    void Update()
    {
        tiempo += Time.deltaTime;
        tiempoTotal += Time.deltaTime;

        if (tiempo >= 3f)
        {
            AleatorizarImagenes();

            tiempo = 0;
        }
        if (Time.timeScale == 1)
        {
            ElegirOpciones();
        }

        FinalJuego();
    }
}
