using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReventarSpace : MonoBehaviour {
    public float tiempoBot;

    public int pulsacionesPorSegundo;
    public int pulsBot;

    public bool facil, medio, dificil;

    int facil1, medio2, dificil3;

    void Start()
    {
        StartCoroutine(EmpezarJuego());
        Time.timeScale = 1;

        facil1 = PlayerPrefs.GetInt("facil1", 1);
        medio2 = PlayerPrefs.GetInt("medio2", 2);
        dificil3 = PlayerPrefs.GetInt("dificl3", 3);

        CompararIf();
    }

    void Update()
    {
        tiempoBot += Time.deltaTime;

        DiferenciaSprites();
        Diferencia();
        DificultadBot();
        PulsarMuchasVeces();
    }

    void CompararIf()
    {
        if (facil1 == 1)
        {
            facil = true;
        }

        else if (medio2 == 2)
        {
            medio = true;
        }

        else if (dificil3 == 1)
        {
            dificil = true;
        }
    }

    public void DificultadBot()
    {
        if (facil == true)
        {
            if (tiempoBot >= 0.125f)
            {
                pulsBot++;
                Debug.Log("Bot: " + pulsBot);
                tiempoBot = 0;
            }
        }

        else if (medio == true)
        {
            if (tiempoBot >= 0.111f)
            {
                pulsBot++;
                Debug.Log("Bot: " + pulsBot);
                tiempoBot = 0;
            }
        }

        else if (dificil == true)
        {
            if (tiempoBot >= 0.1f)
            {
                pulsBot++;
                Debug.Log("Bot: " + pulsBot);
                tiempoBot = 0;
            }
        }
    }

    void PulsarMuchasVeces()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pulsacionesPorSegundo++;
        }
    }

    public void Diferencia()
    {
        if (pulsacionesPorSegundo - pulsBot >= 20)
        {
            Debug.Log("Has ganado");
            //Sprite del player ganador
        }

        else if(pulsacionesPorSegundo - pulsBot <= -20)
        {
            Debug.Log("Has perdido");
            //Sprite del Bot ganador
        }
    }

    void DiferenciaSprites()
    {
        if (pulsacionesPorSegundo - pulsBot >= -5 && pulsacionesPorSegundo - pulsBot <= 5)
        {
            //Sprite del pulso en medio
            Debug.Log("Pulso en medio");
        }

        if (pulsacionesPorSegundo - pulsBot >= 5 && pulsacionesPorSegundo - pulsBot <= 19)
        {
            //Sprite del Player ganando
            Debug.Log("Va ganando el Player");
        }

        if (pulsacionesPorSegundo - pulsBot >= -5 && pulsacionesPorSegundo - pulsBot <= -19)
        {
            //Sprite del Bot ganando
            Debug.Log("Va ganando el Bot");
        }
    }

    IEnumerator EmpezarJuego()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Start");
        StopCoroutine(EmpezarJuego());
    }
}
