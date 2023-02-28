using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NuevoHechizo : MonoBehaviour, IDataPersistance
{
    public Button boton1;
    public Button boton2;
    public Button boton3;
    public Button boton4;
    public Button boton5;
    public Button boton6;
    public Button boton7;
    public Button boton8;

    public Button hech1;
    public Button hech2;
    public Button hech3;
    public Button hech4;
    public Button hech5;
    public Button hech6;
    public Button hech7;
    public Button hech8;

    public GameObject boton1GO;
    public GameObject boton2GO;
    public GameObject boton3GO;
    public GameObject boton4GO;
    public GameObject boton5GO;
    public GameObject boton6GO;
    public GameObject boton7GO;
    public GameObject boton8GO;

    public GameObject hech1GO;
    public GameObject hech2GO;
    public GameObject hech3GO;
    public GameObject hech4GO;
    public GameObject hech5GO;
    public GameObject hech6GO;
    public GameObject hech7GO;
    public GameObject hech8GO;

    public Text nomHech1;
    public Text nomHech2;
    public Text nomHech3;
    public Text nomHech4;
    public Text nomHech5;
    public Text nomHech6;
    public Text nomHech7;
    public Text nomHech8;

    public Text nomHechMenu;
    public Text descHechMenu;
    public Text costeHechMenu;
    public Text dadosHechMenu;
    public Button seleccionarBoton;

    public Button salirMenuSelecc;
    public Button salirMenuHechizo;

    public GameObject MenuSel;
    public GameObject MenuHech;

    int index;

    GameObject botonDesbloqAct;
    GameObject botonHechAct;

    public Personaje Personaje;
    public FuncHechizos FuncHechizos;

    public void CargarData(Personaje pers)
    {
        this.Personaje = pers;
    }

    public void GuardarData(Personaje pers)
    {
        pers = this.Personaje;
    }

    void Start()
    {
        boton1.onClick.AddListener(Bypass1);
        boton2.onClick.AddListener(Bypass2);
        boton3.onClick.AddListener(Bypass3);
        boton4.onClick.AddListener(Bypass4);
        boton5.onClick.AddListener(Bypass5);
        boton6.onClick.AddListener(Bypass6);
        boton7.onClick.AddListener(Bypass7);
        boton8.onClick.AddListener(Bypass8);
        hech1.onClick.AddListener(Bypass9);
        hech2.onClick.AddListener(Bypass10);
        hech3.onClick.AddListener(Bypass11);
        hech4.onClick.AddListener(Bypass12);
        hech5.onClick.AddListener(Bypass13);
        hech6.onClick.AddListener(Bypass14);
        hech7.onClick.AddListener(Bypass15);
        hech8.onClick.AddListener(Bypass16);

        seleccionarBoton.onClick.AddListener(SelecNuevoHech);

        salirMenuSelecc.onClick.AddListener(CerrarMenuSelec);
        salirMenuHechizo.onClick.AddListener(CerrarMenuHech);
    }

    public void IniciarMenuSelecc()
    {
        nomHech1.text = Personaje._clase.listaHechizosClase[0].nombreHechizo;
        nomHech2.text = Personaje._clase.listaHechizosClase[1].nombreHechizo;
        nomHech3.text = Personaje._clase.listaHechizosClase[2].nombreHechizo;
        nomHech4.text = Personaje._clase.listaHechizosClase[3].nombreHechizo;
        nomHech5.text = Personaje._clase.listaHechizosClase[4].nombreHechizo;
        nomHech6.text = Personaje._clase.listaHechizosClase[5].nombreHechizo;
        nomHech7.text = Personaje._clase.listaHechizosClase[6].nombreHechizo;
        nomHech8.text = Personaje._clase.listaHechizosClase[7].nombreHechizo;

        if(Personaje._clase.listaHechizosClase[0].nombreHechizo == ".")
        {
            hech1GO.SetActive(false);
        }
        if (Personaje._clase.listaHechizosClase[1].nombreHechizo == ".")
        {
            hech2GO.SetActive(false);
        }
        if (Personaje._clase.listaHechizosClase[2].nombreHechizo == ".")
        {
            hech3GO.SetActive(false);
        }
        if (Personaje._clase.listaHechizosClase[3].nombreHechizo == ".")
        {
            hech4GO.SetActive(false);
        }
        if (Personaje._clase.listaHechizosClase[4].nombreHechizo == ".")
        {
            hech5GO.SetActive(false);
        }
        if (Personaje._clase.listaHechizosClase[5].nombreHechizo == ".")
        {
            hech6GO.SetActive(false);
        }
        if (Personaje._clase.listaHechizosClase[6].nombreHechizo == ".")
        {
            hech7GO.SetActive(false);
        }
        if (Personaje._clase.listaHechizosClase[7].nombreHechizo == ".")
        {
            hech8GO.SetActive(false);
        }
    }

    void Bypass1()
    {
        EmpezarSelecc(boton1GO);
    }
    void Bypass2()
    {
        EmpezarSelecc(boton2GO);
    }
    void Bypass3()
    {
        EmpezarSelecc(boton3GO);
    }
    void Bypass4()
    {
        EmpezarSelecc(boton4GO);
    }
    void Bypass5()
    {
        EmpezarSelecc(boton5GO);
    }
    void Bypass6()
    {
        EmpezarSelecc(boton6GO);
    }
    void Bypass7()
    {
        EmpezarSelecc(boton7GO);
    }
    void Bypass8()
    {
        EmpezarSelecc(boton8GO);
    }
    void Bypass9()
    {
        AbrirMenuHech(hech1GO,0);
    }
    void Bypass10()
    {
        AbrirMenuHech(hech2GO,1);
    }
    void Bypass11()
    {
        AbrirMenuHech(hech3GO,2);
    }
    void Bypass12()
    {
        AbrirMenuHech(hech4GO,3);
    }
    void Bypass13()
    {
        AbrirMenuHech(hech5GO,4);
    }
    void Bypass14()
    {
        AbrirMenuHech(hech6GO,5);
    }
    void Bypass15()
    {
        AbrirMenuHech(hech7GO,6);
    }
    void Bypass16()
    {
        AbrirMenuHech(hech8GO,7);
    }

    void SelecNuevoHech()
    {
        int num = Personaje.hechizosGuard;
        string nombreHechizo = Personaje._clase.listaHechizosClase[index].nombreHechizo;
        string descHechizo = Personaje._clase.listaHechizosClase[index].descHechizo;
        string tipoHechizo = Personaje._clase.listaHechizosClase[index].tipoHechizo;
        int costeHechizo = Personaje._clase.listaHechizosClase[index].costeHechizo;
        int dadoHechizo = Personaje._clase.listaHechizosClase[index].dadoHechizo;
        Debug.Log(num);
        Personaje.listaHechizos[num].nombreHechizo = nombreHechizo;
        Personaje.listaHechizos[num].descHechizo = descHechizo;
        Personaje.listaHechizos[num].tipoHechizo = tipoHechizo;
        Personaje.listaHechizos[num].costeHechizo = costeHechizo;
        Personaje.listaHechizos[num].dadoHechizo = dadoHechizo;
        Personaje._clase.listaHechizosClase[index].nombreHechizo = ".";
        Personaje.hechizosGuard++;
        MenuHech.SetActive(false);
        MenuSel.SetActive(false);
        botonHechAct.SetActive(false);
        botonDesbloqAct.SetActive(false);
        FuncHechizos.ActHechiz(num);
    }

    public void ActHechiz(int n)
    {
        FuncHechizos.ActHechiz(n);
    }

    void EmpezarSelecc(GameObject botonAct)
    {
        botonDesbloqAct = botonAct;
        MenuSel.SetActive(true);
    }

    void AbrirMenuHech(GameObject botonHechizoAct, int indexHech)
    {
        index = indexHech;
        botonHechAct = botonHechizoAct;
        nomHechMenu.text = Personaje._clase.listaHechizosClase[index].nombreHechizo;
        descHechMenu.text = Personaje._clase.listaHechizosClase[index].descHechizo;
        costeHechMenu.text = "Coste: " + Personaje._clase.listaHechizosClase[index].costeHechizo + " PA";
        int dado = Personaje._clase.listaHechizosClase[index].dadoHechizo;
        if (dado == 0)
        {
            dadosHechMenu.text = "Dado: Ninguno";
        }
        else
        {
            dadosHechMenu.text = "Dado: d" + dado;
        }
        MenuHech.SetActive(true);
    }

    void CerrarMenuSelec()
    {
        MenuSel.SetActive(false);
    }

    void CerrarMenuHech()
    {
        MenuHech.SetActive(false);
    }
}
