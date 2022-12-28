using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caracteristicas : MonoBehaviour
{
    public Text idiomas;
    public Text desc;
    public Text gustos;
    public Text aversiones;
    public Text ideales;
    public Text vinculos;
    // Start is called before the first frame update
    void Start()
    {
        idiomas.text = "";
        desc.text = "";
        gustos.text = "";
        aversiones.text = "";
        ideales.text = "";
        vinculos.text = "";
    }
}
