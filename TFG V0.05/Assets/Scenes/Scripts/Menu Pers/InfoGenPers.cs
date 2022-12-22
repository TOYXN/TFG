using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoGenPers : MonoBehaviour
{
    public Text Nombre;
    public Text Raza;
    public Text Clase;
    public Text Nivel;
    public Personaje Personaje;
    // Start is called before the first frame update
    void Start()
    {
        Nombre.text = Personaje.nombre;
        Raza.text = Personaje.ElemRaza("nombre");
        Clase.text = Personaje.ElemClase("nombre");
        Nivel.text = "Nivel: " + Personaje.nivel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
