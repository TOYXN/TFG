using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiradasValores : MonoBehaviour, IDataPersistance
{
    public Button botonValores;
    public GameObject MenuValores;

    public GameObject BotonesValores;
    public GameObject ValoresCuerpo;
    public GameObject ValoresAlma;

    public Button botonCuerpo;
    public Button botonAlma;

    public Button botonAtras1;
    public Button botonAtras2;

    public Text Fuerza;
    public Text Resistencia;
    public Text Agilidad;
    public Text Velocidad;
    public Text Poder;
    public Text Sentidos;
    public Text Memoria;
    public Text Personalidad;

    public Text bonoFuerza;
    public Text bonoResistencia;
    public Text bonoAgilidad;
    public Text bonoVelocidad;
    public Text bonoPoder;
    public Text bonoSentidos;
    public Text bonoMemoria;
    public Text bonoPersonalidad;

    public Button botonFuerza;
    public Button botonResistencia;
    public Button botonAgilidad;
    public Button botonVelocidad;
    public Button botonPoder;
    public Button botonSentidos;
    public Button botonMemoria;
    public Button botonPersonalidad;

    public GameObject ObjetoMenuResultado;
    public Personaje Personaje;

    public Text resultadoTirada;
    public Text desgloseTirada;
    public Button cerrarMenu;

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
        botonValores.onClick.AddListener(AbrirMenu);
        botonFuerza.onClick.AddListener(UsarFuerza);
        botonResistencia.onClick.AddListener(UsarResistencia);
        botonAgilidad.onClick.AddListener(UsarAgilidad);
        botonVelocidad.onClick.AddListener(UsarVelocidad);
        botonPoder.onClick.AddListener(UsarPoder);
        botonSentidos.onClick.AddListener(UsarSentidos);
        botonMemoria.onClick.AddListener(UsarMemoria);
        botonPersonalidad.onClick.AddListener(UsarPersonalidad);

        botonCuerpo.onClick.AddListener(MostrarValoresCuerpo); ;
        botonAlma.onClick.AddListener(MostrarValoresAlma); ;

        botonAtras1.onClick.AddListener(AtrasCuerpo); ;
        botonAtras2.onClick.AddListener(AtrasAlma); ;

    cerrarMenu.onClick.AddListener(CerrarMenu);
    }

    void MostrarValoresCuerpo()
    {
        BotonesValores.SetActive(false);
        ValoresCuerpo.SetActive(true);
    }

    void MostrarValoresAlma()
    {
        BotonesValores.SetActive(false);
        ValoresAlma.SetActive(true);
    }

    void AtrasCuerpo()
    {
        ValoresCuerpo.SetActive(false);
        BotonesValores.SetActive(true);
    }

    void AtrasAlma()
    {
        ValoresAlma.SetActive(false);
        BotonesValores.SetActive(true);
    }

    void AbrirMenu()
    {
        IniciarValores();
        MenuValores.SetActive(true);
    }

    public void IniciarValores()
    {
        ActValor("FUERZA", Personaje.Valor("FUERZA"), Personaje.BonoValor("FUERZA"));
        ActValor("RESISTENCIA", Personaje.Valor("RESISTENCIA"), Personaje.BonoValor("RESISTENCIA"));
        ActValor("AGILIDAD", Personaje.Valor("AGILIDAD"), Personaje.BonoValor("AGILIDAD"));
        ActValor("VELOCIDAD", Personaje.Valor("VELOCIDAD"), Personaje.BonoValor("VELOCIDAD"));
        ActValor("PODER", Personaje.Valor("PODER"), Personaje.BonoValor("PODER"));
        ActValor("SENTIDOS", Personaje.Valor("SENTIDOS"), Personaje.BonoValor("SENTIDOS"));
        ActValor("MEMORIA", Personaje.Valor("MEMORIA"), Personaje.BonoValor("MEMORIA"));
        ActValor("PERSONALIDAD", Personaje.Valor("PERSONALIDAD"), Personaje.BonoValor("PERSONALIDAD"));
    }

    public void ActValor(string nombreValor, int numValor, int bonoValor)
    {
        if (nombreValor == "FUERZA")
        {
            Fuerza.text = numValor.ToString();
            if (bonoValor >= 0) { bonoFuerza.text = "+" + bonoValor; }
            else { bonoFuerza.text = bonoValor.ToString(); }
        }
        else if (nombreValor == "RESISTENCIA")
        {
            Resistencia.text = numValor.ToString();
            if (bonoValor >= 0) { bonoResistencia.text = "+" + bonoValor; }
            else { bonoResistencia.text = bonoValor.ToString(); }
        }
        else if (nombreValor == "AGILIDAD")
        {
            Agilidad.text = numValor.ToString();
            if (bonoValor >= 0) { bonoAgilidad.text = "+" + bonoValor; }
            else { bonoAgilidad.text = bonoValor.ToString(); }
        }
        else if (nombreValor == "VELOCIDAD")
        {
            Velocidad.text = numValor.ToString();
            if (bonoValor >= 0) { bonoVelocidad.text = "+" + bonoValor; }
            else { bonoVelocidad.text = bonoValor.ToString(); }
        }

        else if (nombreValor == "PODER")
        {
            Poder.text = numValor.ToString();
            if (bonoValor >= 0) { bonoPoder.text = "+" + bonoValor; }
            else { bonoPoder.text = bonoValor.ToString(); }
        }
        else if (nombreValor == "SENTIDOS")
        {
            Sentidos.text = numValor.ToString();
            if (bonoValor >= 0) { bonoSentidos.text = "+" + bonoValor; }
            else { bonoSentidos.text = bonoValor.ToString(); }
        }
        else if (nombreValor == "MEMORIA")
        {
            Memoria.text = numValor.ToString();
            if (bonoValor >= 0) { bonoMemoria.text = "+" + bonoValor; }
            else { bonoMemoria.text = bonoValor.ToString(); }
        }
        else if (nombreValor == "PERSONALIDAD")
        {
            Personalidad.text = numValor.ToString();
            if (bonoValor >= 0) { bonoPersonalidad.text = "+" + bonoValor; }
            else { bonoPersonalidad.text = bonoValor.ToString(); }
        }
    }

    void UsarFuerza()
    {
        MenuResultado("FUERZA", bonoFuerza.text);
    }

    void UsarResistencia()
    {
        MenuResultado("RESISTENCIA", bonoResistencia.text);
    }

    void UsarAgilidad()
    {
        MenuResultado("AGILIDAD", bonoAgilidad.text);
    }

    void UsarVelocidad()
    {
        MenuResultado("VELOCIDAD", bonoVelocidad.text);
    }

    void UsarPoder()
    {
        MenuResultado("PODER", bonoPoder.text);
    }

    void UsarSentidos()
    {
        MenuResultado("SENTIDOS", bonoSentidos.text);
    }

    void UsarMemoria()
    {
        MenuResultado("MEMORIA", bonoMemoria.text);
    }

    void UsarPersonalidad()
    {
        MenuResultado("PERSONALIDAD", bonoPersonalidad.text);
    }

    void MenuResultado(string valor, string bono)
    {
        int min = 1;
        int max = 21;
        int numDadoTirada = Random.Range(min, max);
        int bonoActual;
        int.TryParse(bono, out bonoActual);
        int result = bonoActual + numDadoTirada;
        if (numDadoTirada == 1)
        {
            resultadoTirada.text = "¡Pifia! Acción Fallida";
            desgloseTirada.text = numDadoTirada + " (d20)";
        }
        else if (numDadoTirada == 20)
        {
            resultadoTirada.text = "¡Milagro! Acción Asegurada";
            desgloseTirada.text = numDadoTirada + " (d20) " + bono + " (Bono " + valor + ")";
        }
        else
        {
            resultadoTirada.text = "Resultado: " + result;
            desgloseTirada.text = numDadoTirada + " (d20) " + bono + " (Bono " + valor + ")";
        }
        Debug.Log(result);
        
        StartCoroutine(StartCooldown());

    }
    public IEnumerator StartCooldown()
    {
        ObjetoMenuResultado.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        ObjetoMenuResultado.SetActive(false);
    }

    void CerrarMenu()
    {
        MenuValores.SetActive(false);
    }


}
