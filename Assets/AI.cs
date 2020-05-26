using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    public GameObject panelAI;

    [TextArea(3, 10)]
    public string[] combustivel50;

    [TextArea(3, 10)]
    public string[] combustivel0;

    [TextArea(3, 10)]
    public string sairDoDomo;

    [TextArea(3,10)]
    public string[] narrativa;
    public float duraçãoDasFalas;

    public GameObject PanelGameOver;

    public Text text;

    private bool falaAtiva;
    private bool novafala;
    private bool trocarfala;
    private int narrativaAtual;
    private float timer;
    private float timerAtivarAsCercas;
    private int gravidadeAtingida;
    private bool aviso;

    // Start is called before the first frame update
    void Start()
    {
        narrativaAtual = 0;
        timer = duraçãoDasFalas;
        timerAtivarAsCercas = 15;
        gravidadeAtingida = 14;

    }

    // Update is called once per frame
    void Update()
    {
        if(novafala)
        {
            Debug.Log(narrativa[narrativaAtual]);
            falaAtiva = true;
            timer = duraçãoDasFalas;
            novafala = false;
            trocarfala = true;
        }
       
        if (falaAtiva)
        {
            timer -= Time.timeScale;

            if (!panelAI.activeSelf || trocarfala)
            {
                panelAI.SetActive(true);
                text.text = narrativa[narrativaAtual];
                trocarfala = false;
                narrativaAtual++;
            }

            if (timer <= 0)
            {
                panelAI.SetActive(false);
                timer = duraçãoDasFalas;
                falaAtiva = false;

            }
        }

        else
        {
            if( aviso)
            {
                timer -= Time.timeScale;

                if (!panelAI.activeSelf)
                {
                    panelAI.SetActive(true);
                    text.text = sairDoDomo;
                }

                if (timer <= 0)
                {
                    panelAI.SetActive(false);
                    timer = duraçãoDasFalas;
                    aviso = false;

                }
               
            }
        }

        if(narrativaAtual==3 && falaAtiva ==false)
        {

            if (!panelAI.activeSelf)
            {
                panelAI.SetActive(true);
                text.text = "Nível " + gravidadeAtingida + " Atingido";
            }


            timerAtivarAsCercas -= Time.deltaTime;

            if (timerAtivarAsCercas <= 0)
            {
                gravidadeAtingida++;
                text.text = "Nível " + gravidadeAtingida + " Atingido";
                timerAtivarAsCercas = 15;
            }

              if(gravidadeAtingida == 21)
            {
                PanelGameOver.SetActive(true);
            }

        }
    }


    public void SetFalaAtiva(bool state)
    {
        novafala = state;
    }

    public void Avisinho()
    {
        aviso = true;
    }

    public int GetnarrativaAtual()
    {
        return narrativaAtual;
    }

}
