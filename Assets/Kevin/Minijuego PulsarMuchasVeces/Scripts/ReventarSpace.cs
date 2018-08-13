using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReventarSpace : MonoBehaviour {
    public Image pulso;
    public Sprite ganaBot, bot, empate, player, ganaPlayer;

    public float tiempoBot;

    public int pulsacionesPorSegundo;
    public int pulsBot;

    public bool facil = false, medio = false, dificil = false;

    int facil1, medio2, dificil3;

    void Start()
    {
        StartCoroutine(EmpezarJuego());
        Time.timeScale = 1;
        pulso.sprite = empate;

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
        if (PlayerPrefs.HasKey("facil1"))
        {
            facil = true;
        }

        else if (PlayerPrefs.HasKey("medio2"))
        {
            medio = true;
        }

        else if (PlayerPrefs.HasKey("dificil3"))
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
            pulso.sprite = ganaPlayer;
            Time.timeScale = 0;
        }

        else if(pulsacionesPorSegundo - pulsBot <= -20)
        {
            Debug.Log("Has perdido");
            //Sprite del Bot ganador
            pulso.sprite = ganaBot;
            Time.timeScale = 0; 
        }
    }

    void DiferenciaSprites()
    {
        if (pulsacionesPorSegundo - pulsBot >= -5 && pulsacionesPorSegundo - pulsBot <= 5)
        {
            //Sprite del pulso en medio
            pulso.sprite = empate;
            Debug.Log("Pulso en medio");
        }

        else if (pulsacionesPorSegundo - pulsBot >= 5 && pulsacionesPorSegundo - pulsBot <= 19)
        {
            //Sprite del Player ganando
            pulso.sprite = player;
            Debug.Log("Va ganando el Player");
        }

        else if (pulsacionesPorSegundo - pulsBot >= -5 && pulsacionesPorSegundo - pulsBot <= -19)
        {
            //Sprite del Bot ganando
            pulso.sprite = bot;
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
