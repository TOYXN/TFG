using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReinicioBuffs : MonoBehaviour, IDataPersistance
{
    public Button botonReinicio;

    public ValoresMenu ValoresMenu;
    public Personaje Personaje;

    public void CargarData(Personaje pers)
    {
        this.Personaje = pers;
    }

    public void GuardarData(Personaje pers)
    {
        pers = this.Personaje;
    }

    // Start is called before the first frame update
    void Start()
    {
        botonReinicio.onClick.AddListener(Reiniciar);
    }

    void Reiniciar()
    {
        Personaje.ReiniciarBuffs();
        ValoresMenu.IniciarValores();
    }
}
