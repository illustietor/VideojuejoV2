using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScriptCompletarCodigo : MonoBehaviour {

    public TextMeshProUGUI inputTexto; //Referecia que recoge el texto introducido en el Text Mesh Pro Input Field
    //string text = TMP_InputField.
    public TextMeshProUGUI placeholder; //Referencia que recoge el placeholder del Text Mesh Pro Input Field

    public string clave; //Variable que define la palabra que el player debe introducir para ganar
    public string pista; //Variable que define el texto "borrable" que ayuda a identificar

    public bool correcto = false;

    void Awake() //Antes de que empiece el juego...
    {
        placeholder.SetText(pista); //Establece en el placeholder la palabra introducida en "pista".
        
    }        


    public void CambioTexto () // EL INPUT FUNCIONA 100% // 
    {        
        //Debug.Log("La palabra clave es " + clave + " y mide " + clave.Length);
        //Debug.Log("Las palabra introducida es " + inputTexto.text + " y mide " + inputTexto.text.Length);

        char[] claveChar = clave.ToCharArray();
        char[] inputTextoChar = inputTexto.text.ToCharArray();

        //for (int i = 0; i < claveChar.Length; i++)
        //{
        //    Debug.Log("En la posición " + i + " de claveChar está: " + claveChar[i]);
        //}

        //for (int i = 0; i < inputTextoChar.Length; i++)
        //{
        //    Debug.Log("En la posición " + i + " de inputTextoChar está: " + inputTextoChar[i]);
        //}


        if (claveChar.Length == inputTextoChar.Length - 1) 
        {
            if (inputTexto.text.Contains(clave)) //Si el texto introducido es igual a la clave...
            {
                inputTexto.color = new Color32(255, 219, 0, 255); //Cambia el color a amarillo
                //Debug.Log("Las palabras son iguales");
                correcto = true;

            }
            
            else
            {
                inputTexto.color = new Color32(255, 0, 0, 255); //Cambia el color a rojo
                //Debug.Log("Las palabras no son iguales");
                correcto = false;

            }
        }

        else
        {
            inputTexto.color = new Color32(255, 0, 0, 255); //Cambia el color a rojo
            //Debug.Log("Las palabras no son iguales");
            correcto = false;
        }

    }





}



