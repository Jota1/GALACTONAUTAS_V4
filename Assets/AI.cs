using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    public GameObject panelAI;
    public string[] combustivel50;
    public string[] combustivel0;

    [TextArea(3,10)]
    public string[] narrativa;
    public float duraçãoDasFalas;

    public Text text;

    private bool falaAtiva;
    private int narrativaAtual;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        narrativaAtual = 0;
        timer = duraçãoDasFalas;

    }

    // Update is called once per frame
    void Update()
    {
       
       

        if (falaAtiva)
        {
            timer -= Time.timeScale;

            if (!panelAI.activeSelf)
            {
                panelAI.SetActive(true);
                text.text = narrativa[narrativaAtual];
            }

            if (timer <= 0)
            {
                panelAI.SetActive(false);
                timer = duraçãoDasFalas;
                narrativaAtual++;
                falaAtiva = false;

            }
        }
    }


    public void SetFalaAtiva(bool state)
    {
        falaAtiva = state;
    }
}
