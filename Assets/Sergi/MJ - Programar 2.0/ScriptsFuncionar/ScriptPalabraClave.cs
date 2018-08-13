using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScriptPalabraClave : MonoBehaviour {

    public bool claveCorrecta = false; //Determina si la palabra clave está bien introducida o no.

    public TextMeshProUGUI inputTexto; //Referecia que recoge el texto introducido en el Text Mesh Pro Input Field.
    public TextMeshProUGUI placeholder; //Referencia que recoge el placeholder del Text Mesh Pro Input Field.

    public string clave; //Variable que define la palabra que el player debe introducir para ganar.
    public string pista; //Variable que define el texto que se borra al escribir.


    void Awake() //Antes de que empiece el juego...
    {
        placeholder.SetText(pista); //Establece en el placeholder la palabra introducida en "pista".
    }

    public void CambioTexto() //Esta función la llamaremos desde el "On End Edit" del "Input Field" para que se ejecute cada vez que acabemos de cambiar el texto.
    {
        //Por algún motivo que desconozco siempre se añade un caracter extra en el texto del input por lo que hay que dar algunas vueltas programando...
        
        //Primero convertimos los textos en arrays de characteres para poder hacer la ñapa con la comprobación de longitud:
        char[] claveChar = clave.ToCharArray();
        char[] inputTextoChar = inputTexto.text.ToCharArray();

        //Ahora toca ver si las palabras son iguales.
        //Primero comprobamos la longitud de las palabras. Si no son igual de largas, no pueden ser la misma palabra.
        //Recuerda que hay que restar el caracter extra que se añade en el input para que no de error.

        if (claveChar.Length == inputTextoChar.Length - 1) //Si el tamaño de la clave es igual al introducido...
        {
            //Si el tamaño de las palabras coincide entonces pasamos a comparar si contienen los mismos caracteres.

            if (inputTexto.text.Contains(clave)) //Si el texto introducido es igual a la clave...
            {
                inputTexto.color = new Color32(255, 219, 0, 255); //Cambia el color a amarillo
                //Debug.Log("Las palabras son iguales");
                claveCorrecta = true;

            }

            else //Si el texto introducido no es igual a la clave...
            {
                inputTexto.color = new Color32(255, 0, 0, 255); //Cambia el color a rojo
                //Debug.Log("Las palabras no son iguales");
                claveCorrecta = false;

            }
        }

        else //Si el tamaño de la clave no es igual al introducido...
        {
            inputTexto.color = new Color32(255, 0, 0, 255); //Cambia el color a rojo
            //Debug.Log("Las palabras no son iguales");
            claveCorrecta = false;
        }

    }

}
