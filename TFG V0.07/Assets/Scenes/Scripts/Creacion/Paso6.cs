using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso6 : MonoBehaviour
{
    public GameObject Menu6_1;
    public GameObject Menu6_2;
    public GameObject Menu6_3;
    public GameObject Menu7_1;

    public Image imagenPaso6;
    public Image imagenPaso7;

    public Button continuar1;
    public Button atras1;
    public Button continuar2;
    public Button atras2;
    public Button continuar3;
    public Button atras3;
    public GameObject continuar3GO;

    public GameObject MenuSeleccion;
    public GameObject MenuAccionSelec;
    public GameObject MenuConfirmacion;
    // Start is called before the first frame update
    void Start()
    {
        continuar1.onClick.AddListener(Siguiente1);
        atras1.onClick.AddListener(Atras1);
        continuar2.onClick.AddListener(Siguiente2);
        atras2.onClick.AddListener(Atras2);
        continuar3.onClick.AddListener(Siguiente3);
        atras3.onClick.AddListener(Atras3);
    }

    void Siguiente1()
    {
        Menu6_2.SetActive(true);
    }
    void Atras1()
    {
        Menu6_1.SetActive(false);
        imagenPaso6.color = new Vector4(255, 255, 255, 100);
    }

    void Siguiente2()
    {
        Menu6_3.SetActive(true);
    }
    void Atras2()
    {
        Menu6_2.SetActive(false);
    }

    void Siguiente3()
    {
        imagenPaso7.color = new Vector4(0, 255, 0, 100);
        Menu7_1.SetActive(true);
    }
    void Atras3()
    {
        Menu6_3.SetActive(false);
        MenuSeleccion.SetActive(true);
        MenuAccionSelec.SetActive(false);
        MenuConfirmacion.SetActive(false);
        continuar3GO.SetActive(false);
    }
}
