using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso5_4 : MonoBehaviour, IDataPersistance
{
    public GameObject MenuSeleccion;
    public Button Arma1Boton;
    public Button Arma2Boton;
    public Button Arma3Boton;
    public Button Arma4Boton;
    public Button Arma5Boton;
    public Button Arma6Boton;

    public GameObject MenuArmaSelec;
    public Text NombreArma;
    public Text DescArma;
    public Text NombreOpcionalArma;
    public Text DadoArma;
    public Text TipoArma;
    
    public Button BotonSeleccionarArma;
    public Button CerrarMenuArma;

    public Text TextoFinal;
    public Text TextoFinalSombra;
    public GameObject TextoFinalGO;

    public GameObject ContinuarGO;
    public Personaje Personaje;

    int dado;
    string tipo;

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
        IniciarBotonesArma();
        IniciarBotonesMenu();
    }

    void IniciarBotonesArma()
    {
        Arma1Boton.onClick.AddListener(AbrirMenu1);
        Arma2Boton.onClick.AddListener(AbrirMenu2);
        Arma3Boton.onClick.AddListener(AbrirMenu3);
        Arma4Boton.onClick.AddListener(AbrirMenu4);
        Arma5Boton.onClick.AddListener(AbrirMenu5);
        Arma6Boton.onClick.AddListener(AbrirMenu6);
    }

    void AbrirMenu1()
    {
        dado = Personaje._clase.listaArmasClase[0].dadoArma;
        tipo = Personaje._clase.listaArmasClase[0].tipoArma;
        NombreArma.text = Personaje._clase.listaArmasClase[0].nombreArma;
        DescArma.text = Personaje._clase.listaArmasClase[0].descArma;
        DadoArma.text = "Dado Vinculante:\n d" + dado;
        TipoArma.text = "Tipo Daño:\n " + tipo;
        MenuArmaSelec.SetActive(true);
    }
    void AbrirMenu2()
    {
        dado = Personaje._clase.listaArmasClase[1].dadoArma;
        tipo = Personaje._clase.listaArmasClase[1].tipoArma;
        NombreArma.text = Personaje._clase.listaArmasClase[1].nombreArma;
        DescArma.text = Personaje._clase.listaArmasClase[1].descArma;
        DadoArma.text = "Dado Vinculante:\n d" + dado;
        TipoArma.text = "Tipo Daño:\n " + tipo;
        MenuArmaSelec.SetActive(true);
    }
    void AbrirMenu3()
    {
        dado = Personaje._clase.listaArmasClase[2].dadoArma;
        tipo = Personaje._clase.listaArmasClase[2].tipoArma;
        NombreArma.text = Personaje._clase.listaArmasClase[2].nombreArma;
        DescArma.text = Personaje._clase.listaArmasClase[2].descArma;
        DadoArma.text = "Dado Vinculante:\n d" + dado;
        TipoArma.text = "Tipo Daño:\n " + tipo;
        MenuArmaSelec.SetActive(true);
    }
    void AbrirMenu4()
    {
        dado = Personaje._clase.listaArmasClase[3].dadoArma;
        tipo = Personaje._clase.listaArmasClase[3].tipoArma;
        NombreArma.text = Personaje._clase.listaArmasClase[3].nombreArma;
        DescArma.text = Personaje._clase.listaArmasClase[3].descArma;
        DadoArma.text = "Dado Vinculante:\n d" + dado;
        TipoArma.text = "Tipo Daño:\n " + tipo;
        MenuArmaSelec.SetActive(true);
    }
    void AbrirMenu5()
    {
        dado = Personaje._clase.listaArmasClase[4].dadoArma;
        tipo = Personaje._clase.listaArmasClase[4].tipoArma;
        NombreArma.text = Personaje._clase.listaArmasClase[4].nombreArma;
        DescArma.text = Personaje._clase.listaArmasClase[4].descArma;
        DadoArma.text = "Dado Vinculante:\n d" + dado;
        TipoArma.text = "Tipo Daño:\n " + tipo;
        MenuArmaSelec.SetActive(true);
    }
    void AbrirMenu6()
    {
        dado = Personaje._clase.listaArmasClase[5].dadoArma;
        tipo = Personaje._clase.listaArmasClase[5].tipoArma;
        NombreArma.text = Personaje._clase.listaArmasClase[5].nombreArma;
        DescArma.text = Personaje._clase.listaArmasClase[5].descArma;
        DadoArma.text = "Dado Vinculante:\n d" + dado;
        TipoArma.text = "Tipo Daño:\n " + tipo;
        MenuArmaSelec.SetActive(true);
    }

    void IniciarBotonesMenu()
    {
        BotonSeleccionarArma.onClick.AddListener(SelecArma);
        CerrarMenuArma.onClick.AddListener(CerrarArma);
    }
    void CerrarArma()
    {
        MenuArmaSelec.SetActive(false);
    }
    void SelecArma()
    {
        Personaje.ArmaEquipada.descArma = DescArma.text;
        Personaje.ArmaEquipada.dadoArma = dado;
        Personaje.ArmaEquipada.tipoArma = tipo;
        Debug.Log(NombreOpcionalArma.text);
        if(NombreOpcionalArma.text == "")
        {
            Personaje.ArmaEquipada.nombreArma = NombreArma.text;
        }
        else
        {
            Personaje.ArmaEquipada.nombreArma = NombreOpcionalArma.text;
        }
        MenuArmaSelec.SetActive(false);
        MenuSeleccion.SetActive(false);
        int bono;
        string calculo = " ";
        if (tipo == "FUERZA")
        {
            bono = Personaje.BonoValor("FUERZA");
            if (bono >= 0) { calculo = "d" + dado + "+" + bono; }
            else { calculo = "d" + dado + bono; }
        }
        else if (tipo == "AGILIDAD")
        {
            bono = Personaje.BonoValor("AGILIDAD");
            if (bono >= 0) { calculo = "d" + dado + "+" + bono; }
            else { calculo = "d" + dado + bono; }
        }
        TextoFinal.text = "Arma seleccionada:\n" + Personaje.ArmaEquipada.nombreArma + "\n\nCálculo actual de daño:\n" + calculo;
        TextoFinalSombra.text = "Arma seleccionada:\n" + Personaje.ArmaEquipada.nombreArma + "\n\nCálculo actual de daño:\n" + calculo;
        TextoFinalGO.SetActive(true);
        ContinuarGO.SetActive(true);
        //DataPersistanceManager.instance.ActualizarPersonaje(Personaje);
    }
}
