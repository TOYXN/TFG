using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatAttacks : MonoBehaviour
{
    public Button botonAtacar;
    public Button botonHechizos;
    public Button botonAtacarMenuAtacar;
    public GameObject MenuAcciones;
    public GameObject MenuHechizos;
    public GameObject MenuAtaqueArma;
    public GameObject MenuAtaqueArmaRes;
    public GameObject MenuEsquivaAtaque;
    public GameObject MenuBloqueoAtaque;
    public Text nombreArma;
    public Text tipoArma;
    public Text dadoArma;
    public Text numDados;
    public Text resultadoTirada;
    public Text desgloseTirada;

    public Arma Arma;
    public Personaje Personaje;
    // Start is called before the first frame update
    void Start()
    {
        botonAtacar.onClick.AddListener(atacarArma);
        botonHechizos.onClick.AddListener(usarHechizo);
        botonAtacarMenuAtacar.onClick.AddListener(Atacar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void atacarArma()
    {
        nombreArma.text = Arma.nombreArma;
        tipoArma.text = Arma.tipoArma;
        dadoArma.text = "d" + Arma.dadoArma;
        numDados.text = Personaje._otros.numDados.ToString();
        MenuAtaqueArma.SetActive(true);
    }
    void Atacar()
    {
        int min = 1;
        int max = Arma.dadoArma + 1;
        int numDadoTirada;
        int result = 0;
        int bonoActual = Personaje.BonoValor(Arma.tipoArma);
        for (int i = 0; i < Personaje._otros.numDados; i++)
        {
            numDadoTirada = Random.Range(min, max);
            result = result + numDadoTirada;
            desgloseTirada.text += numDadoTirada + " (" + dadoArma.text + ") " + "+ ";
        }
        result = result + bonoActual;
       
        resultadoTirada.text = "Resultado: " + result;
        desgloseTirada.text += bonoActual + " (" + tipoArma.text + ") ";
        Debug.Log(result);
        MenuAtaqueArma.SetActive(false);
        MenuAtaqueArmaRes.SetActive(true);
    }

    void usarHechizo()
    {
        MenuHechizos.SetActive(true);
        MenuAcciones.SetActive(false);
    }
}
