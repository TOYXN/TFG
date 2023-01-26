using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso2_4 : MonoBehaviour
{
    public GameObject Menu2_3;
    public GameObject Menu2_4;
    public GameObject Menu2_5;
    public GameObject Menu3_1;

    public Image imagenPaso3;

    public Button continuar2_4;
    public GameObject continuar2_4GO;
    public Button atras2_4;
    public Button continuar2_5;
    public Button atras2_5;

    public Button num1;
    public Button num2;
    public Button num3;
    public Button num4;
    public Button num5;
    public Button num6;
    public Button num7;
    public Button num8;
    public Text num1Text;
    public Text num2Text;
    public Text num3Text;
    public Text num4Text;
    public Text num5Text;
    public Text num6Text;
    public Text num7Text;
    public Text num8Text;
    public GameObject num1GO;
    public GameObject num2GO;
    public GameObject num3GO;
    public GameObject num4GO;
    public GameObject num5GO;
    public GameObject num6GO;
    public GameObject num7GO;
    public GameObject num8GO;

    public GameObject MenuSelecValor;
    public Text numValorAct;
    public Button fuerza;
    public Button resistencia;
    public Button agilidad;
    public Button velocidad;
    public Button poder;
    public Button sentidos;
    public Button memoria;
    public Button personalidad;
    public GameObject fuerzaGO;
    public GameObject resistenciaGO;
    public GameObject agilidadGO;
    public GameObject velocidadGO;
    public GameObject poderGO;
    public GameObject sentidosGO;
    public GameObject memoriaGO;
    public GameObject personalidadGO;
    public Button cerrarMenuValores;

    public GameObject MenuValor;
    public Text nombValor;
    public Text descValor;
    public Text pregunta;
    public Button seleccionar;
    public Button cerrarMenuValor;

    public Text numFuerza;
    public Text bonoFuerza;
    public Text numResistencia;
    public Text bonoResistencia;
    public Text numAgilidad;
    public Text bonoAgilidad;
    public Text numVelocidad;
    public Text bonoVelocidad;
    public Text numPoder;
    public Text bonoPoder;
    public Text numSentidos;
    public Text bonoSentidos;
    public Text numMemoria;
    public Text bonoMemoria;
    public Text numPersonalidad;
    public Text bonoPersonalidad;

    public Button confirmar;
    public Button reiniciar;

    public GameObject ProcesoSelecc;
    public GameObject ProcesoPost;

    int num;
    int numValoresSelec;
    string valorSelec;
    GameObject numSelecBoton;
    GameObject valorSelecBoton;
    public Personaje Personaje;

    // Start is called before the first frame update
    void Start()
    {
        numValoresSelec = 0;
        continuar2_4.onClick.AddListener(Siguiente1);
        atras2_4.onClick.AddListener(Atras1);
        continuar2_5.onClick.AddListener(Siguiente2);
        atras2_5.onClick.AddListener(Atras2);
        num1.onClick.AddListener(Bypass1);
        num2.onClick.AddListener(Bypass2);
        num3.onClick.AddListener(Bypass3);
        num4.onClick.AddListener(Bypass4);
        num5.onClick.AddListener(Bypass5);
        num6.onClick.AddListener(Bypass6);
        num7.onClick.AddListener(Bypass7);
        num8.onClick.AddListener(Bypass8);
        fuerza.onClick.AddListener(Bypass9);
        resistencia.onClick.AddListener(Bypass10);
        agilidad.onClick.AddListener(Bypass11);
        velocidad.onClick.AddListener(Bypass12);
        poder.onClick.AddListener(Bypass13);
        sentidos.onClick.AddListener(Bypass14);
        memoria.onClick.AddListener(Bypass15);
        personalidad.onClick.AddListener(Bypass16);
        cerrarMenuValores.onClick.AddListener(CerrarPrimerMenu);
        cerrarMenuValor.onClick.AddListener(CerrarSegundoMenu);
        seleccionar.onClick.AddListener(AsignarValor);
        confirmar.onClick.AddListener(ConfirmarAsignacion);
        reiniciar.onClick.AddListener(ReiniciarAsignacion);
    }

    void Bypass1()
    {
        string numero = num1Text.text;
        numSelecBoton = num1GO;
        int.TryParse(numero, out num);
        numValorAct.text = "¿Cual valor asignar " + numero + "?";
        MenuSelecValor.SetActive(true);
    }
    void Bypass2()
    {
        string numero = num2Text.text;
        numSelecBoton = num2GO;
        int.TryParse(numero, out num);
        numValorAct.text = "¿Cual valor asignar " + numero + "?";
        MenuSelecValor.SetActive(true);
    }
    void Bypass3()
    {
        string numero = num3Text.text;
        numSelecBoton = num3GO;
        int.TryParse(numero, out num);
        numValorAct.text = "¿Cual valor asignar " + numero + "?";
        MenuSelecValor.SetActive(true);
    }
    void Bypass4()
    {
        string numero = num4Text.text;
        numSelecBoton = num4GO;
        int.TryParse(numero, out num);
        numValorAct.text = "¿Cual valor asignar " + numero + "?";
        MenuSelecValor.SetActive(true);
    }
    void Bypass5()
    {
        string numero = num5Text.text;
        numSelecBoton = num5GO;
        int.TryParse(numero, out num);
        numValorAct.text = "¿Cual valor asignar " + numero + "?";
        MenuSelecValor.SetActive(true);
    }
    void Bypass6()
    {
        string numero = num6Text.text;
        numSelecBoton = num6GO;
        int.TryParse(numero, out num);
        numValorAct.text = "¿Cual valor asignar " + numero + "?";
        MenuSelecValor.SetActive(true);
    }
    void Bypass7()
    {
        string numero = num7Text.text;
        numSelecBoton = num7GO;
        int.TryParse(numero, out num);
        numValorAct.text = "¿Cual valor asignar " + numero + "?";
        MenuSelecValor.SetActive(true);
    }
    void Bypass8()
    {
        string numero = num8Text.text;
        numSelecBoton = num8GO;
        int.TryParse(numero, out num);
        numValorAct.text = "¿Cual valor asignar " + numero + "?";
        MenuSelecValor.SetActive(true);
    }

    void Bypass9()
    {
        string valor = "FUERZA";
        valorSelec = valor;
        nombValor.text = valor;
        descValor.text = "Simboliza cómo de fuerte es tu personaje. La habilidad de manipular objetos pesados, golpear con potencia o ejecutar acciones que requieran del uso de la fuerza dependen de este valor.";
        pregunta.text = "¿Colocar " + num + "  como valor base de " + valor + "?";
        valorSelecBoton = fuerzaGO;
        MenuValor.SetActive(true);
    }
    void Bypass10()
    {
        string valor = "RESISTENCIA";
        valorSelec = valor;
        nombValor.text = valor;
        descValor.text = "Simboliza la vitalidad y resistencia física de tu personaje. Sus puntos de cuerpo (PC) o vida, por defecto, al igual que sus fortalezas físicas como poder correr durante mucho tiempo o resistiendo venenos se vinculan a este valor.";
        pregunta.text = "¿Colocar " + num + "  como valor base de " + valor + "?";
        valorSelecBoton = resistenciaGO;
        MenuValor.SetActive(true);
    }
    void Bypass11()
    {
        string valor = "AGILIDAD";
        valorSelec = valor;
        nombValor.text = valor;
        descValor.text = "Simboliza la facilidad que tiene el personaje de esquivar, hacer acrobacias o movimientos complicados en general. También simboliza la destreza con las manos para hacer cualquier uso de estas, ya sea utilizar una herramienta correctamente o robar algo sin alertar.";
        pregunta.text = "¿Colocar " + num + "  como valor base de " + valor + "?";
        valorSelecBoton = agilidadGO;
        MenuValor.SetActive(true);
    }
    void Bypass12()
    {
        string valor = "VELOCIDAD";
        valorSelec = valor;
        nombValor.text = valor;
        descValor.text = "Simboliza la rapidez que tiene el personaje para moverse, tomar decisiones o hacer cualquier otro tipo de acción. Las Acciones Por Turno (APT) del personaje dependen se este valor.";
        pregunta.text = "¿Colocar " + num + "  como valor base de " + valor + "?";
        valorSelecBoton = velocidadGO;
        MenuValor.SetActive(true);
    }
    void Bypass13()
    {
        string valor = "PODER";
        valorSelec = valor;
        nombValor.text = valor;
        descValor.text = "Simboliza la voluntad del alma que tiene el personaje, la facilidad para ejecutar hechizos, su densidad y su potencia así como el vínculo de sí mismo con el planeta. Los Puntos Almáticos (PA) o por defecto, puntos mágicos o maná estan vinculados a este valor.";
        pregunta.text = "¿Colocar " + num + "  como valor base de " + valor + "?";
        valorSelecBoton = poderGO;
        MenuValor.SetActive(true);
    }
    void Bypass14()
    {
        string valor = "SENTIDOS";
        valorSelec = valor;
        nombValor.text = valor;
        descValor.text = "Simboliza la perspicacia, intuición y capacidades sensoriales del personaje. La capacidad auditiva, ocular, gustativa, olfativa y del tacto del personaje son representadas en este valor.";
        pregunta.text = "¿Colocar " + num + "  como valor base de " + valor + "?";
        valorSelecBoton = sentidosGO;
        MenuValor.SetActive(true);
    }
    void Bypass15()
    {
        string valor = "MEMORIA";
        valorSelec = valor;
        nombValor.text = valor;
        descValor.text = "Simboliza la capacidad de obtener conocimiento o de recordar del personaje. Todas las acciones que dependan del saber, al igual que el número de hechizos conocidos del personaje estan vinculadas a este valor.";
        pregunta.text = "¿Colocar " + num + "  como valor base de " + valor + "?";
        valorSelecBoton = memoriaGO;
        MenuValor.SetActive(true);
    }
    void Bypass16()
    {
        string valor = "PERSONALIDAD";
        valorSelec = valor;
        nombValor.text = valor;
        descValor.text = "Simboliza el carisma del personaje y su labia. La capacidad de encandilar una conversación o de destacar entre el resto esta vinculada a este valor.";
        pregunta.text = "¿Colocar " + num + "  como valor base de " + valor + "?";
        valorSelecBoton = personalidadGO;
        MenuValor.SetActive(true);
    }

    void AsignarValor()
    {
        Personaje.ActualizarValor(valorSelec, num);
        numValoresSelec++;
        numSelecBoton.SetActive(false);
        valorSelecBoton.SetActive(false);
        MenuValor.SetActive(false);
        MenuSelecValor.SetActive(false);
        if(numValoresSelec == 8)
        {
            ActValores();
            ProcesoSelecc.SetActive(false);
            ProcesoPost.SetActive(true);
        }
    }

    public void ActValores()
    {
        int numValor = Personaje.Valor("FUERZA");
        int bonoValor = Personaje.BonoValor("FUERZA");
        numFuerza.text = numValor.ToString();
        if (bonoValor >= 0) { bonoFuerza.text = "+" + bonoValor; }
        else { bonoFuerza.text = bonoValor.ToString(); }

        numValor = Personaje.Valor("RESISTENCIA");
        bonoValor = Personaje.BonoValor("RESISTENCIA");
        numResistencia.text = numValor.ToString();
        if (bonoValor >= 0) { bonoResistencia.text = "+" + bonoValor; }
        else { bonoResistencia.text = bonoValor.ToString(); }

        numValor = Personaje.Valor("AGILIDAD");
        bonoValor = Personaje.BonoValor("AGILIDAD");
        numAgilidad.text = numValor.ToString();
        if (bonoValor >= 0) { bonoAgilidad.text = "+" + bonoValor; }
        else { bonoAgilidad.text = bonoValor.ToString(); }

        numValor = Personaje.Valor("VELOCIDAD");
        bonoValor = Personaje.BonoValor("VELOCIDAD");
        numVelocidad.text = numValor.ToString();
        if (bonoValor >= 0) { bonoVelocidad.text = "+" + bonoValor; }
        else { bonoVelocidad.text = bonoValor.ToString(); }

        numValor = Personaje.Valor("PODER");
        bonoValor = Personaje.BonoValor("PODER");
        numPoder.text = numValor.ToString();
        if (bonoValor >= 0) { bonoPoder.text = "+" + bonoValor; }
        else { bonoPoder.text = bonoValor.ToString(); }

        numValor = Personaje.Valor("SENTIDOS");
        bonoValor = Personaje.BonoValor("SENTIDOS");
        numSentidos.text = numValor.ToString();
        if (bonoValor >= 0) { bonoSentidos.text = "+" + bonoValor; }
        else { bonoSentidos.text = bonoValor.ToString(); }

        numValor = Personaje.Valor("MEMORIA");
        bonoValor = Personaje.BonoValor("MEMORIA");
        numMemoria.text = numValor.ToString();
        if (bonoValor >= 0) { bonoMemoria.text = "+" + bonoValor; }
        else { bonoMemoria.text = bonoValor.ToString(); }

        numValor = Personaje.Valor("PERSONALIDAD");
        bonoValor = Personaje.BonoValor("PERSONALIDAD");
        numPersonalidad.text = numValor.ToString();
        if (bonoValor >= 0) { bonoPersonalidad.text = "+" + bonoValor; }
        else { bonoPersonalidad.text = bonoValor.ToString(); }
    }
        void ConfirmarAsignacion()
    {
        ProcesoPost.SetActive(false);
        continuar2_4GO.SetActive(true);
    }

    void ReiniciarAsignacion()
    {
        num1GO.SetActive(true);
        num2GO.SetActive(true);
        num3GO.SetActive(true);
        num4GO.SetActive(true);
        num5GO.SetActive(true);
        num6GO.SetActive(true);
        num7GO.SetActive(true);
        num8GO.SetActive(true);
        numValoresSelec = 0;

        fuerzaGO.SetActive(true);
        resistenciaGO.SetActive(true);
        agilidadGO.SetActive(true);
        velocidadGO.SetActive(true);
        poderGO.SetActive(true);
        sentidosGO.SetActive(true);
        memoriaGO.SetActive(true);
        personalidadGO.SetActive(true);
        ProcesoPost.SetActive(false);
        ProcesoSelecc.SetActive(true);
    }

    void Siguiente1()
    {
        Menu2_5.SetActive(true);
    }

    void Siguiente2()
    {
        imagenPaso3.color = new Vector4(255, 255, 255, 100);
        Menu3_1.SetActive(true);
    }

    void Atras1()
    {
        num1GO.SetActive(true);
        num2GO.SetActive(true);
        num3GO.SetActive(true);
        num4GO.SetActive(true);
        num5GO.SetActive(true);
        num6GO.SetActive(true);
        num7GO.SetActive(true);
        num8GO.SetActive(true);
        numValoresSelec = 0;

        fuerzaGO.SetActive(true);
        resistenciaGO.SetActive(true);
        agilidadGO.SetActive(true);
        velocidadGO.SetActive(true);
        poderGO.SetActive(true);
        sentidosGO.SetActive(true);
        memoriaGO.SetActive(true);
        personalidadGO.SetActive(true);

        continuar2_4GO.SetActive(false);
        MenuValor.SetActive(false);
        ProcesoSelecc.SetActive(true);
        ProcesoPost.SetActive(false);
        MenuSelecValor.SetActive(false);
        Menu2_4.SetActive(false);
    }

    void Atras2()
    {
        Menu2_5.SetActive(false);
    }

    void CerrarPrimerMenu()
    {
        MenuSelecValor.SetActive(false);
    }

    void CerrarSegundoMenu()
    {
        MenuValor.SetActive(false);
    }
}
