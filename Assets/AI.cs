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
    public GameObject PanelForaDoDomo;

    public Text text;

    public Dome domo;
    public Slider lifeIndicatorSld;
    public float maxLife = 60f;
    public GameObject anim;
    private float life;

    private bool falaAtiva;
    private bool novafala;
    private bool trocarfala;
    private int narrativaAtual;
   // private float timer;
    private float timerAtivarAsCercas;
    private int gravidadeAtingida;
    private bool aviso;

    // Start is called before the first frame update
    void Start()
    {
        narrativaAtual = 0;
       // timer = duraçãoDasFalas;
        timerAtivarAsCercas = 45;
        gravidadeAtingida = 14;

        life = 60;
        lifeIndicatorSld.maxValue = maxLife;
        lifeIndicatorSld.value = life;
    }



    // Update is called once per frame
    void Update()
    {
        if (novafala)
        {
            Debug.Log(narrativa[narrativaAtual]);
            anim.SetActive(false);
            anim.SetActive(true);
            falaAtiva = true;
            novafala = false;
            trocarfala = true;

        }

        if (falaAtiva)
        {

            if (!panelAI.activeSelf || trocarfala)
            {
                panelAI.SetActive(true);
                anim.SetActive(true);
                text.text = narrativa[narrativaAtual].ToUpper();
                trocarfala = false;
                narrativaAtual++;
            }

        }

        else
        {
            if (aviso)
            {


                if (!panelAI.activeSelf)
                {
                    anim.SetActive(true);
                    panelAI.SetActive(true);
                    text.text = sairDoDomo;
                }

            }
        }

        if (narrativaAtual == 3 && falaAtiva == false)
        {

            if (!panelAI.activeSelf && timerAtivarAsCercas >= 40)
            {
                panelAI.SetActive(true);
                anim.SetActive(true);
                text.text = "Nível " + gravidadeAtingida + " Atingido".ToUpper(); ;
            }


            timerAtivarAsCercas -= Time.deltaTime;

            if (timerAtivarAsCercas <= 0)
            {
                anim.SetActive(true);
                gravidadeAtingida++;
                text.text = "Nível " + gravidadeAtingida + " Atingido".ToUpper(); ;
                timerAtivarAsCercas = 45;
            }

            if (gravidadeAtingida == 21)
            {
                PanelGameOver.SetActive(true);
            }

        }



        ///*******Vida 0O Player

        if (!Cheats.imortal)
        {
                 if (domo.GetForaDoDomo())
                {
                    life -= Time.timeScale * 0.01f;
                    lifeIndicatorSld.value = life;
                }

                else if (!domo.GetForaDoDomo() && life < maxLife)
                {
                    if (life > maxLife)
                    {
                        life = maxLife;
                    }

                    life += Time.timeScale * 0.01f;
                    lifeIndicatorSld.value = life;
                }

                if (life <= 0)
                {
                    PanelForaDoDomo.SetActive(true);
                }


        }
    }

    public void SetFalaAtiva(bool state)
    {
        novafala = state;
    }

    public bool GetFalaAtiva()
    {
        return falaAtiva;
    }

    public void Avisinho()
    {
        aviso = true;
    }

    public int GetnarrativaAtual()
    {
        return narrativaAtual;
    }

    public void SetnarrativaAtual(int narrativa)
    {
        narrativaAtual = narrativa;
    }

    public void CancelarFala()
    {
        if (falaAtiva)
        {
            panelAI.SetActive(false);
            falaAtiva = false;
        }

        if (aviso)
        {
            panelAI.SetActive(false);
            aviso = false;
        }

        if(narrativaAtual == 3 && falaAtiva == false)
        {
            panelAI.SetActive(false);
        }
    }

}
