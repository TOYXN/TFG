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

    public Button botonDatos;
    public GameObject MenuDatos;
    public Text NombreMenu;
    public Text RazaMenu;
    public Text ClaseMenu;
    public Button BotonClase;
    public Button BotonRaza;
    public Button CerrarMenuDatos;
    public GameObject MenuInfoConcreta;
    public Text TituloInfoConcreta;
    public Text InfoConcreta;
    public Button CerrarInfoConcreta;

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
        botonDatos.onClick.AddListener(AbrirMenu);
        BotonClase.onClick.AddListener(AbrirClase);
        BotonRaza.onClick.AddListener(AbrirRaza);
        CerrarMenuDatos.onClick.AddListener(CerrarMenu);
        CerrarInfoConcreta.onClick.AddListener(CerrarMenuInfoConcreta);


        Nombre.text = Personaje.nombre;
        Raza.text = Personaje.ElemRaza("nombre");
        Clase.text = Personaje.ElemClase("nombre");
        Nivel.text = "Nivel: " + Personaje.nivel;
        NombreMenu.text = "Nombre: " + Personaje.nombre;
        RazaMenu.text = "Raza: " + Personaje._raza.nombreRaza;
        ClaseMenu.text = "Clase: " + Personaje._clase.nombreClase;
    }

    void AbrirMenu()
    {
        MenuDatos.SetActive(true);
    }

    void AbrirClase()
    {
        TituloInfoConcreta.text = Personaje._clase.nombreClase;
        InfoConcreta.text = Personaje._clase.descClase;
        MenuInfoConcreta.SetActive(true);
    }

    void AbrirRaza()
    {
        TituloInfoConcreta.text = Personaje._raza.nombreRaza;
        InfoConcreta.text = Personaje._raza.descRaza;
        MenuInfoConcreta.SetActive(true);
    }

    void CerrarMenu()
    {
        MenuDatos.SetActive(false);
    }

    void CerrarMenuInfoConcreta()
    {
        MenuInfoConcreta.SetActive(false);
    }

}
