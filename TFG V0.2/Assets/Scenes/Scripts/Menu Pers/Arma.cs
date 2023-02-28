using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Arma
{
    public string nombreArma;
    public string descArma;
    public int dadoArma;
    public string tipoArma;
    // Start is called before the first frame update
    void Start()
    {
        nombreArma = "Daga";
        descArma = "yoqueseXD";
        dadoArma = 4;
        tipoArma = "AGILIDAD";
    }

    public Arma(string Nombre, string desc, int dado, string tipo)
    {
        nombreArma = Nombre;
        descArma = desc;
        dadoArma = dado;
        tipoArma = tipo;
    }
}
