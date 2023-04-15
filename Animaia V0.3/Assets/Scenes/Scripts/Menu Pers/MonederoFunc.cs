using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonederoFunc : MonoBehaviour, IDataPersistance
{
    public Button Ayuda;
    public Button BotonPaladio;
    public Button BotonPlatino;
    public Button BotonOro;
    public Button BotonPlata;
    private int Paladio;
    private int Platino;
    private int Oro;
    private int Plata;
    public Text NumPaladio;
    public Text NumPlatino;
    public Text NumOro;
    public Text NumPlata;
    public GameObject menuAyuda;
    public Button CerrarMenuAyuda;
    public GameObject menuMoneda;
    public Text TituloMon;
    public Text DescMon;
    public Text MonAct;
    public Text MonVariar;
    public Button BotonSumar;
    public Button BotonRestar;
    public Button CerrarMenuMon;

    public Personaje Personaje;

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
        IniciarMonedas();
        BotonSumar.onClick.AddListener(SumarMoneda);
        BotonRestar.onClick.AddListener(RestarMoneda);
        CerrarMenuMon.onClick.AddListener(CerrarMenuMonedas);
        Ayuda.onClick.AddListener(AbrirMenuAyu);
        CerrarMenuAyuda.onClick.AddListener(CerrarMenuAyu);
    }

    void IniciarMonedas()
    {
        Paladio = Personaje._monedero.Paladio;
        Platino = Personaje._monedero.Platino;
        Oro = Personaje._monedero.Oro;
        Plata = Personaje._monedero.Plata;
        NumPaladio.text = Paladio.ToString();
        NumPlatino.text = Platino.ToString();
        NumOro.text = Oro.ToString();
        NumPlata.text = Plata.ToString();
        BotonPaladio.onClick.AddListener(MenuPaladio);
        BotonPlatino.onClick.AddListener(MenuPlatino);
        BotonOro.onClick.AddListener(MenuOro);
        BotonPlata.onClick.AddListener(MenuPlata);
    }

    void MenuPaladio()
    {
        TituloMon.text = "PALADIO";
        DescMon.text = "La moneda mas valiosa de todas. Su uso se reserva para transacciones de propiedades de altísimo valor. Una moneda de Paladio equivale a 10 de Platino";
        MonAct.text = "Cantidad Actual: " + Paladio;
        menuMoneda.SetActive(true);
    }   

    void MenuPlatino()
    {
        TituloMon.text = "PLATINO";
        DescMon.text = "Moneda de gran valor, usada mayoritariamente para grandes transacciones. Una sola moneda puede considerarse una pequeña fortuna. Una moneda de Platino equivale a 10 de Oro.";
        MonAct.text = "Cantidad Actual: " + Platino;
        menuMoneda.SetActive(true);
    }

    void MenuOro()
    {
        TituloMon.text = "ORO";
        DescMon.text = "La moneda más popular por su color distintivo al resto de monedas y por su gran uso comercial, ya que es la más común. Una moneda de Oro equivale a 10 de Plata.";
        MonAct.text = "Cantidad Actual: " + Oro;
        menuMoneda.SetActive(true);
    }

    void MenuPlata()
    {
        TituloMon.text = "PLATA";
        DescMon.text = "La moneda de valor base en el mundo, utilizada sobretodo para pequeñas transacciones. Todos los precios se basan en el número de monedas de plata necesarias para completar la transacción.";
        MonAct.text = "Cantidad Actual: " + Plata;
        menuMoneda.SetActive(true);
    }

    void SumarMoneda()
    {
        int valorEntrado;
        int.TryParse(MonVariar.text, out valorEntrado);
        if(TituloMon.text == "PALADIO")
        {
            Paladio = Paladio + valorEntrado;
            MonAct.text = "Cantidad Actual: " + Paladio;
            NumPaladio.text = Paladio.ToString();
        }
        else if (TituloMon.text == "PLATINO")
        {
            Platino = Platino + valorEntrado;
            MonAct.text = "Cantidad Actual: " + Platino;
            NumPlatino.text = Platino.ToString();
        }
        else if (TituloMon.text == "ORO")
        {
            Oro = Oro + valorEntrado;
            MonAct.text = "Cantidad Actual: " + Oro;
            NumOro.text = Oro.ToString();
        }
        else if (TituloMon.text == "PLATA")
        {
            Plata = Plata + valorEntrado;
            MonAct.text = "Cantidad Actual: " + Plata;
            NumPlata.text = Plata.ToString();
        }
        ActMonederoPers();
    }

    void RestarMoneda()
    {
        int valorEntrado;
        int.TryParse(MonVariar.text, out valorEntrado);
        if (TituloMon.text == "PALADIO")
        {
            if( valorEntrado >= Paladio) { Paladio = 0; }
            else { Paladio = Paladio - valorEntrado; }
            
            MonAct.text = "Cantidad Actual: " + Paladio;
            NumPaladio.text = Paladio.ToString();
        }
        else if (TituloMon.text == "PLATINO")
        {
            if (valorEntrado >= Platino) { Platino = 0; }
            else { Platino = Platino - valorEntrado; }
            MonAct.text = "Cantidad Actual: " + Platino;
            NumPlatino.text = Platino.ToString();
        }
        else if (TituloMon.text == "ORO")
        {
            if (valorEntrado >= Oro) { Oro = 0; }
            else { Oro = Oro - valorEntrado; }
            MonAct.text = "Cantidad Actual: " + Oro;
            NumOro.text = Oro.ToString();
        }
        else if (TituloMon.text == "PLATA")
        {
            if (valorEntrado >= Plata) { Plata = 0; }
            else { Plata = Plata - valorEntrado; }
            MonAct.text = "Cantidad Actual: " + Plata;
            NumPlata.text = Plata.ToString();
        }
        ActMonederoPers();
    }

    void CerrarMenuMonedas()
    {
        menuMoneda.SetActive(false);
    }

    void AbrirMenuAyu()
    {
        menuAyuda.SetActive(true);
    }

    void CerrarMenuAyu()
    {
        menuAyuda.SetActive(false);
    }

    void ActMonederoPers()
    {
        Personaje._monedero.Paladio = Paladio;
        Personaje._monedero.Platino = Platino;
        Personaje._monedero.Oro = Oro;
        Personaje._monedero.Plata = Plata;
    }

}
