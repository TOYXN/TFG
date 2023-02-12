using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso5 : MonoBehaviour, IDataPersistance
{
    public GameObject Menu5_1;
    public GameObject Menu5_2;
    public GameObject Menu5_3;
    public GameObject Menu5_4;
    public GameObject Menu6_1;

    public Image imagenPaso5;
    public Image imagenPaso6;

    public Button continuar1;
    public Button atras1;
    public Button continuar2;
    public Button atras2;
    public Button continuar3;
    public Button atras3;
    public Button continuar4;
    public Button atras4;
    public GameObject continuar4GO;

    public Text Arma1;
    public Text Arma2;
    public Text Arma3;
    public Text Arma4;
    public Text Arma5;
    public Text Arma6;

    public GameObject MenuSeleccion;
    public GameObject MenuArmaSelec;
    public GameObject TextoFinal;
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
        Menu5_2.SetActive(true);
    }
    void Atras1()
    {
        Menu5_1.SetActive(false);
        imagenPaso5.color = new Vector4(255, 255, 255, 100);
    }

    void Siguiente2()
    {
        Menu5_3.SetActive(true);
    }
    void Atras2()
    {
        Menu5_2.SetActive(false);
    }

    void Siguiente3()
    {
        PonerNombreArmas();
        //DataPersistanceManager.instance.ActualizarPersonaje(Personaje);
        Menu5_4.SetActive(true);
    }
    void Atras3()
    {
        Menu5_3.SetActive(false);
    }

    void Siguiente4()
    {
        Menu6_1.SetActive(true);
        imagenPaso6.color = new Vector4(0, 255, 0, 100);
    }
    void Atras4()
    {
        Menu5_4.SetActive(false);
        MenuSeleccion.SetActive(true);
        MenuArmaSelec.SetActive(false);
        TextoFinal.SetActive(false);
        continuar4GO.SetActive(false);
    }

    void PonerNombreArmas()
    {
        Arma1.text = Personaje._clase.listaArmasClase[0].nombreArma;
        Arma2.text = Personaje._clase.listaArmasClase[1].nombreArma;
        Arma3.text = Personaje._clase.listaArmasClase[2].nombreArma;
        Arma4.text = Personaje._clase.listaArmasClase[3].nombreArma;
        Arma5.text = Personaje._clase.listaArmasClase[4].nombreArma;
        Arma6.text = Personaje._clase.listaArmasClase[5].nombreArma;
    }
}
