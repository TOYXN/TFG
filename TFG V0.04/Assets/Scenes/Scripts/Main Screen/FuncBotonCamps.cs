using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuncBotonCamps : MonoBehaviour
{
    public Button botonCrearCamps1;
    public Button botonCrearCamps2;
    public Button botonCrearCamps3;
    public Button botonCrearCamps4;

    public Button botonElimCamps1;
    public Button botonElimCamps2;
    public Button botonElimCamps3;
    public Button botonElimCamps4;

    public Button botonElimSi1;
    public Button botonElimSi2;
    public Button botonElimSi3;
    public Button botonElimSi4;

    public Button botonElimNo1;
    public Button botonElimNo2;
    public Button botonElimNo3;
    public Button botonElimNo4;

    public GameObject elemBoton1;
    public GameObject elemBoton2;
    public GameObject elemBoton3;
    public GameObject elemBoton4;

    public GameObject campana1;
    public GameObject campana2;
    public GameObject campana3;
    public GameObject campana4;

    public GameObject menuElim1;
    public GameObject menuElim2;
    public GameObject menuElim3;
    public GameObject menuElim4;

    // Start is called before the first frame update
    void Start()
    {
        botonCrearCamps1.onClick.AddListener(Bypass1);
        botonCrearCamps2.onClick.AddListener(Bypass2);
        botonCrearCamps3.onClick.AddListener(Bypass3);
        botonCrearCamps4.onClick.AddListener(Bypass4);

        botonElimCamps1.onClick.AddListener(Bypass5);
        botonElimCamps2.onClick.AddListener(Bypass6);
        botonElimCamps3.onClick.AddListener(Bypass7);
        botonElimCamps4.onClick.AddListener(Bypass8);

        botonElimSi1.onClick.AddListener(Bypass9);
        botonElimSi2.onClick.AddListener(Bypass10);
        botonElimSi3.onClick.AddListener(Bypass11);
        botonElimSi4.onClick.AddListener(Bypass12);

        botonElimNo1.onClick.AddListener(Bypass13);
        botonElimNo2.onClick.AddListener(Bypass14);
        botonElimNo3.onClick.AddListener(Bypass15);
        botonElimNo4.onClick.AddListener(Bypass16);
    }
   
    void Bypass1()
    {
        CrearCamp(elemBoton1, campana1);
    }

    void Bypass2()
    {
        CrearCamp(elemBoton2, campana2);
    }

    void Bypass3()
    {
        CrearCamp(elemBoton3, campana3);
    }

    void Bypass4()
    {
        CrearCamp(elemBoton4, campana4);
    }

    void Bypass5()
    {
        MenuElimCamp(campana1, menuElim1);
    }

    void Bypass6()
    {
        MenuElimCamp(campana2, menuElim2);
    }

    void Bypass7()
    {
        MenuElimCamp(campana3, menuElim3);
    }

    void Bypass8()
    {
        MenuElimCamp(campana4, menuElim4);
    }

    void Bypass9()
    {
        ElimCamp(menuElim1, elemBoton1);
    }

    void Bypass10()
    {
        ElimCamp(menuElim2, elemBoton2);
    }

    void Bypass11()
    {
        ElimCamp(menuElim3, elemBoton3);
    }

    void Bypass12()
    {
        ElimCamp(menuElim4, elemBoton4);
    }

    void Bypass13()
    {
        NoElimCamp(menuElim1, campana1);
    }

    void Bypass14()
    {
        NoElimCamp(menuElim2, campana2);
    }

    void Bypass15()
    {
        NoElimCamp(menuElim3, campana3);
    }

    void Bypass16()
    {
        NoElimCamp(menuElim4, campana4);
    }

    void CrearCamp(GameObject botonCrear, GameObject camp)
    {
        botonCrear.SetActive(false);
        camp.SetActive(true);
    }

    void MenuElimCamp(GameObject camp, GameObject menuElim)
    {
        camp.SetActive(false);
        menuElim.SetActive(true);
    }

    void ElimCamp(GameObject menuElim, GameObject botonCrear)
    {
        menuElim.SetActive(false);
        botonCrear.SetActive(true);
    }

    void NoElimCamp(GameObject menuElim, GameObject camp)
    {
        menuElim.SetActive(false);
        camp.SetActive(true);
    }
}
