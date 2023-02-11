using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caracteristicas : MonoBehaviour, IDataPersistance
{
    public InputField idiomas;
    public InputField desc;
    public InputField gustos;
    public InputField aversiones;
    public InputField ideales;
    public InputField vinculos;

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
        idiomas.text = Personaje.idiomas;
        desc.text = Personaje.desc;
        gustos.text = Personaje.gustos;
        aversiones.text = Personaje.aversiones;
        ideales.text = Personaje.ideales;
        vinculos.text = Personaje.vinculos;

        idiomas.onValueChanged.AddListener(delegate { OnValueChangedIdiomas(); });
        desc.onValueChanged.AddListener(delegate { OnValueChangedDesc(); });
        gustos.onValueChanged.AddListener(delegate { OnValueChangedGustos(); });
        aversiones.onValueChanged.AddListener(delegate { OnValueChangedAversiones(); });
        ideales.onValueChanged.AddListener(delegate { OnValueChangedIdeales(); });
        vinculos.onValueChanged.AddListener(delegate { OnValueChangedVinculos(); });
    }

    public void OnValueChangedIdiomas()
    {
        Personaje.idiomas = idiomas.text;
    }
    public void OnValueChangedDesc()
    {
        Personaje.desc = desc.text;
    }
    public void OnValueChangedGustos()
    {
        Personaje.gustos = gustos.text;
    }
    public void OnValueChangedAversiones()
    {
        Personaje.aversiones = aversiones.text;
    }
    public void OnValueChangedIdeales()
    {
        Personaje.ideales = ideales.text;
    }
    public void OnValueChangedVinculos()
    {
        Personaje.vinculos = vinculos.text;
    }
}
