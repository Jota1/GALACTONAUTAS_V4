using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    public GameObject LuzSuprema;
    public GameObject carrinho;
    public GameObject jogador;
    public Transform PositionCaverna;
    public Transform PositionFimDesafio;

    public GameObject[] CercasFantasmas;
    public GameObject[] CercasInstaladas;
    public GameObject Dome;

    public AI ai;

    public static bool domoEterno;
    public static bool energiaEterna;

    // Start is called before the first frame update
    void Start()
    {
        domoEterno = false;
        energiaEterna = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5)) AtivarODomo();

        if (Input.GetKeyDown(KeyCode.Alpha6)) CarrinhoNaCaverna();

        if (Input.GetKeyDown(KeyCode.Alpha7)) Desafio1Completo();

        if (Input.GetKeyDown(KeyCode.Alpha8)) Luz();

        if (Input.GetKeyDown(KeyCode.Alpha9)) DesvirarCarrinho();

        if (Input.GetKeyDown(KeyCode.Alpha0)) DomoEterno();

        if (Input.GetKeyDown(KeyCode.N)) EnergiaEterna();

        if (Input.GetKeyDown(KeyCode.B)) AbastecerEnergia();
    }

    public void AtivarODomo()
    {
       
        for (int i = 0; i < CercasFantasmas.Length; i++)
        {
            CercasInstaladas[i].SetActive(true);
            CercasFantasmas[i].SetActive(false);
            AtivarTriggers.cercasAtivadas = true;
           
        }
        ai.SetnarrativaAtual(3);


    }

    public void CarrinhoNaCaverna()
    {
        jogador.SetActive(false);
        carrinho.transform.position = PositionCaverna.position;
        carrinho.SetActive(true);
        ai.SetnarrativaAtual(9);
    }

    public void Desafio1Completo()
    {
        jogador.SetActive(false);
        carrinho.transform.position = PositionFimDesafio.position;
        carrinho.SetActive(true);
        ai.SetnarrativaAtual(9);
    }

    public void Luz()
    {
        if(LuzSuprema.activeSelf)
        LuzSuprema.SetActive(false);

        else if(!LuzSuprema.activeSelf)
        LuzSuprema.SetActive(true);

    }

    public void DesvirarCarrinho()
    {
        carrinho.transform.rotation = new Quaternion(carrinho.transform.rotation.x, carrinho.transform.rotation.y, 0, carrinho.transform.rotation.w);
    }

    public void DomoEterno()
    {
        Dome.SetActive(true);
        domoEterno = true;
    }

    public void EnergiaEterna()
    {
        energiaEterna = true;
    }

    public void AbastecerEnergia()
    {
        Generators.MaxCapacity = 100;
        Generators.currentEnergy = 100;
        UpdateInterface.instance.Update2();
    }
}
