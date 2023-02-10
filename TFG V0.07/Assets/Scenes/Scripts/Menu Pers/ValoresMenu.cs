using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValoresMenu : MonoBehaviour
{
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

    public Text APT;

    public Button botonFuerza;
    public Button botonResistencia;
    public Button botonAgilidad;
    public Button botonVelocidad;
    public Button botonPoder;
    public Button botonSentidos;
    public Button botonMemoria;
    public Button botonPersonalidad;

    public GameObject menuFisico;
    public Text tituloFisico;
    public Text descripcionFisico;
    public Text bonoFisico;
    public Text numeroModifFisico;
    public Button botonRestarFisico;
    public Button botonSumarFisico;
    public Button cerrarMenuFisico;

    public GameObject menuAlma;
    public Text tituloAlma;
    public Text descripcionAlma;
    public Text bonoAlma;
    public Text numeroModifAlma;
    public Button botonRestarAlma;
    public Button botonSumarAlma;
    public Button cerrarMenuAlma;

    public GameObject menuAPT;
    public Button botonAPT;
    public Button cerrarAPT;

    public Personaje Personaje;
    public Acciones Acciones;

    // Start is called before the first frame update
    void Start()
    {
        botonFuerza.onClick.AddListener(Bypass1);
        botonResistencia.onClick.AddListener(Bypass2);
        botonAgilidad.onClick.AddListener(Bypass3);
        botonVelocidad.onClick.AddListener(Bypass4);
        botonPoder.onClick.AddListener(Bypass5);
        botonSentidos.onClick.AddListener(Bypass6);
        botonMemoria.onClick.AddListener(Bypass7);
        botonPersonalidad.onClick.AddListener(Bypass8);
        botonRestarFisico.onClick.AddListener(AplicarDebuffFisico);
        botonSumarFisico.onClick.AddListener(AplicarBuffFisico);
        cerrarMenuFisico.onClick.AddListener(CerrarMenuFisico);
        botonRestarAlma.onClick.AddListener(AplicarDebuffAlma);
        botonSumarAlma.onClick.AddListener(AplicarBuffAlma);
        cerrarMenuAlma.onClick.AddListener(CerrarMenuAlma);
        botonAPT.onClick.AddListener(AbrirAPT);
        cerrarAPT.onClick.AddListener(CerrarAPT);
        Acciones.PonerAccionesVent();
        Acciones.actualizarBonos();

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

    void Bypass1()
    {
        string desc = "Simboliza cómo de fuerte es tu personaje. La habilidad de manipular objetos pesados, golpear con potencia o ejecutar acciones que requieran del uso de la fuerza dependen de este valor.";
        AbrirMenuFisico("FUERZA", desc, bonoFuerza.text);
    }

    void Bypass2()
    {
        string desc = "Simboliza la vitalidad y resistencia física de tu personaje. Sus puntos de cuerpo (PC) o vida, por defecto, al igual que sus fortalezas físicas como poder correr durante mucho tiempo o resistiendo venenos se vinculan a este valor.";
        AbrirMenuFisico("RESISTENCIA", desc, bonoResistencia.text);
    }

    void Bypass3()
    {
        string desc = "Simboliza la facilidad que tiene el personaje de esquivar, hacer acrobacias o movimientos complicados en general. También simboliza la destreza con las manos para hacer cualquier uso de estas, ya sea utilizar una herramienta correctamente o robar algo sin alertar.";
        AbrirMenuFisico("AGILIDAD", desc, bonoAgilidad.text);
    }

    void Bypass4()
    {
        string desc = "Simboliza la rapidez que tiene el personaje para moverse, tomar decisiones o hacer cualquier otro tipo de acción. Las Acciones Por Turno (APT) del personaje dependen se este valor.";
        AbrirMenuFisico("VELOCIDAD", desc, bonoVelocidad.text);
    }

    public void AbrirMenuFisico(string titulo, string descripcion, string bonoAct)
    {
        tituloFisico.text = titulo;
        descripcionFisico.text = descripcion;
        bonoFisico.text = bonoAct;
        menuFisico.SetActive(true);
    }

    void Bypass5()
    {
        string desc = "Simboliza la voluntad del alma que tiene el personaje, la facilidad para ejecutar hechizos, su densidad y su potencia así como el vínculo de sí mismo con el planeta. Los Puntos Almáticos (PA) o por defecto, puntos mágicos o maná estan vinculados a este valor.";
        AbrirMenuAlma("PODER", desc, bonoPoder.text);
    }

    void Bypass6()
    {
        string desc = "Simboliza la perspicacia, intuición y capacidades sensoriales del personaje. La capacidad auditiva, ocular, gustativa, olfativa y del tacto del personaje son representadas en este valor.";
        AbrirMenuAlma("SENTIDOS", desc, bonoSentidos.text);
    }

    void Bypass7()
    {
        string desc = "Simboliza la capacidad de obtener conocimiento o de recordar del personaje. Todas las acciones que dependan del saber, al igual que el número de hechizos conocidos del personaje estan vinculadas a este valor.";
        AbrirMenuAlma("MEMORIA", desc, bonoMemoria.text);
    }

    void Bypass8()
    {
        string desc = "Simboliza el carisma del personaje y su labia. La capacidad de encandilar una conversación o de destacar entre el resto esta vinculada a este valor.";
        AbrirMenuAlma("PERSONALIDAD", desc, bonoPersonalidad.text);
    }

    public void AbrirMenuAlma(string titulo, string descripcion, string bonoAct)
    {
        tituloAlma.text = titulo;
        descripcionAlma.text = descripcion;
        bonoAlma.text = bonoAct;
        menuAlma.SetActive(true);
    }

    void AplicarDebuffFisico()
    {
        int valorRestar;
        int.TryParse(numeroModifFisico.text, out valorRestar);

        Personaje.ActualizarValorBuff(tituloFisico.text, - valorRestar);
        int valorFinal = Personaje.Valor(tituloFisico.text);
        int bonoFinal = Personaje.BonoValor(tituloFisico.text);
        if (bonoFinal >= 0) { bonoFisico.text = "+" + bonoFinal; }
        else { bonoFisico.text = bonoFinal.ToString(); }
        ActValor(tituloFisico.text, valorFinal, bonoFinal);
    }

    void AplicarBuffFisico()
    {
        int valorSumar;
        int.TryParse(numeroModifFisico.text, out valorSumar);

        Personaje.ActualizarValorBuff(tituloFisico.text, valorSumar);
        int valorFinal = Personaje.Valor(tituloFisico.text);
        int bonoFinal = Personaje.BonoValor(tituloFisico.text);
        if (bonoFinal >= 0) { bonoFisico.text = "+" + bonoFinal; }
        else { bonoFisico.text = bonoFinal.ToString(); }
        ActValor(tituloFisico.text, valorFinal, bonoFinal);
    }

    void CerrarMenuFisico()
    {
        menuFisico.SetActive(false);
    }

    void AplicarDebuffAlma()
    {
        int valorRestar;
        int.TryParse(numeroModifAlma.text, out valorRestar);

        Personaje.ActualizarValorBuff(tituloAlma.text, -valorRestar);
        int valorFinal = Personaje.Valor(tituloAlma.text);
        int bonoFinal = Personaje.BonoValor(tituloAlma.text);
        if (bonoFinal >= 0) { bonoAlma.text = "+" + bonoFinal; }
        else { bonoAlma.text = bonoFinal.ToString(); }
        ActValor(tituloAlma.text, valorFinal, bonoFinal);
    }

    void AplicarBuffAlma()
    {
        int valorSumar;
        int.TryParse(numeroModifAlma.text, out valorSumar);

        Personaje.ActualizarValorBuff(tituloAlma.text, valorSumar);
        int valorFinal = Personaje.Valor(tituloAlma.text);
        int bonoFinal = Personaje.BonoValor(tituloAlma.text);
        if (bonoFinal >= 0) { bonoAlma.text = "+" + bonoFinal; }
        else { bonoAlma.text = bonoFinal.ToString(); }
        ActValor(tituloAlma.text, valorFinal, bonoFinal);
    }

    void CerrarMenuAlma()
    {
        menuAlma.SetActive(false);
    }

    void AbrirAPT()
    {
        menuAPT.SetActive(true);
    }

    void CerrarAPT()
    {
        menuAPT.SetActive(false);
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
            APT.text = Personaje._otros.apt.ToString();
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
        Acciones.actualizarBonos();
    }
}
