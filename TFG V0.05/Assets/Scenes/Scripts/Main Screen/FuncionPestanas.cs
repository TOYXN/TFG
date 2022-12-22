using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuncionPestanas : MonoBehaviour
{
    public Button botonPersonajes;
    public Button botonCampanas;
    public GameObject pestanaPersonajes;
    public GameObject pestanaCampanas;

    // Start is called before the first frame update
    void Start()
    {
        botonPersonajes.onClick.AddListener(MostrarPersonajes);
        botonCampanas.onClick.AddListener(MostrarCampanas);
    }

 
    void MostrarPersonajes()
    {
        pestanaCampanas.SetActive(false);
        pestanaPersonajes.SetActive(true);
    }

    void MostrarCampanas()
    {
        pestanaPersonajes.SetActive(false);
        pestanaCampanas.SetActive(true);
    }
}
