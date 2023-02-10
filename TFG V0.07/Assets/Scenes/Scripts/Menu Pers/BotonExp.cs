using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonExp : MonoBehaviour
{
    public Button botonMenuEXP;
    public Button botonSumarEXP;
    public Button botonCerrarMenuEXP;
    public Text expPersonaje;
    public Text expActual;
    public Text expNiv;
    public Text expMetida;
    public Text NivelPers;
    public GameObject menuEXP;
    public Personaje Personaje;
    public SubidaNivel subirNivel;
    private int expActPersonaje;
    private int expNivPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        botonMenuEXP.onClick.AddListener(AbrirMenuEXP);
        botonSumarEXP.onClick.AddListener(SumarEXP);
        botonCerrarMenuEXP.onClick.AddListener(CerrarMenuEXP);
        expActPersonaje = Personaje.exp;
        expNivPersonaje = Personaje.expProxNivel;
        expPersonaje.text = "EXP: " + expActPersonaje + "/" + expNivPersonaje;
        expActual.text = expActPersonaje.ToString();
        expNiv.text = expNivPersonaje.ToString();
    }

    void AbrirMenuEXP()
    {
        menuEXP.SetActive(true);
    }

    void CerrarMenuEXP()
    {
        menuEXP.SetActive(false);
    }

    void SumarEXP()
    {
        int expEntrada = int.Parse(expMetida.text);
        expActPersonaje = expActPersonaje + expEntrada;
        if (expActPersonaje >= expNivPersonaje)
        {
            expNivPersonaje = (expNivPersonaje * 2) + (expNivPersonaje / 2);
            Personaje.SubirNivel();
            subirNivel.SubirNivel();
            NivelPers.text = "Nivel: " + Personaje.nivel;
        }
        expActual.text = expActPersonaje.ToString();
        expNiv.text = expNivPersonaje.ToString();
        expPersonaje.text = "EXP: " + expActPersonaje + "/" + expNivPersonaje;
        Personaje.exp = expActPersonaje;
        Personaje.expProxNivel = expNivPersonaje;
    }

}
