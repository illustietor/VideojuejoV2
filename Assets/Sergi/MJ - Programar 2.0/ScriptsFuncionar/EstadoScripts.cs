using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoScripts : MonoBehaviour {

    //Un array publico de booleanos donde introduces cada una de los scripts de las palabras claves y compruebe si son correctas o no.

    public GameObject[] listaClaves; //Aquí se introducen los GameObjects que contienen el script de las claves
    public bool[] listaBoolClaves; //Este array guarda que claves estan bien introducidas (true) y cuales no (false)

    //Eso se hace accediendo a la variable booleana que tenga dentro que es la misma en todos los scripts
    //La variable se llama "claveCorrecta"
    
    bool ComprobarPalabrasClave() //Función que comprueba el estado booleano de las palabras claves del array introducido.
    {
        for (int i = 0; i < listaClaves.Length; i++) //Repasar todas los objetos de dentro de la array
        {
            listaBoolClaves[i] = listaClaves[i].GetComponent<ScriptPalabraClave>().claveCorrecta; //Copia el valor booleano de la clave en la lista booleana de claves
        }

        for (int j = 0; j < listaBoolClaves.Length; j++) //Comprueba si los valores de la lista de claves son verdaderos o falsos
        {
            if (listaBoolClaves[j]) //Si el valor es verdadero...
            {
                Debug.Log("listaBoolClaves[" + j + "] es " + listaBoolClaves[j]);
            }

            else //Si el valor no es verdadero...
            {
                Debug.Log("listaBoolClaves[" + j + "] es " + listaBoolClaves[j]);
                Debug.Log("Hay valores falsos.");
                return false;

            }
        }

        Debug.Log("Todos los valores son verdaderos.");
        return true;
    }



    //Si todos los huecos de la nueva array booleana son correctos, el script esta completo
}
