using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso4 : MonoBehaviour
{
    public GameObject Menu4_1;
    public GameObject Menu4_2;
    public GameObject Menu4_3;
    public GameObject Menu4_4;
    public GameObject Menu5_1;

    public Image imagenPaso4;
    public Image imagenPaso5;

    public Button continuar1;
    public Button atras1;
    public Button continuar2;
    public Button atras2;
    public Button continuar3;
    public Button atras3;
    public Button continuar4;
    public Button atras4;
    public GameObject continuar4GO;

    public GameObject MenuSeleccion;
    public GameObject MenuClaseSelec;
    public GameObject MenuDescClase;
    public GameObject TextoFinal;
    // Start is called before the first frame update
    void Start()
    {
        continuar1.onClick.AddListener(Siguiente1);
        atras1.onClick.AddListener(Atras1);
        continuar2.onClick.AddListener(Siguiente2);
        atras2.onClick.AddListener(Atras2);
        continuar3.onClick.AddListener(Siguiente3);
        atras3.onClick.AddListener(Atras3);
        continuar4.onClick.AddListener(Siguiente4);
        atras4.onClick.AddListener(Atras4);
    }

    void Siguiente1()
    {
        Menu4_2.SetActive(true);
    }
    void Atras1()
    {
        Menu4_1.SetActive(false);
        imagenPaso4.color = new Vector4(255, 255, 255, 100);
    }

    void Siguiente2()
    {
        Menu4_3.SetActive(true);
    }
    void Atras2()
    {
        Menu4_2.SetActive(false);
    }

    void Siguiente3()
    {
        Menu4_4.SetActive(true);
    }
    void Atras3()
    {
        Menu4_3.SetActive(false);
    }

    void Siguiente4()
    {
        Menu5_1.SetActive(true);
        imagenPaso5.color = new Vector4(0, 255, 0, 100);
    }
    void Atras4()
    {
        Menu4_4.SetActive(false);
        MenuSeleccion.SetActive(true);
        MenuClaseSelec.SetActive(false);
        MenuDescClase.SetActive(false);
        TextoFinal.SetActive(false);
        continuar4GO.SetActive(false);
    }
}
