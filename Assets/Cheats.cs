using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    public GameObject LuzSuprema;
    // Start is called before the first frame update
    void Start()
    {
        
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

    }

    public void CarrinhoNaCaverna()
    {

    }

    public void Desafio1Completo()
    {

    }

    public void Luz()
    {
        LuzSuprema.SetActive(true);
    }

    public void DesvirarCarrinho()
    {

    }

    public void DomoEterno()
    {

    }

    public void EnergiaEterna()
    {

    }

    public void AbastecerEnergia()
    {
        Generators.MaxCapacity = 100;
        Generators.currentEnergy = 100;
        UpdateInterface.instance.Update2();
    }
}
