using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuncHechizos : MonoBehaviour
{
    public Text nomHech1;
    public Text nomHech2;
    public Text nomHech3;
    public Text nomHech4;
    public Text nomHech5;
    public Text nomHech6;
    public Text nomHech7;
    public Text nomHech8;

    public Text costeHech1;
    public Text costeHech2;
    public Text costeHech3;
    public Text costeHech4;
    public Text costeHech5;
    public Text costeHech6;
    public Text costeHech7;
    public Text costeHech8;

    public Text dadosHech1;
    public Text dadosHech2;
    public Text dadosHech3;
    public Text dadosHech4;
    public Text dadosHech5;
    public Text dadosHech6;
    public Text dadosHech7;
    public Text dadosHech8;

    public Button usarHech1;
    public Button usarHech2;
    public Button usarHech3;
    public Button usarHech4;
    public Button usarHech5;
    public Button usarHech6;
    public Button usarHech7;
    public Button usarHech8;

    public Personaje Personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActHechiz(int num)
    {
        if(num == 0)
        {
            int dado = Personaje.listaHechizos[0].dadoHechizo;
            MeterNuevoHechizo(nomHech1, Personaje.listaHechizos[0].nombreHechizo,
                                costeHech1, Personaje.listaHechizos[0].costeHechizo,
                                dadosHech1, dado);
        }
        if (num == 1)
        {
            int dado = Personaje.listaHechizos[1].dadoHechizo;
            MeterNuevoHechizo(nomHech2, Personaje.listaHechizos[1].nombreHechizo,
                                costeHech2, Personaje.listaHechizos[1].costeHechizo,
                                dadosHech2, dado);
        }
        if (num == 2)
        {
            int dado = Personaje.listaHechizos[2].dadoHechizo;
            MeterNuevoHechizo(nomHech3, Personaje.listaHechizos[2].nombreHechizo,
                                costeHech3, Personaje.listaHechizos[2].costeHechizo,
                                dadosHech3, dado);
        }
        if (num == 3)
        {
            int dado = Personaje.listaHechizos[3].dadoHechizo;
            MeterNuevoHechizo(nomHech4, Personaje.listaHechizos[3].nombreHechizo,
                                costeHech4, Personaje.listaHechizos[3].costeHechizo,
                                dadosHech4, dado);
        }
        if (num == 4)
        {
            int dado = Personaje.listaHechizos[4].dadoHechizo;
            MeterNuevoHechizo(nomHech5, Personaje.listaHechizos[4].nombreHechizo,
                                costeHech5, Personaje.listaHechizos[4].costeHechizo,
                                dadosHech5, dado);
        }
        if (num == 5)
        {
            int dado = Personaje.listaHechizos[5].dadoHechizo;
            MeterNuevoHechizo(nomHech6, Personaje.listaHechizos[5].nombreHechizo,
                                costeHech6, Personaje.listaHechizos[5].costeHechizo,
                                dadosHech6, dado);
        }
        if (num == 6)
        {
            int dado = Personaje.listaHechizos[6].dadoHechizo;
            MeterNuevoHechizo(nomHech7, Personaje.listaHechizos[6].nombreHechizo,
                                costeHech7, Personaje.listaHechizos[6].costeHechizo,
                                dadosHech7, dado);
        }
        if (num == 7)
        {
            int dado = Personaje.listaHechizos[7].dadoHechizo;
            MeterNuevoHechizo(nomHech8, Personaje.listaHechizos[7].nombreHechizo,
                                costeHech8, Personaje.listaHechizos[7].costeHechizo,
                                dadosHech8, dado);
        }
    }

    void MeterNuevoHechizo(Text nombrePoner, string nombre, Text costePoner, int coste, Text dadosPoner, int dados)
    {
        nombrePoner.text = nombre;
        costePoner.text = coste + " PA";

        if (dados == 0)
        {
            dadosPoner.text = "-";
        }
        else
        {
            dadosPoner.text = "d" + dados + " X" + Personaje._otros.numDados;
        }
    }
}
