using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adivinar : MonoBehaviour {
    public Image imagen;
    public Sprite[] imagenes;

    float tiempo;

    void AleatorizarImagenes()
    {

    }

    void ElegirOpciones()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && imagenes[2]) //Elige la primera opcion (Triangulo)
        {
            imagen.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && imagenes[0]) //Elige la segunda opcion (Circulo)
        {
            imagen.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && imagenes[1]) //Elige la tercera opcion (Cuadrado)
        {
            imagen.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //Elige la cuarta opcion (Mierda Pura)
        {
            if (imagenes[3] || imagenes[4] || imagenes[5])
            {
                imagen.enabled = false;
            }
        }
    }

    IEnumerator TiempoImagenes()
    {

        yield return new WaitForSeconds(4);
        imagen.sprite = imagenes[Random.Range(0, imagenes.Length)];
        imagen.enabled = true;
        yield return new WaitForSeconds(1);
    }

	void Start () {
		//Al inicio del juego se activa una imagen
	}
	
	void Update () {
            StartCoroutine(TiempoImagenes());
	}
}
