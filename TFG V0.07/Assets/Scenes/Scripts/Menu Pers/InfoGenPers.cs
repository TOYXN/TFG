using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoGenPers : MonoBehaviour, IDataPersistance
{
    public Text Nombre;
    public Text Raza;
    public Text Clase;
    public Text Nivel;
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
        Nombre.text = Personaje.nombre;
        Raza.text = Personaje.ElemRaza("nombre");
        Clase.text = Personaje.ElemClase("nombre");
        Nivel.text = "Nivel: " + Personaje.nivel;
    }

}
