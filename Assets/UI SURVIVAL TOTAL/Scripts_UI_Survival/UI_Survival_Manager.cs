using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Survival_Manager : MonoBehaviour
{
    [Header("Modelos 3D - Base")]
    public GameObject snc;
    public GameObject bauxita;
    public GameObject bacterias;
    public GameObject geradorbiomassa;

    [Header("Modelos 3D - Planeta")]
    public GameObject planta1_3d;
    public GameObject planta2_3d;
    public GameObject planta3_3d;
    public GameObject planta4_3d;
    public GameObject planta5_3d;
    public GameObject planta6_3d;
    public GameObject planta7_3d;
    public GameObject planta8_3d;
    public GameObject planta9_3d;
    public GameObject planta10_3d;


    [Header("Infos - Base")]
    public GameObject snc_info;
    public GameObject bauxita_info;
    public GameObject bacteria_info;
    public GameObject geradorbiomassa_info;

    [Header("Infos - Planeta")]
    public GameObject planta1_info;
    public GameObject planta2_info;
    public GameObject planta3_info;
    public GameObject planta4_info;
    public GameObject planta5_info;
    public GameObject planta6_info;
    public GameObject planta7_info;
    public GameObject planta8_info;
    public GameObject planta9_info;
    public GameObject planta10_info;

    //Estados do menu
    private string PLANETA = "Planeta";
    private string BASE = "Base";
    private string ARTEFATOS = "Artefatos";
    private string VEICULO = "VEICULO";
    public string estado;

    [Header("Botoes Menu")]
    public Button botao_base;
    public Button botao_veiculo;
    public Button botao_planeta;
    //public Button botao_artefatos;
    public bool botao_base_selected;
    bool botao_veiculo_selected;
    bool botao_planeta_selected;

    //paineis menu
    public GameObject base_panel;
    public GameObject planeta_panel;
    public GameObject artefato_panel;

    public GameObject conjunto_3d_planeta;
    public GameObject conjunto_3d_base;
    public GameObject conjunto_info_planeta;
    public GameObject conjunto_info_base;
    public GameObject conjunto_info_artefato;
    public GameObject conjunto_3d_artefato;

    //array menu - BASE
    private int itens_base;
    //array menu - Planeta
    private int itens_planeta;

    void Start()
    {   //estado = BASE;
        botao_base.Select();
        botao_base_selected = true;

        snc.SetActive(true);
        //bacterias.SetActive(false);
        //bauxita.SetActive(false);

    }

  
    void Update()
    {
        Botoes_Base();
        Botoes_Planeta();
        Buttons_UI();

        Debug.Log(botao_veiculo_selected);
    }

    public void Botoes_Planeta ()
    {
        if (itens_planeta <= 1)
            itens_planeta = 1;

        if (itens_planeta >= 10)
            itens_planeta = 10;

        if (itens_planeta == 1)
        {
            planta1_info.SetActive(true);
            planta1_3d.SetActive(true);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 2)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(true);
            planta2_3d.SetActive(true);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 3)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(true);
            planta3_3d.SetActive(true);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 4)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(true);
            planta4_3d.SetActive(true);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 5)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(true);
            planta5_3d.SetActive(true);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 6)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(true);
            planta6_3d.SetActive(true);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 7)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(true);
            planta7_3d.SetActive(true);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 8)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(true);
            planta8_3d.SetActive(true);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 9)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(true);
            planta9_3d.SetActive(true);

            planta10_info.SetActive(false);
            planta10_3d.SetActive(false);
        }

        if (itens_planeta == 10)
        {
            planta1_info.SetActive(false);
            planta1_3d.SetActive(false);

            planta2_info.SetActive(false);
            planta2_3d.SetActive(false);

            planta3_info.SetActive(false);
            planta3_3d.SetActive(false);

            planta4_info.SetActive(false);
            planta4_3d.SetActive(false);

            planta5_info.SetActive(false);
            planta5_3d.SetActive(false);

            planta6_info.SetActive(false);
            planta6_3d.SetActive(false);

            planta7_info.SetActive(false);
            planta7_3d.SetActive(false);

            planta8_info.SetActive(false);
            planta8_3d.SetActive(false);

            planta9_info.SetActive(false);
            planta9_3d.SetActive(false);

            planta10_info.SetActive(true);
            planta10_3d.SetActive(true);
        }
    }

    public void Botoes_Base ()
    {
        if (itens_base <= 1)
            itens_base = 1;

        if (itens_base >= 4)
            itens_base = 4;

        if (itens_base == 1)
        {
            snc.SetActive(true);
            snc_info.SetActive(true);
            bauxita.SetActive(false);
            bauxita_info.SetActive(false);
            bacterias.SetActive(false);
            bacteria_info.SetActive(false);
            geradorbiomassa.SetActive(false);
            geradorbiomassa_info.SetActive(false);
        }

        if (itens_base == 2)
        {
            snc.SetActive(false);
            snc_info.SetActive(false);
            bauxita.SetActive(true);
            bauxita_info.SetActive(true);
            bacterias.SetActive(false);
            bacteria_info.SetActive(false);
            geradorbiomassa.SetActive(false);
            geradorbiomassa_info.SetActive(false);
        }

        if (itens_base == 3)
        {
            snc.SetActive(false);
            snc_info.SetActive(false);
            bauxita.SetActive(false);
            bauxita_info.SetActive(false);
            bacterias.SetActive(true);
            bacteria_info.SetActive(true);
            geradorbiomassa.SetActive(false);
            geradorbiomassa_info.SetActive(false);
        }

        if (itens_base == 4)
        {
            snc.SetActive(false);
            snc_info.SetActive(false);
            bauxita.SetActive(false);
            bauxita_info.SetActive(false);
            bacterias.SetActive(false);
            bacteria_info.SetActive(false);
            geradorbiomassa.SetActive(true);
            geradorbiomassa_info.SetActive(true);
        }
    }

    public void Buttons_UI ()
    {
        if (botao_veiculo_selected)
            botao_base.Select();
        
    }

    public void Selected_Button_Base()
    {
        botao_base_selected = true;
        botao_planeta_selected = false;
        botao_veiculo_selected = false;
    }
    public void Selected_Button_Veiculo()
    {
        //botao_base_selected = false;
        botao_planeta_selected = false;
        botao_veiculo_selected = true;
    }
    public void Selected_Planeta_Base()
    {
        //botao_base_selected = false;
        botao_planeta_selected = true;
        botao_veiculo_selected = false;
    }

    //botoes de fwd e bckwds base
    public void FWD_Base ()
    {
        itens_base += 1;
    }

    public void BWD_Base()
    {
        itens_base -= 1;
    }
    //botoes de fwd e bckwds planeta
    public void FWD_Planeta()
    {
        itens_planeta += 1;
    }

    public void BWD_Planeta()
    {
        itens_planeta -= 1;
    }
    //botoes Gerais --
    public void Planeta_Selected ()
    {
        artefato_panel.SetActive(false);
        planeta_panel.SetActive(true);
        base_panel.SetActive(false);
        conjunto_3d_planeta.SetActive(true);
        conjunto_3d_base.SetActive(false);
        conjunto_info_base.SetActive(false);
        conjunto_info_planeta.SetActive(true);
        conjunto_3d_artefato.SetActive(false);
        conjunto_info_artefato.SetActive(false);
    }
    public void Base_Selected()
    {
        artefato_panel.SetActive(false);
        planeta_panel.SetActive(true);
        base_panel.SetActive(false);
        conjunto_3d_base.SetActive(true);
        conjunto_3d_planeta.SetActive(false);
        conjunto_info_base.SetActive(true);
        conjunto_info_planeta.SetActive(false);

        conjunto_3d_artefato.SetActive(false);
        conjunto_info_artefato.SetActive(false);
    }
    public void Artefato_Selected ()
    {
        planeta_panel.SetActive(false);
        base_panel.SetActive(false);

        artefato_panel.SetActive(true);
        conjunto_3d_artefato.SetActive(true);
        conjunto_info_artefato.SetActive(true);

        conjunto_3d_base.SetActive(false);
        conjunto_3d_planeta.SetActive(false);
        conjunto_info_base.SetActive(false);
        conjunto_info_planeta.SetActive(false);
    }


    //ESTADOS PARA OS OnClick()
    public void Estado_Veiculo()
    {
        estado = VEICULO;
        //ativa painel e 3d veiculo e etc...
    }
    public void Estado_Base()
    {
        estado = BASE;
    }
    public void Estado_Planeta()
    {
        estado = PLANETA;
    }
    public void Estado_Artefatos()
    {
        estado = ARTEFATOS;
    }
}
