using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FuncBotonPers : MonoBehaviour
{
    public Button botonCrearPers1;
    public Button botonCrearPers2;
    public Button botonCrearPers3;
    public Button botonCrearPers4;

    public Button botonElimPers1;
    public Button botonElimPers2;
    public Button botonElimPers3;
    public Button botonElimPers4;

    public Button botonElimSi1;
    public Button botonElimSi2;
    public Button botonElimSi3;
    public Button botonElimSi4;

    public Button botonElimNo1;
    public Button botonElimNo2;
    public Button botonElimNo3;
    public Button botonElimNo4;

    public Button botonPersonaje1;
    public Button botonPersonaje2;
    public Button botonPersonaje3;
    public Button botonPersonaje4;

    public GameObject elemBoton1;
    public GameObject elemBoton2;
    public GameObject elemBoton3;
    public GameObject elemBoton4;

    public GameObject personaje1;
    public GameObject personaje2;
    public GameObject personaje3;
    public GameObject personaje4;

    public GameObject menuElim1;
    public GameObject menuElim2;
    public GameObject menuElim3;
    public GameObject menuElim4;

    // Start is called before the first frame update
    void Start()
    {
        botonCrearPers1.onClick.AddListener(Bypass1);
        botonCrearPers2.onClick.AddListener(Bypass2);
        botonCrearPers3.onClick.AddListener(Bypass3);
        botonCrearPers4.onClick.AddListener(Bypass4);

        botonElimPers1.onClick.AddListener(Bypass5);
        botonElimPers2.onClick.AddListener(Bypass6);
        botonElimPers3.onClick.AddListener(Bypass7);
        botonElimPers4.onClick.AddListener(Bypass8);

        botonElimSi1.onClick.AddListener(Bypass9);
        botonElimSi2.onClick.AddListener(Bypass10);
        botonElimSi3.onClick.AddListener(Bypass11);
        botonElimSi4.onClick.AddListener(Bypass12);

        botonElimNo1.onClick.AddListener(Bypass13);
        botonElimNo2.onClick.AddListener(Bypass14);
        botonElimNo3.onClick.AddListener(Bypass15);
        botonElimNo4.onClick.AddListener(Bypass16);

        botonPersonaje1.onClick.AddListener(CargarPersonaje1);
        botonPersonaje2.onClick.AddListener(CargarPersonaje2);
        botonPersonaje3.onClick.AddListener(CargarPersonaje3);
        botonPersonaje4.onClick.AddListener(CargarPersonaje4);

    }
   
    void Bypass1()
    {
        CrearPers(elemBoton1, personaje1, "pers1");
    }

    void Bypass2()
    {
        CrearPers(elemBoton2, personaje2, "pers2");
    }

    void Bypass3()
    {
        CrearPers(elemBoton3, personaje3, "pers3");
    }

    void Bypass4()
    {
        CrearPers(elemBoton4, personaje4, "pers4");
    }

    void Bypass5()
    {
        MenuElimPers(personaje1, menuElim1);
    }

    void Bypass6()
    {
        MenuElimPers(personaje2, menuElim2);
    }

    void Bypass7()
    {
        MenuElimPers(personaje3, menuElim3);
    }

    void Bypass8()
    {
        MenuElimPers(personaje4, menuElim4);
    }

    void Bypass9()
    {
        ElimPers(menuElim1, elemBoton1, "pers1");
    }

    void Bypass10()
    {
        ElimPers(menuElim2, elemBoton2, "pers2");
    }

    void Bypass11()
    {
        ElimPers(menuElim3, elemBoton3, "pers3");
    }

    void Bypass12()
    {
        ElimPers(menuElim4, elemBoton4, "pers4");
    }

    void Bypass13()
    {
        NoElimPers(menuElim1, personaje1);
    }

    void Bypass14()
    {
        NoElimPers(menuElim2, personaje2);
    }

    void Bypass15()
    {
        NoElimPers(menuElim3, personaje3);
    }

    void Bypass16()
    {
        NoElimPers(menuElim4, personaje4);
    }

    void CargarPersonaje1()
    {
        
        DataPersistanceManager.instance.CambiarIdPersSelecc("pers1");
        DataPersistanceManager.instance.GuardarPersonaje();
        SceneManager.LoadSceneAsync("Character");
    }

    void CargarPersonaje2()
    {
        
        DataPersistanceManager.instance.CambiarIdPersSelecc("pers2");
        DataPersistanceManager.instance.GuardarPersonaje();
        SceneManager.LoadSceneAsync("Character");
    }

    void CargarPersonaje3()
    {
        
        DataPersistanceManager.instance.CambiarIdPersSelecc("pers3");
        DataPersistanceManager.instance.GuardarPersonaje();
        SceneManager.LoadSceneAsync("Character");
    }

    void CargarPersonaje4()
    {
        DataPersistanceManager.instance.CambiarIdPersSelecc("pers4");
        DataPersistanceManager.instance.GuardarPersonaje();
        SceneManager.LoadSceneAsync("Character");
    }

    void CrearPers(GameObject botonCrear, GameObject pers, string idPers)
    {
        DataPersistanceManager.instance.CambiarIdPersSelecc(idPers);
        DataPersistanceManager.instance.CrearPersonaje();
        DataPersistanceManager.instance.GuardarPersonaje();
        SceneManager.LoadSceneAsync("Creation");
    }

    void MenuElimPers(GameObject pers, GameObject menuElim)
    {
        pers.SetActive(false);
        menuElim.SetActive(true);
    }

    void ElimPers(GameObject menuElim, GameObject botonCrear, string idPers)
    {
        DataPersistanceManager.instance.EliminarPersonaje(idPers);
        menuElim.SetActive(false);
        botonCrear.SetActive(true);
    }

    void NoElimPers(GameObject menuElim, GameObject pers)
    {
        menuElim.SetActive(false);
        pers.SetActive(true);
    }
}
