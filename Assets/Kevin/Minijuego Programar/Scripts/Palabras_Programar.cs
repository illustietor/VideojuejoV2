using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palabras_Programar : MonoBehaviour {

    public string saltar = "saltar";
    public string moverse = "moverse";
    bool hasGanado = false; //Se salta a la siguiente palabra

    KeyCode[] myKeyCodes;
    int currentKeyCode = 0;

	void Start () {

        myKeyCodes = new KeyCode[saltar.Length];
        for (int i = 0; i < saltar.Length; i++)
        {
            KeyCode thisKeyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), saltar[i].ToString().ToUpper());
            myKeyCodes[i] = thisKeyCode;
        }
    }
	
	void Update () {
        
        if (!hasGanado && Input.GetKeyDown(myKeyCodes[currentKeyCode]))
        {
            Debug.Log("Correcto -> " + myKeyCodes[currentKeyCode]);
            currentKeyCode++;
            if (currentKeyCode == myKeyCodes.Length)
            {
                Debug.Log("Has ganado");
                hasGanado = true;
            }
                
        }
        else if (Input.anyKeyDown)
        {
            Debug.Log("Incorrecto");
        }
	}
}
