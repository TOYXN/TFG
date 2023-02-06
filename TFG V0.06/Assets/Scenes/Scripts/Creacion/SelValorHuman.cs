using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelValorHuman : MonoBehaviour
{
    int numselec;
    public GameObject MenuValores;
    public Text descPaso;
    public GameObject ParteBotones;
    public Button ValoresCorporales;
    public Button ValoresAlmaticos;

    public GameObject ParteCuerpo;
    public Button Valor1;
    public GameObject Valor1GO;
    public Text numValor1;
    public Text bonoValor1;
    public Button Valor2;
    public GameObject Valor2GO;
    public Text numValor2;
    public Text bonoValor2;
    public Button Valor3;
    public GameObject Valor3GO;
    public Text numValor3;
    public Text bonoValor3;
    public Button Valor4;
    public GameObject Valor4GO;
    public Text numValor4;
    public Text bonoValor4;
    public Button VolverCuerpo;

    public GameObject ParteAlma;
    public Button Valor5;
    public GameObject Valor5GO;
    public Text numValor5;
    public Text bonoValor5;
    public Button Valor6;
    public GameObject Valor6GO;
    public Text numValor6;
    public Text bonoValor6;
    public Button Valor7;
    public GameObject Valor7GO;
    public Text numValor7;
    public Text bonoValor7;
    public Button Valor8;
    public GameObject Valor8GO;
    public Text numValor8;
    public Text bonoValor8;
    public Button VolverAlma;

    public Text NombreRaza;
    public Text DescRaza;
    public Text ExplicacionPaso;
    public GameObject ExplicacionPasoGO;
    public GameObject MenuRazaSelec;
    public GameObject menuRazas;
    public GameObject continuar3GO;


    public Personaje Personaje;
    // Start is called before the first frame update
    void Start()
    {
        ValoresCorporales.onClick.AddListener(AbrirValoresCuerpo);
        ValoresAlmaticos.onClick.AddListener(AbrirValoresAlma);
        IniciarBotonesValores();
        VolverCuerpo.onClick.AddListener(CerrarValoresCuerpo);
        VolverAlma.onClick.AddListener(CerrarValoresAlma);
    }

    void AbrirValoresCuerpo()
    {
        ParteBotones.SetActive(false);
        Valor1GO.SetActive(true);
        Valor2GO.SetActive(true);
        Valor3GO.SetActive(true);
        Valor4GO.SetActive(true);
        ParteCuerpo.SetActive(true);
    }

    void AbrirValoresAlma()
    {
        ParteBotones.SetActive(false);
        Valor5GO.SetActive(true);
        Valor6GO.SetActive(true);
        Valor7GO.SetActive(true);
        Valor8GO.SetActive(true);
        ParteAlma.SetActive(true);
    }

    void CerrarValoresCuerpo()
    {
        ParteCuerpo.SetActive(false);
        ParteBotones.SetActive(true);
    }

    void CerrarValoresAlma()
    {
        ParteAlma.SetActive(false);
        ParteBotones.SetActive(true);
    }

    void IniciarBotonesValores()
    {
        Valor1.onClick.AddListener(Bypass1);
        Valor2.onClick.AddListener(Bypass2);
        Valor3.onClick.AddListener(Bypass3);
        Valor4.onClick.AddListener(Bypass4);
        Valor5.onClick.AddListener(Bypass5);
        Valor6.onClick.AddListener(Bypass6);
        Valor7.onClick.AddListener(Bypass7);
        Valor8.onClick.AddListener(Bypass8);
    }

    void Bypass1()
    {
        SeleccionarValor("FUERZA", Valor1GO);
    }

    void Bypass2()
    {
        SeleccionarValor("RESISTENCIA", Valor2GO);
    }

    void Bypass3()
    {
        SeleccionarValor("AGILIDAD", Valor3GO);
    }

    void Bypass4()
    {
        SeleccionarValor("VELOCIDAD", Valor4GO);
    }

    void Bypass5()
    {
        SeleccionarValor("PODER", Valor5GO);
    }

    void Bypass6()
    {
        SeleccionarValor("SENTIDOS", Valor6GO);
    }

    void Bypass7()
    {
        SeleccionarValor("MEMORIA", Valor7GO);
    }

    void Bypass8()
    {
        SeleccionarValor("PERSONALIDAD", Valor8GO);
    }

    void SeleccionarValor(string valor, GameObject objetoValor)
    {
        if (numselec == 0)
        {
            Personaje._raza.valorPrincipal = valor;
            Personaje.ActualizarValor(valor, 2);
            descPaso.text = "Selecciona cual Valor quieres añadir +1";
            CalcularValoresSelec();
        }
        else if (numselec == 1)
        {
            Personaje._raza.valorSecundario = valor;
            Personaje.ActualizarValor(valor, 1);
        }
        else
        {
            Personaje._raza.valorTerciario = valor;
            Personaje.ActualizarValor(valor, 1);
            SeleccionRaza();
        }
        objetoValor.SetActive(false);
        numselec++;
    }

    void SeleccionRaza()
    {
        Personaje._raza.nombreRaza = NombreRaza.text;
        Personaje._raza.descRaza = DescRaza.text;
        MenuRazaSelec.SetActive(false);
        menuRazas.SetActive(false);
        ExplicacionPaso.text = "Raza seleccionada:\n\n " + NombreRaza.text;
        MenuValores.SetActive(false);
        ExplicacionPasoGO.SetActive(true);
        continuar3GO.SetActive(true);
    }

    public void SelecValores()
    {
        numselec = 0;
        CalcularValoresInicio();
        MenuValores.SetActive(true);
    }

    void CalcularValoresInicio()
    {
        CalcularValores2("FUERZA", numValor1, bonoValor1);
        CalcularValores2("RESISTENCIA", numValor2, bonoValor2);
        CalcularValores2("AGILIDAD", numValor3, bonoValor3);
        CalcularValores2("VELOCIDAD", numValor4, bonoValor4);
        CalcularValores2("PODER", numValor5, bonoValor5);
        CalcularValores2("SENTIDOS", numValor6, bonoValor6);
        CalcularValores2("MEMORIA", numValor7, bonoValor7);
        CalcularValores2("PERSONALIDAD", numValor8, bonoValor8);
    }

    void CalcularValoresSelec()
    {
        CalcularValores1("FUERZA", numValor1, bonoValor1);
        CalcularValores1("RESISTENCIA", numValor2, bonoValor2);
        CalcularValores1("AGILIDAD", numValor3, bonoValor3);
        CalcularValores1("VELOCIDAD", numValor4, bonoValor4);
        CalcularValores1("PODER", numValor5, bonoValor5);
        CalcularValores1("SENTIDOS", numValor6, bonoValor6);
        CalcularValores1("MEMORIA", numValor7, bonoValor7);
        CalcularValores1("PERSONALIDAD", numValor8, bonoValor8);
    }

    void CalcularValores1(string Valor, Text valorText, Text bonoText)
    {

        int Val = Personaje.Valor(Valor);
        int Bon = Personaje.BonoValor(Valor);
        int ValSum = Val + 1;
        int BonoSum;
        if (ValSum >= 8) { BonoSum = (ValSum - 8) / 2; }
        else { BonoSum = (ValSum - 9) / 2; }

        valorText.text = Val + " > " + ValSum;
        bonoText.text = Bon + " > " + BonoSum;
    }

    void CalcularValores2(string Valor, Text valorText, Text bonoText)
    {
        
        int Val = Personaje.Valor(Valor);
        int Bon = Personaje.BonoValor(Valor);
        int ValSum = Val + 2;
        int BonoSum;
        if (ValSum >= 8) { BonoSum = (ValSum - 8) / 2; }
        else { BonoSum = (ValSum - 9) / 2; }

        valorText.text = Val + " > " + ValSum;
        bonoText.text = Bon + " > " + BonoSum;
    }
}
