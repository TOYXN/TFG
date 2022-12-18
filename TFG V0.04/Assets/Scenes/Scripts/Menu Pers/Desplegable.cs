using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desplegable : MonoBehaviour
{
    public Button botonPrincipal;
    public Text textoBotonPrincipal;
    public GameObject desplegable;
    public Button botonValores;
    public Button botonAcciones;
    public Button botonHab;
    public Button botonEquipo;
    public Button botonCarac;
    public GameObject menuValores;
    public GameObject menuAcciones;
    public GameObject menuHab;
    public GameObject menuEquipo;
    public GameObject menuCarac;
    bool desplegableActivo;

    // Start is called before the first frame update
    void Start()
    {
        botonPrincipal.onClick.AddListener(PrepararDesp);
        botonValores.onClick.AddListener(Bypass1);
        botonAcciones.onClick.AddListener(Bypass2);
        botonHab.onClick.AddListener(Bypass3);
        botonEquipo.onClick.AddListener(Bypass4);
        botonCarac.onClick.AddListener(Bypass5);

        desplegable.SetActive(false);
        menuValores.SetActive(false);
        menuAcciones.SetActive(false);
        menuHab.SetActive(false);
        menuEquipo.SetActive(false);
        menuCarac.SetActive(false);
        menuValores.SetActive(true);
        textoBotonPrincipal.text = "VALORES";

        desplegableActivo = false;
    }

    void Bypass1()
    {
        MostrarMenu(menuValores,"VALORES");
    }

    void Bypass2()
    {
        MostrarMenu(menuAcciones,"ACCIONES");
    }

    void Bypass3()
    {
        MostrarMenu(menuHab,"HABILIDADES Y HECHIZOS");
    }

    void Bypass4()
    {
        MostrarMenu(menuEquipo,"EQUIPO");
    }

    void Bypass5()
    {
        MostrarMenu(menuCarac,"CARACTERÍSTICAS");
    }

    void MostrarMenu(GameObject menu, string nombreMenu)
    {
        desplegable.SetActive(false);
        desplegableActivo = false;
        menuValores.SetActive(false);
        menuAcciones.SetActive(false);
        menuHab.SetActive(false);
        menuEquipo.SetActive(false);
        menuCarac.SetActive(false);
        menu.SetActive(true);
        textoBotonPrincipal.text = nombreMenu;
    }

    void PrepararDesp()
    {
        if (desplegableActivo) { desplegable.SetActive(false); desplegableActivo = false; }
        else { desplegable.SetActive(true); desplegableActivo = true; }
    }
}
