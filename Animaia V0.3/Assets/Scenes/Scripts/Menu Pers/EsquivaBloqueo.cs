using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsquivaBloqueo : MonoBehaviour, IDataPersistance
{
    public Button botonEsquivarAtaque;
    public Button botonBloquearAtaque;
    public GameObject MenuEsquivaAtaque;
    public GameObject MenuBloqueoAtaque;
    public Text resultadoTiradaEsquiva;
    public Text desgloseTiradaEsquiva;
    public Text resultadoTiradaBloqueo;
    public Text desgloseTiradaBloqueo;
    public Button botonCerrarEsquiva;
    public Button botonCerrarBloqueo;

    public Personaje Personaje;
    public AudioSource audioData;

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
        botonEsquivarAtaque.onClick.AddListener(Esquiva);
        botonBloquearAtaque.onClick.AddListener(Bloqueo);
        botonCerrarEsquiva.onClick.AddListener(CerrarEsquiva);
        botonCerrarBloqueo.onClick.AddListener(CerrarBloqueo);
    }

    void Esquiva()
    {
        int min = 1;
        int max = 21;
        int numDadoTirada = Random.Range(min, max);
        int bonoActual = Personaje.BonoValor("AGILIDAD");
        audioData.Play(0);
        int result;
        if (numDadoTirada == 1)
        {
            resultadoTiradaEsquiva.text = "¡Pifia!";
            desgloseTiradaEsquiva.text = numDadoTirada + " (d20)";
        }
        else if (numDadoTirada == 20)
        {
            resultadoTiradaEsquiva.text = "¡Milagro!";
            desgloseTiradaEsquiva.text = numDadoTirada + " (d20) ";
        }
        else
        {
            result = numDadoTirada + bonoActual;
            resultadoTiradaEsquiva.text = "Tu resultado: " + result;
            desgloseTiradaEsquiva.text = numDadoTirada + " (d20) + " + bonoActual + " (Bono AGILIDAD)";
            Debug.Log(result);
        }

        MenuEsquivaAtaque.SetActive(true);
    }

    void Bloqueo()
    {
        int min = 1;
        int max = 21;
        int numDadoTirada = Random.Range(min, max);
        int bonoActual = Personaje.BonoValor("RESISTENCIA");
        audioData.Play(0);
        int result;
        if (numDadoTirada == 1)
        {
            resultadoTiradaBloqueo.text = "¡Pifia!";
            desgloseTiradaBloqueo.text = numDadoTirada + " (d20)";
        }
        else if (numDadoTirada == 20)
        {
            resultadoTiradaBloqueo.text = "¡Milagro!";
            desgloseTiradaBloqueo.text = numDadoTirada + " (d20) ";
        }
        else
        {
            result = numDadoTirada + bonoActual;
            resultadoTiradaBloqueo.text = "Tu resultado: " + result;
            desgloseTiradaBloqueo.text = numDadoTirada + " (d20) + " + bonoActual + " (Bono RESISTENCIA)";
            Debug.Log(result);
        }

        MenuBloqueoAtaque.SetActive(true);
    }

    void CerrarEsquiva()
    {
        MenuEsquivaAtaque.SetActive(false);
    }

    void CerrarBloqueo()
    {
        MenuBloqueoAtaque.SetActive(false);
    }
}
