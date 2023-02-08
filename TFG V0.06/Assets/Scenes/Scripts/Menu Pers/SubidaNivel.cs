using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubidaNivel : MonoBehaviour
{
    public GameObject menuSubNiv1;
    public Text nombreRaza1;
    public Button valorRaza1;
    public Text numRaza1;
    public Text bonoRaza1;
    public Text nombreRaza2;
    public Button valorRaza2;
    public Text numRaza2;
    public Text bonoRaza2;
    public Text nombreRaza3;
    public Button valorRaza3;
    public Text numRaza3;
    public Text bonoRaza3;

    public GameObject menuSubNiv2;
    public GameObject BotonesValores;
    public Button valorCorporal;
    public Button valorAlma;

    public GameObject valoresCuerpo;
    public Button valornoclase1;
    public Text numnoclase1;
    public Text bononoclase1;
    public Button valornoclase2;
    public Text numnoclase2;
    public Text bononoclase2;
    public Button valornoclase3;
    public Text numnoclase3;
    public Text bononoclase3;
    public Button valornoclase4;
    public Text numnoclase4;
    public Text bononoclase4;
    public Button volverCorporal;

    public GameObject valoresAlma;
    public Button valornoclase5;
    public Text numnoclase5;
    public Text bononoclase5;
    public Button valornoclase6;
    public Text numnoclase6;
    public Text bononoclase6;
    public Button valornoclase7;
    public Text numnoclase7;
    public Text bononoclase7;
    public Button valornoclase8;
    public Text numnoclase8;
    public Text bononoclase8;
    public Button volverAlma;

    public Text numDados;
    public Text nombreArma;
    public Text tipoDano;
    public Text dadosArmaEquipo;
    public Text dadosArma;

    public Personaje Personaje;
    public ValoresMenu ValoresMenu;
    public PCPA Puntos;
    public DesbloqHechiz DesbloqHechiz;
    public NuevoHechizo NuevoHechizo;
    public FuncHechizos FuncHechizos;

    // Start is called before the first frame update
    void Start()
    {
        IniciarBotonesMenuClase();
        IniciarBotonesMenuResto();
        ValoresMenu.IniciarValores();
        Puntos.ActPuntos();
        numDados.text = Personaje._otros.numDados.ToString();
        nombreArma.text = Personaje.ArmaEquipada.nombreArma;
        tipoDano.text = Personaje.ArmaEquipada.tipoArma;
        dadosArmaEquipo.text = "d" + Personaje.ArmaEquipada.dadoArma;
        dadosArma.text = "d" + Personaje.ArmaEquipada.dadoArma;
        DesbloqHechiz.DesblHechiz();
        NuevoHechizo.IniciarMenuSelecc();
    }

    void IniciarBotonesMenuClase()
    {
        valorRaza1.onClick.AddListener(Bypass1);
        valorRaza2.onClick.AddListener(Bypass2);
        valorRaza3.onClick.AddListener(Bypass3);
    }

    void IniciarBotonesMenuResto()
    {
        valornoclase1.onClick.AddListener(Bypass4);
        valornoclase2.onClick.AddListener(Bypass5);
        valornoclase3.onClick.AddListener(Bypass6);
        valornoclase4.onClick.AddListener(Bypass7);
        valornoclase5.onClick.AddListener(Bypass8);
        valornoclase6.onClick.AddListener(Bypass9);
        valornoclase7.onClick.AddListener(Bypass10);
        valornoclase8.onClick.AddListener(Bypass11);
        valorCorporal.onClick.AddListener(AbrirValoresCuerpo);
        valorAlma.onClick.AddListener(AbrirValoresAlma);
        volverCorporal.onClick.AddListener(CerrarValoresCuerpo);
        volverAlma.onClick.AddListener(CerrarValoresAlma);
    }

    void Bypass1()
    {
        Personaje.ActualizarValor(nombreRaza1.text, 1);
        ActMenuValores(nombreRaza1.text);
        SubirNivel2();
    }

    void Bypass2()
    {
        Personaje.ActualizarValor(nombreRaza2.text, 1);
        ActMenuValores(nombreRaza2.text);
        SubirNivel2();
    }

    void Bypass3()
    {
        Personaje.ActualizarValor(nombreRaza3.text, 1);
        ActMenuValores(nombreRaza3.text);
        SubirNivel2();
    }

    void Bypass4()
    {
        Personaje.ActualizarValor("FUERZA", 1);
        ActMenuValores("FUERZA");
        SubirNivel3();
    }

    void Bypass5()
    {
        Personaje.ActualizarValor("RESISTENCIA", 1);
        ActMenuValores("RESISTENCIA");
        SubirNivel3();
    }

    void Bypass6()
    {
        Personaje.ActualizarValor("AGILIDAD", 1);
        ActMenuValores("AGILIDAD");
        SubirNivel3();
    }

    void Bypass7()
    {
        Personaje.ActualizarValor("VELOCIDAD", 1);
        ActMenuValores("VELOCIDAD");
        SubirNivel3();
    }

    void Bypass8()
    {
        Personaje.ActualizarValor("PODER", 1);
        ActMenuValores("PODER");
        SubirNivel3();
    }

    void Bypass9()
    {
        Personaje.ActualizarValor("SENTIDOS", 1);
        ActMenuValores("SENTIDOS");
        SubirNivel3();
    }

    void Bypass10()
    {
        Personaje.ActualizarValor("MEMORIA", 1);
        ActMenuValores("MEMORIA");
        SubirNivel3();
    }

    void Bypass11()
    {
        Personaje.ActualizarValor("PERSONALIDAD", 1);
        ActMenuValores("PERSONALIDAD");
        SubirNivel3();
    }

    public void SubirNivel()
    {
        Personaje.ActualizarValor(Personaje._clase.valorClase, 2);
        ActMenuValores(Personaje._clase.valorClase);

        //Cambiar nombres, numeros y bonos de cada valor 
        nombreRaza1.text = Personaje.ElemRaza("valor1");
        int valorAct1 = Personaje.Valor(Personaje.ElemRaza("valor1"));
        int bonoAct1 = Personaje.BonoValor(Personaje.ElemRaza("valor1"));
        int valorSumado1 = valorAct1 + 1;
        int bonoSumado1;
        if (valorSumado1 >= 8) { bonoSumado1 = (valorSumado1 - 8) / 2; }
        else { bonoSumado1 = (valorSumado1 - 9) / 2; }
        numRaza1.text = Personaje.Valor(Personaje.ElemRaza("valor1")) + " > " + valorSumado1;
        bonoRaza1.text = bonoAct1 + " > " + bonoSumado1;

        nombreRaza2.text = Personaje.ElemRaza("valor2");
        int valorAct2 = Personaje.Valor(Personaje.ElemRaza("valor2"));
        int bonoAct2 = Personaje.BonoValor(Personaje.ElemRaza("valor2"));
        int valorSumado2 = valorAct2 + 1;
        int bonoSumado2;
        if (valorSumado2 >= 8) { bonoSumado2 = (valorSumado2 - 8) / 2; }
        else { bonoSumado2 = (valorSumado2 - 9) / 2; }
        numRaza2.text = Personaje.Valor(Personaje.ElemRaza("valor2")) + " > " + valorSumado2;
        bonoRaza2.text = bonoAct2 + " > " + bonoSumado2;

        nombreRaza3.text = Personaje.ElemRaza("valor3");
        int valorAct3 = Personaje.Valor(Personaje.ElemRaza("valor3"));
        int bonoAct3 = Personaje.BonoValor(Personaje.ElemRaza("valor3"));
        int valorSumado3 = valorAct3 + 1;
        int bonoSumado3;
        if (valorSumado3 >= 8) { bonoSumado3 = (valorSumado3 - 8) / 2; }
        else { bonoSumado3 = (valorSumado3 - 9) / 2; }
        numRaza3.text = Personaje.Valor(Personaje.ElemRaza("valor3")) + " > " + valorSumado3;
        bonoRaza3.text = bonoAct3 + " > " + bonoSumado3;

        menuSubNiv1.SetActive(true);
    }

    public void SubirNivel2()
    {
        //Cambiar nombres, numeros y bonos de cada valor 
        int novalorAct1 = Personaje.Valor("FUERZA");
        int nobonoAct1 = Personaje.BonoValor("FUERZA");
        int novalorSumado1 = novalorAct1 + 1;
        int nobonoSumado1;
        if (novalorSumado1 >= 8) { nobonoSumado1 = (novalorSumado1 - 8) / 2; }
        else { nobonoSumado1 = (novalorSumado1 - 9) / 2; }
        numnoclase1.text = Personaje.Valor("FUERZA") + " > " + novalorSumado1;
        bononoclase1.text = nobonoAct1 + " > " + nobonoSumado1;

        int novalorAct2 = Personaje.Valor("RESISTENCIA");
        int nobonoAct2 = Personaje.BonoValor("RESISTENCIA");
        int novalorSumado2 = novalorAct2 + 1;
        int nobonoSumado2;
        if (novalorSumado2 >= 8) { nobonoSumado2 = (novalorSumado2 - 8) / 2; }
        else { nobonoSumado2 = (novalorSumado2 - 9) / 2; }
        numnoclase2.text = Personaje.Valor("RESISTENCIA") + " > " + novalorSumado2;
        bononoclase2.text = nobonoAct2 + " > " + nobonoSumado2;

        int novalorAct3 = Personaje.Valor("AGILIDAD");
        int nobonoAct3 = Personaje.BonoValor("AGILIDAD");
        int novalorSumado3 = novalorAct3 + 1;
        int nobonoSumado3;
        if (novalorSumado3 >= 8) { nobonoSumado3 = (novalorSumado3 - 8) / 2; }
        else { nobonoSumado3 = (novalorSumado3 - 9) / 2; }
        numnoclase3.text = Personaje.Valor("AGILIDAD") + " > " + novalorSumado3;
        bononoclase3.text = nobonoAct3 + " > " + nobonoSumado3;

        int novalorAct4 = Personaje.Valor("VELOCIDAD");
        int nobonoAct4 = Personaje.BonoValor("VELOCIDAD");
        int novalorSumado4 = novalorAct4 + 1;
        int nobonoSumado4;
        if (novalorSumado4 >= 8) { nobonoSumado4 = (novalorSumado4 - 8) / 2; }
        else { nobonoSumado4 = (novalorSumado4 - 9) / 2; }
        numnoclase4.text = Personaje.Valor("VELOCIDAD") + " > " + novalorSumado4;
        bononoclase4.text = nobonoAct4 + " > " + nobonoSumado4;

        int novalorAct5 = Personaje.Valor("PODER");
        int nobonoAct5 = Personaje.BonoValor("PODER");
        int novalorSumado5 = novalorAct5 + 1;
        int nobonoSumado5;
        if (novalorSumado5 >= 8) { nobonoSumado5 = (novalorSumado5 - 8) / 2; }
        else { nobonoSumado5 = (novalorSumado5 - 9) / 2; }
        numnoclase5.text = Personaje.Valor("PODER") + " > " + novalorSumado5;
        bononoclase5.text = nobonoAct5 + " > " + nobonoSumado5;

        int novalorAct6 = Personaje.Valor("SENTIDOS");
        int nobonoAct6 = Personaje.BonoValor("SENTIDOS");
        int novalorSumado6 = novalorAct6 + 1;
        int nobonoSumado6;
        if (novalorSumado6 >= 8) { nobonoSumado6 = (novalorSumado6 - 8) / 2; }
        else { nobonoSumado6 = (novalorSumado6 - 9) / 2; }
        numnoclase6.text = Personaje.Valor("SENTIDOS") + " > " + novalorSumado6;
        bononoclase6.text = nobonoAct6 + " > " + nobonoSumado6;

        int novalorAct7 = Personaje.Valor("MEMORIA");
        int nobonoAct7 = Personaje.BonoValor("MEMORIA");
        int novalorSumado7 = novalorAct7 + 1;
        int nobonoSumado7;
        if (novalorSumado7 >= 8) { nobonoSumado7 = (novalorSumado7 - 8) / 2; }
        else { nobonoSumado7 = (novalorSumado7 - 9) / 2; }
        numnoclase7.text = Personaje.Valor("MEMORIA") + " > " + novalorSumado7;
        bononoclase7.text = nobonoAct7 + " > " + nobonoSumado7;

        int novalorAct8 = Personaje.Valor("PERSONALIDAD");
        int nobonoAct8 = Personaje.BonoValor("PERSONALIDAD");
        int novalorSumado8 = novalorAct8 + 1;
        int nobonoSumado8;
        if (novalorSumado8 >= 8) { nobonoSumado8 = (novalorSumado8 - 8) / 2; }
        else { nobonoSumado8 = (novalorSumado8 - 9) / 2; }
        numnoclase8.text = Personaje.Valor("PERSONALIDAD") + " > " + novalorSumado8;
        bononoclase8.text = nobonoAct8 + " > " + nobonoSumado8;

        menuSubNiv1.SetActive(false);
        menuSubNiv2.SetActive(true);
    }

    
    public void SubirNivel3()
    {
        numDados.text = Personaje._otros.numDados.ToString();
        menuSubNiv2.SetActive(false);
        valoresCuerpo.SetActive(false);
        BotonesValores.SetActive(true);
        valoresAlma.SetActive(false);
        Puntos.ActPuntos();
        DesbloqHechiz.DesblHechiz();
        for (int i = 0; i < Personaje.hechizosGuard; i++)
        {
            FuncHechizos.ActHechiz(i);
        }
    }

    void AbrirValoresCuerpo()
    {
        BotonesValores.SetActive(false);
        valoresCuerpo.SetActive(true);
    }

    void AbrirValoresAlma()
    {
        BotonesValores.SetActive(false);
        valoresAlma.SetActive(true);
    }

    void CerrarValoresCuerpo()
    {
        valoresCuerpo.SetActive(false);
        BotonesValores.SetActive(true);
    }

    void CerrarValoresAlma()
    {
        valoresAlma.SetActive(false);
        BotonesValores.SetActive(true);
    }

    void ActMenuValores(string valor)
    {
        int valorFinal = Personaje.Valor(valor);
        int bonoFinal = Personaje.BonoValor(valor);
        ValoresMenu.ActValor(valor, valorFinal, bonoFinal);
    }
}
