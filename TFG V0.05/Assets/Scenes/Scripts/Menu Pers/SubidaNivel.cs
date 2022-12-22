using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubidaNivel : MonoBehaviour
{
    public GameObject menuSubNiv1;
    public Text nombreClase1;
    public Button valorClase1;
    public Text numClase1;
    public Text bonoClase1;
    public Text nombreClase2;
    public Button valorClase2;
    public Text numClase2;
    public Text bonoClase2;

    public GameObject menuSubNiv2;
    public Text nombrenoclase1;
    public Button valornoclase1;
    public Text numnoclase1;
    public Text bononoclase1;
    public Text nombrenoclase2;
    public Button valornoclase2;
    public Text numnoclase2;
    public Text bononoclase2;
    public Text nombrenoclase3;
    public Button valornoclase3;
    public Text numnoclase3;
    public Text bononoclase3;
    public Text nombrenoclase4;
    public Button valornoclase4;
    public Text numnoclase4;
    public Text bononoclase4;
    public Text nombrenoclase5;
    public Button valornoclase5;
    public Text numnoclase5;
    public Text bononoclase5;
    public Text nombrenoclase6;
    public Button valornoclase6;
    public Text numnoclase6;
    public Text bononoclase6;

    public GameObject menuSubNiv3;
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

    public Text numDados;
    public Text dadosArma;

    public Personaje Personaje;
    public Arma Arma;
    public ValoresMenu ValoresMenu;
    public PCPA Puntos;

    // Start is called before the first frame update
    void Start()
    {
        valorClase1.onClick.AddListener(Bypass1);
        valorClase2.onClick.AddListener(Bypass2);
        valornoclase1.onClick.AddListener(Bypass3);
        valornoclase2.onClick.AddListener(Bypass4);
        valornoclase3.onClick.AddListener(Bypass5);
        valornoclase4.onClick.AddListener(Bypass6);
        valornoclase5.onClick.AddListener(Bypass7);
        valornoclase6.onClick.AddListener(Bypass8);
        valorRaza1.onClick.AddListener(Bypass9);
        valorRaza2.onClick.AddListener(Bypass10);
        valorRaza3.onClick.AddListener(Bypass11);
        ValoresMenu.IniciarValores();
        Puntos.ActPuntos();
        numDados.text = Personaje._otros.numDados.ToString();
        dadosArma.text = "d" + Arma.dadoArma;
    }

    void Bypass1()
    {
        Personaje.ActualizarValor(nombreClase1.text, 2);
        ActMenuValores(nombreClase1.text);
        SubirNivel2();
    }

    void Bypass2()
    {
        Personaje.ActualizarValor(nombreClase2.text, 2);
        ActMenuValores(nombreClase2.text);
        SubirNivel2();
    }

    void Bypass3()
    {
        Personaje.ActualizarValor(nombrenoclase1.text, 1);
        ActMenuValores(nombrenoclase1.text);
        SubirNivel3();
    }

    void Bypass4()
    {
        Personaje.ActualizarValor(nombrenoclase2.text, 1);
        ActMenuValores(nombrenoclase2.text);
        SubirNivel3();
    }

    void Bypass5()
    {
        Personaje.ActualizarValor(nombrenoclase3.text, 1);
        ActMenuValores(nombrenoclase3.text);
        SubirNivel3();
    }

    void Bypass6()
    {
        Personaje.ActualizarValor(nombrenoclase4.text, 1);
        ActMenuValores(nombrenoclase4.text);
        SubirNivel3();
    }

    void Bypass7()
    {
        Personaje.ActualizarValor(nombrenoclase5.text, 1);
        ActMenuValores(nombrenoclase5.text);
        SubirNivel3();
    }

    void Bypass8()
    {
        Personaje.ActualizarValor(nombrenoclase6.text, 1);
        ActMenuValores(nombrenoclase6.text);
        SubirNivel3();
    }

    void Bypass9()
    {
        Personaje.ActualizarValor(nombreRaza1.text, 1);
        ActMenuValores(nombreRaza1.text);
        SubirNivel4();
    }

    void Bypass10()
    {
        Personaje.ActualizarValor(nombreRaza2.text, 1);
        ActMenuValores(nombreRaza2.text);
        SubirNivel4();
    }

    void Bypass11()
    {
        Personaje.ActualizarValor(nombreRaza3.text, 1);
        ActMenuValores(nombreRaza3.text);
        SubirNivel4();
    }

    public void SubirNivel()
    {
        //Cambiar nombres, numeros y bonos de cada valor
        nombreClase1.text = Personaje.ElemClase("valor1");
        int valorAct1 = Personaje.Valor(Personaje.ElemClase("valor1"));
        int bonoAct1 = Personaje.BonoValor(Personaje.ElemClase("valor1"));
        int valorSumado1 = valorAct1 + 2;
        int bonoSumado1;
        if (valorSumado1 >= 8) { bonoSumado1 = (valorSumado1 - 8) / 2; }
        else { bonoSumado1 = (valorSumado1 - 9) / 2; }
        numClase1.text = Personaje.Valor(Personaje.ElemClase("valor1")) + " > " + valorSumado1;
        bonoClase1.text = bonoAct1 + " > " + bonoSumado1;

        nombreClase2.text = Personaje.ElemClase("valor2");
        int valorAct2 = Personaje.Valor(Personaje.ElemClase("valor2"));
        int bonoAct2 = Personaje.BonoValor(Personaje.ElemClase("valor2"));
        int valorSumado2 = valorAct2 + 2;
        int bonoSumado2;
        if (valorSumado2 >= 8) { bonoSumado2 = (valorSumado2 - 8) / 2; }
        else { bonoSumado2 = (valorSumado2 - 9) / 2; }
        numClase2.text = Personaje.Valor(Personaje.ElemClase("valor2")) + " > " + valorSumado2;
        bonoClase2.text = bonoAct2 + " > " + bonoSumado2;
        menuSubNiv1.SetActive(true);

    }

    public void SubirNivel2()
    {
        //Cambiar nombres, numeros y bonos de cada valor 
        nombrenoclase1.text = Personaje.ElemClase("valorno1");
        int novalorAct1 = Personaje.Valor(Personaje.ElemClase("valorno1"));
        int nobonoAct1 = Personaje.BonoValor(Personaje.ElemClase("valorno1"));
        int novalorSumado1 = novalorAct1 + 1;
        int nobonoSumado1;
        if (novalorSumado1 >= 8) { nobonoSumado1 = (novalorSumado1 - 8) / 2; }
        else { nobonoSumado1 = (novalorSumado1 - 9) / 2; }
        numnoclase1.text = Personaje.Valor(Personaje.ElemClase("valorno1")) + " > " + novalorSumado1;
        bononoclase1.text = nobonoAct1 + " > " + nobonoSumado1;

        nombrenoclase2.text = Personaje.ElemClase("valorno2");
        int novalorAct2 = Personaje.Valor(Personaje.ElemClase("valorno2"));
        int nobonoAct2 = Personaje.BonoValor(Personaje.ElemClase("valorno2"));
        int novalorSumado2 = novalorAct2 + 1;
        int nobonoSumado2;
        if (novalorSumado2 >= 8) { nobonoSumado2 = (novalorSumado2 - 8) / 2; }
        else { nobonoSumado2 = (novalorSumado2 - 9) / 2; }
        numnoclase2.text = Personaje.Valor(Personaje.ElemClase("valorno2")) + " > " + novalorSumado2;
        bononoclase2.text = nobonoAct2 + " > " + nobonoSumado2;

        nombrenoclase3.text = Personaje.ElemClase("valorno3");
        int novalorAct3 = Personaje.Valor(Personaje.ElemClase("valorno3"));
        int nobonoAct3 = Personaje.BonoValor(Personaje.ElemClase("valorno3"));
        int novalorSumado3 = novalorAct3 + 1;
        int nobonoSumado3;
        if (novalorSumado3 >= 8) { nobonoSumado3 = (novalorSumado3 - 8) / 2; }
        else { nobonoSumado3 = (novalorSumado3 - 9) / 2; }
        numnoclase3.text = Personaje.Valor(Personaje.ElemClase("valorno3")) + " > " + novalorSumado3;
        bononoclase3.text = nobonoAct3 + " > " + nobonoSumado3;

        nombrenoclase4.text = Personaje.ElemClase("valorno4");
        int novalorAct4 = Personaje.Valor(Personaje.ElemClase("valorno4"));
        int nobonoAct4 = Personaje.BonoValor(Personaje.ElemClase("valorno4"));
        int novalorSumado4 = novalorAct4 + 1;
        int nobonoSumado4;
        if (novalorSumado4 >= 8) { nobonoSumado4 = (novalorSumado4 - 8) / 2; }
        else { nobonoSumado4 = (novalorSumado4 - 9) / 2; }
        numnoclase4.text = Personaje.Valor(Personaje.ElemClase("valorno4")) + " > " + novalorSumado4;
        bononoclase4.text = nobonoAct4 + " > " + nobonoSumado4;

        nombrenoclase5.text = Personaje.ElemClase("valorno5");
        int novalorAct5 = Personaje.Valor(Personaje.ElemClase("valorno5"));
        int nobonoAct5 = Personaje.BonoValor(Personaje.ElemClase("valorno5"));
        int novalorSumado5 = novalorAct5 + 1;
        int nobonoSumado5;
        if (novalorSumado5 >= 8) { nobonoSumado5 = (novalorSumado5 - 8) / 2; }
        else { nobonoSumado5 = (novalorSumado5 - 9) / 2; }
        numnoclase5.text = Personaje.Valor(Personaje.ElemClase("valorno5")) + " > " + novalorSumado5;
        bononoclase5.text = nobonoAct5 + " > " + nobonoSumado5;

        nombrenoclase6.text = Personaje.ElemClase("valorno6");
        int novalorAct6 = Personaje.Valor(Personaje.ElemClase("valorno6"));
        int nobonoAct6 = Personaje.BonoValor(Personaje.ElemClase("valorno6"));
        int novalorSumado6 = novalorAct6 + 1;
        int nobonoSumado6;
        if (novalorSumado6 >= 8) { nobonoSumado6 = (novalorSumado6 - 8) / 2; }
        else { nobonoSumado6 = (novalorSumado6 - 9) / 2; }
        numnoclase6.text = Personaje.Valor(Personaje.ElemClase("valorno6")) + " > " + novalorSumado6;
        bononoclase6.text = nobonoAct6 + " > " + nobonoSumado6;

        menuSubNiv1.SetActive(false);
        menuSubNiv2.SetActive(true);
    }

    public void SubirNivel3()
    {
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

        menuSubNiv2.SetActive(false);
        menuSubNiv3.SetActive(true);
    }
    public void SubirNivel4()
    {
        numDados.text = Personaje._otros.numDados.ToString();
        menuSubNiv3.SetActive(false);
        Puntos.ActPuntos();
    }

    void ActMenuValores(string valor)
    {
        int valorFinal = Personaje.Valor(valor);
        int bonoFinal = Personaje.BonoValor(valor);
        ValoresMenu.ActValor(valor, valorFinal, bonoFinal);
    }
}
