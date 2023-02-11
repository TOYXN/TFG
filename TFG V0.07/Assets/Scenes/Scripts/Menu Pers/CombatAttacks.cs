using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatAttacks : MonoBehaviour, IDataPersistance
{
    public Button botonAtacar;
    public Button botonHechizos;
    public Button botonAtacarMenuAtacar;
    public GameObject MenuAcciones;
    public GameObject MenuHechizos;
    public GameObject MenuAtaqueArma;
    public GameObject MenuAtaqueArmaRes;
    
    public Text nombreArma;
    public Text tipoArma;
    public Text dadoArma;
    public Text numDados;
    public Text resultadoTirada;
    public Text desgloseTirada;

    public Button botonEsquivarAtaque;
    public Button botonBloquearAtaque;
    public GameObject MenuEsquivaAtaque;
    public GameObject MenuBloqueoAtaque;
    public Text resultadoTiradaEsquiva;
    public Text desgloseTiradaEsquiva;
    public Text resultadoTiradaBloqueo;
    public Text desgloseTiradaBloqueo;
    public Button botonCalcularEsquivaFinal;
    public Button botonCalcularBloqueoFinal;
    public Text resultadoEsquivaEnemiga;
    public Text resultadoBloqueoEnemigo;
    public Text resultadoFinalEsquiva;
    public Text resultadoFinalBloqueo;
    public Button botonCerrarAtaque;
    public Button botonCerrarResuAtaque;
    public Button botonCerrarEsquiva;
    public Button botonCerrarBloqueo;

    string esquivaAtacante;
    string bloqueoAtacante;
    int resultadoAtaqueArma;

    public Text BotonDesplegable;
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
        IniciarBotones();
    }

    void IniciarBotones()
    {
        botonAtacar.onClick.AddListener(atacarArma);
        botonHechizos.onClick.AddListener(usarHechizo);
        botonAtacarMenuAtacar.onClick.AddListener(Atacar);
        botonEsquivarAtaque.onClick.AddListener(Esquiva);
        botonBloquearAtaque.onClick.AddListener(Bloqueo);
        botonCalcularEsquivaFinal.onClick.AddListener(CalcularEsquiva);
        botonCalcularBloqueoFinal.onClick.AddListener(CalcularBloqueo);
        botonCerrarAtaque.onClick.AddListener(CerrarAtaque);
        botonCerrarResuAtaque.onClick.AddListener(CerrarResu);
        botonCerrarEsquiva.onClick.AddListener(CerrarEsquiva);
        botonCerrarBloqueo.onClick.AddListener(CerrarBloqueo);
    }

    void atacarArma()
    {
        nombreArma.text = Personaje.ArmaEquipada.nombreArma;
        tipoArma.text = Personaje.ArmaEquipada.tipoArma;
        dadoArma.text = "d" + Personaje.ArmaEquipada.dadoArma;
        numDados.text = Personaje._otros.numDados.ToString();
        MenuAtaqueArma.SetActive(true);
    }
    void Atacar()
    {
        int min = 1;
        int max = Personaje.ArmaEquipada.dadoArma + 1;
        int numDadoTirada;
        int result = 0;
        int bonoActual = Personaje.BonoValor(Personaje.ArmaEquipada.tipoArma);
        for (int i = 0; i < Personaje._otros.numDados; i++)
        {
            numDadoTirada = Random.Range(min, max);
            result = result + numDadoTirada;
            desgloseTirada.text += numDadoTirada + " (" + dadoArma.text + ") " + "+ ";
        }
        result = result + bonoActual;
        
        if (Personaje.cargado)
        {
            result = result + Personaje.valorCargado;
            desgloseTirada.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") + " + Personaje.valorCargado + " (Ataque cargado)";
            Personaje.valorCargado = 0;
            Personaje.cargado = false;
        }
        else
        {
            desgloseTirada.text += bonoActual + " (Bono " + tipoArma.text + ") ";
        }
        resultadoAtaqueArma = result;
        resultadoTirada.text = "Resultado: " + result;
        
        Debug.Log(result);
        MenuAtaqueArmaRes.SetActive(true);
    }

    void Esquiva()
    {
        int min = 1;
        int max = 21;
        int numDadoTirada = Random.Range(min, max);
        int bonoActual = Personaje.BonoValor("AGILIDAD");
        int result;
        if (numDadoTirada == 1)
        {
            resultadoTiradaEsquiva.text = "¡Pifia!";
            desgloseTiradaEsquiva.text = numDadoTirada + " (d20)";
            esquivaAtacante = "Pifia";
        }
        else if (numDadoTirada == 20)
        {
            resultadoTiradaEsquiva.text = "¡Milagro!";
            desgloseTiradaEsquiva.text = numDadoTirada + " (d20) ";
            esquivaAtacante = "Milagro";
        }
        else
        {
            result = numDadoTirada + bonoActual;
            esquivaAtacante = result.ToString();
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
        int bonoActual = Personaje.BonoValor(Personaje.ArmaEquipada.tipoArma);
        int result;
        if (numDadoTirada == 1)
        {
            resultadoTiradaBloqueo.text = "¡Pifia!";
            desgloseTiradaBloqueo.text = numDadoTirada + " (d20)";
            bloqueoAtacante = "Pifia";
        }
        else if (numDadoTirada == 20)
        {
            resultadoTiradaBloqueo.text = "¡Milagro!";
            desgloseTiradaBloqueo.text = numDadoTirada + " (d20) ";
            bloqueoAtacante = "Milagro";
        }
        else
        {
            result = numDadoTirada + bonoActual;
            bloqueoAtacante = result.ToString();
            resultadoTiradaBloqueo.text = "Tu resultado: " + result; 
            desgloseTiradaBloqueo.text = numDadoTirada + " (d20) + " + bonoActual + " (Bono " + tipoArma.text + ") ";
            Debug.Log(result);
        }

        MenuBloqueoAtaque.SetActive(true);
    }

    void CalcularEsquiva()
    {
        int valorEsquivaEnemiga;
        int valorEsquivaAtacante;
        int dmgTotal;
        if(resultadoEsquivaEnemiga.text == "Pifia")
        {
            if(esquivaAtacante == "Pifia")
            {
                resultadoFinalEsquiva.text = "Ataque fallido";
            }
            else
            {
                dmgTotal = resultadoAtaqueArma * 2;
                resultadoFinalEsquiva.text = "Infringes " + dmgTotal + " de daño";
            }
        }
        else if (resultadoEsquivaEnemiga.text == "Milagro")
        {
            if (esquivaAtacante == "Milagro")
            {
                dmgTotal = resultadoAtaqueArma;
                resultadoFinalEsquiva.text = "Infringes " + dmgTotal + " de daño";
            }
            else
            {
                resultadoFinalEsquiva.text = "¡El enemigo contraataca!";
            }
        }
        else
        {
            if (esquivaAtacante == "Pifia")
            {
                resultadoFinalEsquiva.text = "¡El enemigo contraataca!";
            }
            else if (esquivaAtacante == "Milagro" || Personaje.oculto)
            {
                dmgTotal = resultadoAtaqueArma * 2;
                resultadoFinalEsquiva.text = "¡Golpe Crítico! Infringes " + dmgTotal + " de daño";
                Personaje.oculto = false;
            }
            else
            {
                int.TryParse(resultadoEsquivaEnemiga.text, out valorEsquivaEnemiga);
                int.TryParse(esquivaAtacante, out valorEsquivaAtacante);
                if(valorEsquivaEnemiga >= valorEsquivaAtacante)
                {
                    resultadoFinalEsquiva.text = "¡El enemigo esquivó el ataque!";
                }
                else
                {
                    dmgTotal = resultadoAtaqueArma;
                    resultadoFinalEsquiva.text = "Infringes " + dmgTotal + " de daño";
                }
            }
        }

    }

    void CalcularBloqueo()
    {
        int valorBloqueoEnemiga;
        int valorBloqueoAtacante;
        int dmgTotal;
        if (resultadoBloqueoEnemigo.text == "Pifia")
        {
            if (bloqueoAtacante == "Pifia")
            {
                resultadoFinalEsquiva.text = "Ataque fallido";
            }
            else
            {
                dmgTotal = resultadoAtaqueArma * 2;
                resultadoFinalBloqueo.text = "Infringes " + dmgTotal + " de daño";
            }
        }
        else if (resultadoBloqueoEnemigo.text == "Milagro")
        {
            if (bloqueoAtacante == "Milagro")
            {
                dmgTotal = resultadoAtaqueArma;
                resultadoFinalBloqueo.text = "Infringes " + dmgTotal + " de daño";
            }
            else
            {
                resultadoFinalBloqueo.text = "¡El enemigo contraataca!";
            }
        }
        else
        {
            if (bloqueoAtacante == "Pifia")
            {
                resultadoFinalBloqueo.text = "¡El enemigo contraataca!";
            }
            else if (bloqueoAtacante == "Milagro" || Personaje.oculto)
            {
                dmgTotal = resultadoAtaqueArma * 2;
                resultadoFinalBloqueo.text = "¡Golpe Crítico! Infringes " + dmgTotal + " de daño";
                Personaje.oculto = false;
            }
            else
            {
                int.TryParse(resultadoBloqueoEnemigo.text, out valorBloqueoEnemiga);
                int.TryParse(bloqueoAtacante, out valorBloqueoAtacante);
                if (valorBloqueoEnemiga >= valorBloqueoAtacante)
                {
                    dmgTotal = resultadoAtaqueArma - (valorBloqueoEnemiga - valorBloqueoAtacante);
                    if (dmgTotal <= 0)
                    {
                        dmgTotal = 0;
                        resultadoFinalBloqueo.text = "¡El enemigo bloqueó el ataque completamente!";
                    }
                    else
                    {
                        resultadoFinalBloqueo.text = "¡El enemigo se defendió! Infringes " + dmgTotal + " de daño";
                    }
                    
                }
                else
                {
                    dmgTotal = resultadoAtaqueArma;
                    resultadoFinalBloqueo.text = "Infringes " + dmgTotal + " de daño";
                }
            }
        }

    }

    void CerrarAtaque()
    {
        MenuAtaqueArma.SetActive(false);
    }

    void CerrarResu()
    {
        MenuAtaqueArmaRes.SetActive(false);
        desgloseTirada.text = " ";
    }

    void CerrarEsquiva()
    {
        resultadoFinalEsquiva.text = " ";
        MenuEsquivaAtaque.SetActive(false);
    }

    void CerrarBloqueo()
    {
        resultadoFinalBloqueo.text = " ";
        MenuBloqueoAtaque.SetActive(false);
    }

    void usarHechizo()
    {
        BotonDesplegable.text = "HECHIZOS";
        MenuHechizos.SetActive(true);
        MenuAcciones.SetActive(false);
    }
}
