using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMinijuegoCodigo : MonoBehaviour {

    //Numero de palabras que hay que introducir en la fase
    public int numeroDePalabras = 5;

    //Contador del numero de palabras introducidas en la fase
    int numeroDePalabrasIntroducidas;



    //Palabras random (son fijas, validas para todos los juegos)

    public string[] palabrasDeRelleno = new string[] { "stuff1", "stuff2", "stuff3", "stuff4", "stuff5" };

    //string palabra1 = "stuff";
    //string palabra2 = "stuff2";
    //string palabra3 = "stuff3";
    //string palabra4 = "stuff4";
    //string palabra5 = "stuff5";





    //Palabras clave (varian según el minijuego, introducirlas desde Unity)

    public string[] palabrasClave;

    //public string clave1;
    //public string clave2;
    //public string clave3;
    //public string clave4;
    //public string clave5;



    //Descripción palabras clave (explican para que sirve el código que se ha escrito)

    public string[] descripcionesClave;

    //public string descripcion1;
    //public string descripcion2;
    //public string descripcion3;
    //public string descripcion4;
    //public string descripcion5;




    //Iniciar el juego (es igual en todos los minijuegos de programación)



    //Introducir string que se te pide acompañado de una descripción

    //string IntroducirPalabra()
    //{

    //}



    //Comparar string introducido

    //Coger el string inroducido
    //Convertirlo en una array de caracteres y comparar caracter a caracter si es correcto
    //Si es correcto devuelve true
    //Si es incorrecto devuelve false

    bool CompararPalabras (string referencia, string introducida)
    {
        if (referencia.Length != introducida.Length)
        {
            Debug.Log("Error. El texto no es correcto.");
            return false;
        }

        for (int i = 0; i < referencia.Length; i++)
        {
            if (referencia[i] == introducida[i]);
            else 
            {
                Debug.Log("Error. El texto no es correcto.");
                return false;
            }
        }

        Debug.Log("El texto es correcto.");
        return true;
    }


    //Hay un contador del número de palabras que hay que introducir.
    //El juego carga primero las clave y si faltan las random (a ser posible que las mezcle)
    //Cuando el contador de palabras introducidas llega al tope el minijuego termina y carga otro minijuego durante un tiempo limitado.
    //Cuando el tiempo termina se vuelve a programar.
    //Si se habia completado correctamente todo accede a una fase superior
    //Si se habia completado incorrectamente se accede de nuevo al mismo nivel reseteado.






	// Use this for initialization
	void Start ()
    {

        

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
