using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Acciones : MonoBehaviour
{
    List<string> fuerza = new List<string>();
    List<string> resistencia = new List<string>();
    List<string> agilidad = new List<string>();
    List<string> velocidad = new List<string>();
    List<string> poder = new List<string>();
    List<string> sentidos = new List<string>();
    List<string> memoria = new List<string>();
    List<string> personalidad = new List<string>();

    public Button accVent1;
    public Button accVent2;
    public Button accVent3;
    public Button accVent4;
    public Text textaccVent1;
    public Text textaccVent2;
    public Text textaccVent3;
    public Text textaccVent4;

    private int bonoFuerza;
    private int bonoResistencia;
    private int bonoAgilidad;
    private int bonoVelocidad;
    private int bonoPoder;
    private int bonoSentidos;
    private int bonoMemoria;
    private int bonoPersonalidad;
    private int bonoVent1;
    private int bonoVent2;
    private int bonoVent3;
    private int bonoVent4;

    public Button percibir;
    public Button escuchar;
    public Button degustar;
    public Button oler;
    public Button correr;
    public Button saltar;
    public Button trepar;
    public Button nadar;
    public Button persuadir;
    public Button intimidar;
    public Button negociar;
    public Button mentir;
    public Button robar;
    public Button sigilar;
    public Button disfrazar;
    public Button recordar;
    public Button magicologia;
    public Button medicina;
    public Button historia;
    public Button legislacion;
    public Button zoologia;
    public Button botanica;
    public Button ciencia;
    public Button bailar;
    public Button cantar;

    public Button botonTirar;
    public Text resultado;
    public Text DesgloseResultado;

    public Button cerrarMenu;

    public Personaje Personaje;
    public GameObject menuAcciones;
    public Text tituloAccion;
    public Text descAccion;
    public Text bonoNum;

    // Start is called before the first frame update
    void Start()
    {
        ActivarAccionesVentaja();
        ActivarAccionesFuerza();
        ActivarAccionesResist();
        ActivarAccionesAgilidad();
        ActivarAccionesVelocidad();
        ActivarAccionesPoder();
        ActivarAccionesSentidos();
        ActivarAccionesMemoria();
        ActivarAccionesPersonalidad();
        cerrarMenu.onClick.AddListener(CerrarMenu);
        botonTirar.onClick.AddListener(HacerTirada);
        resultado.enabled = false;
        DesgloseResultado.enabled = false;
        actualizarBonos();
    }

    public void PonerAccionesVent()
    {
        textaccVent1.text = Personaje.accVent1;
        textaccVent2.text = Personaje.accVent2;
        textaccVent3.text = Personaje.accVent3;
        textaccVent4.text = Personaje.accVent4;
    }

    public void actualizarBonos()
    {
        GuardarBonos();
        GuardarBonosVentaja(textaccVent1.text, 1);
        GuardarBonosVentaja(textaccVent2.text, 2);
        GuardarBonosVentaja(textaccVent3.text, 3);
        GuardarBonosVentaja(textaccVent4.text, 4);
    }

    void GuardarBonos()
    {
        bonoFuerza = Personaje.BonoValor("FUERZA");
        bonoResistencia = Personaje.BonoValor("RESISTENCIA");
        bonoAgilidad = Personaje.BonoValor("AGILIDAD");
        bonoVelocidad = Personaje.BonoValor("VELOCIDAD");
        bonoPoder = Personaje.BonoValor("PODER");
        bonoSentidos = Personaje.BonoValor("SENTIDOS");
        bonoMemoria = Personaje.BonoValor("MEMORIA");
        bonoPersonalidad = Personaje.BonoValor("PERSONALIDAD");
    }

    void GuardarBonosVentaja(string accion, int num)
    {
        if (fuerza.Contains(accion))
        {
            if(num == 1) { bonoVent1 = Personaje.BonoValor("FUERZA") + 2; }
            else if(num == 2) { bonoVent2 = Personaje.BonoValor("FUERZA") + 2; }
            else if (num == 3) { bonoVent3 = Personaje.BonoValor("FUERZA") + 2; }
            else if (num == 4) { bonoVent4 = Personaje.BonoValor("FUERZA") + 2; }
        }
        else if (resistencia.Contains(accion))
        {
            if (num == 1) { bonoVent1 = Personaje.BonoValor("RESISTENCIA") + 2; }
            else if (num == 2) { bonoVent2 = Personaje.BonoValor("RESISTENCIA") + 2; }
            else if (num == 3) { bonoVent3 = Personaje.BonoValor("RESISTENCIA") + 2; }
            else if (num == 4) { bonoVent4 = Personaje.BonoValor("RESISTENCIA") + 2; }
        }
        else if (agilidad.Contains(accion))
        {
            if (num == 1) { bonoVent1 = Personaje.BonoValor("AGILIDAD") + 2; }
            else if (num == 2) { bonoVent2 = Personaje.BonoValor("AGILIDAD") + 2; }
            else if (num == 3) { bonoVent3 = Personaje.BonoValor("AGILIDAD") + 2; }
            else if (num == 4) { bonoVent4 = Personaje.BonoValor("AGILIDAD") + 2; }
        }
        else if (velocidad.Contains(accion))
        {
            if (num == 1) { bonoVent1 = Personaje.BonoValor("VELOCIDAD") + 2; }
            else if (num == 2) { bonoVent2 = Personaje.BonoValor("VELOCIDAD") + 2; }
            else if (num == 3) { bonoVent3 = Personaje.BonoValor("VELOCIDAD") + 2; }
            else if (num == 4) { bonoVent4 = Personaje.BonoValor("VELOCIDAD") + 2; }
        }
        else if (poder.Contains(accion))
        {
            if (num == 1) { bonoVent1 = Personaje.BonoValor("PODER") + 2; }
            else if (num == 2) { bonoVent2 = Personaje.BonoValor("PODER") + 2; }
            else if (num == 3) { bonoVent3 = Personaje.BonoValor("PODER") + 2; }
            else if (num == 4) { bonoVent4 = Personaje.BonoValor("PODER") + 2; }
        }
        else if (sentidos.Contains(accion))
        {
            if (num == 1) { bonoVent1 = Personaje.BonoValor("SENTIDOS") + 2; }
            else if (num == 2) { bonoVent2 = Personaje.BonoValor("SENTIDOS") + 2; }
            else if (num == 3) { bonoVent3 = Personaje.BonoValor("SENTIDOS") + 2; }
            else if (num == 4) { bonoVent4 = Personaje.BonoValor("SENTIDOS") + 2; }
        }
        else if (memoria.Contains(accion))
        {
            if (num == 1) { bonoVent1 = Personaje.BonoValor("MEMORIA") + 2; }
            else if (num == 2) { bonoVent2 = Personaje.BonoValor("MEMORIA") + 2; }
            else if (num == 3) { bonoVent3 = Personaje.BonoValor("MEMORIA") + 2; }
            else if (num == 4) { bonoVent4 = Personaje.BonoValor("MEMORIA") + 2; }
        }
        else if (personalidad.Contains(accion))
        {
            if (num == 1) { bonoVent1 = Personaje.BonoValor("PERSONALIDAD") + 2; }
            else if (num == 2) { bonoVent2 = Personaje.BonoValor("PERSONALIDAD") + 2; }
            else if (num == 3) { bonoVent3 = Personaje.BonoValor("PERSONALIDAD") + 2; }
            else if (num == 4) { bonoVent4 = Personaje.BonoValor("PERSONALIDAD") + 2; }
        }
    }

    void ActivarAccionesVentaja()
    {
        accVent1.onClick.AddListener(AccionVent1);
        accVent2.onClick.AddListener(AccionVent2);
        accVent3.onClick.AddListener(AccionVent3);
        accVent4.onClick.AddListener(AccionVent4);
    }

    void ActivarAccionesFuerza()
    {
        saltar.onClick.AddListener(AccionSaltar);
        intimidar.onClick.AddListener(AccionIntimidar);
        fuerza.Add("SALTAR");
        fuerza.Add("INTIMIDAR");
    }

    void ActivarAccionesResist()
    {
        nadar.onClick.AddListener(AccionNadar);
        medicina.onClick.AddListener(AccionMedicina);
        resistencia.Add("NADAR");
        resistencia.Add("MEDICINA");
    }

    void ActivarAccionesAgilidad()
    {
        trepar.onClick.AddListener(AccionTrepar);
        robar.onClick.AddListener(AccionRobar);
        sigilar.onClick.AddListener(AccionSigilar);
        disfrazar.onClick.AddListener(AccionDisfrazar);
        bailar.onClick.AddListener(AccionBailar);
        agilidad.Add("TREPAR");
        agilidad.Add("ROBAR");
        agilidad.Add("SIGILAR");
        agilidad.Add("BAILAR");
    }

    void ActivarAccionesVelocidad()
    {
        correr.onClick.AddListener(AccionCorrer);
        velocidad.Add("CORRER");
    }

    void ActivarAccionesPoder()
    {
        magicologia.onClick.AddListener(AccionMagicologia);
        poder.Add("MAGICOLOGÍA");
    }

    void ActivarAccionesSentidos()
    {
        percibir.onClick.AddListener(AccionPercibir);
        escuchar.onClick.AddListener(AccionEscuchar);
        degustar.onClick.AddListener(AccionDegustar);
        oler.onClick.AddListener(AccionOler);
        sentidos.Add("PERCIBIR");
        sentidos.Add("ESCUCHAR");
        sentidos.Add("DEGUSTAR");
        sentidos.Add("OLER");
    }

    void ActivarAccionesMemoria()
    {
        recordar.onClick.AddListener(AccionRecordar);
        historia.onClick.AddListener(AccionHistoria);
        legislacion.onClick.AddListener(AccionLegislacion);
        zoologia.onClick.AddListener(AccionZoologia);
        botanica.onClick.AddListener(AccionBotanica);
        ciencia.onClick.AddListener(AccionCiencia);
        memoria.Add("RECORDAR");
        memoria.Add("HISTORIA");
        memoria.Add("LEGISLACIÓN");
        memoria.Add("ZOOLOGÍA");
        memoria.Add("BOTÁNICA");
        memoria.Add("CIENCIA");
    }

    void ActivarAccionesPersonalidad()
    {
        persuadir.onClick.AddListener(AccionPersuadir);
        negociar.onClick.AddListener(AccionNegociar);
        mentir.onClick.AddListener(AccionMentir);
        cantar.onClick.AddListener(AccionCantar);
        personalidad.Add("PERSUADIR");
        personalidad.Add("NEGOCIAR");
        personalidad.Add("MENTIR");
        personalidad.Add("CANTAR");
    }

    void AbrirMenuVent(string accVent)
    {
        if (accVent == "SALTAR") { AccionSaltar(); }
        else if (accVent == "INTIMIDAR") { AccionIntimidar(); }
        else if (accVent == "NADAR") { AccionNadar(); }
        else if (accVent == "MEDICINA") { AccionMedicina(); }
        else if (accVent == "TREPAR") { AccionTrepar(); }
        else if (accVent == "ROBAR") { AccionRobar(); }
        else if (accVent == "SIGILAR") { AccionSigilar(); }
        else if (accVent == "DISFRAZAR") { AccionDisfrazar(); }
        else if (accVent == "BAILAR") { AccionBailar(); }
        else if (accVent == "CORRER") { AccionCorrer(); }
        else if (accVent == "MAGICOLOGÍA") { AccionMagicologia(); }
        else if (accVent == "PERCIBIR") { AccionPercibir(); }
        else if (accVent == "ESCUCHAR") { AccionEscuchar(); }
        else if (accVent == "DEGUSTAR") { AccionDegustar(); }
        else if (accVent == "OLER") { AccionOler(); }
        else if (accVent == "RECORDAR") { AccionRecordar(); }
        else if (accVent == "HISTORIA") { AccionHistoria(); }
        else if (accVent == "LEGISLACIÓN") { AccionLegislacion(); }
        else if (accVent == "ZOOLOGÍA") { AccionZoologia(); }
        else if (accVent == "BOTÁNICA") { AccionBotanica(); }
        else if (accVent == "CIENCIA") { AccionCiencia(); }
        else if (accVent == "PERSUADIR") { AccionPersuadir(); }
        else if (accVent == "NEGOCIAR") { AccionNegociar(); }
        else if (accVent == "MENTIR") { AccionMentir(); }
        else if (accVent == "CANTAR") { AccionCantar(); }
    }

    void AccionVent1()
    {
        AbrirMenuVent(textaccVent1.text);
    }

    void AccionVent2()
    {
        AbrirMenuVent(textaccVent2.text);
    }

    void AccionVent3()
    {
        AbrirMenuVent(textaccVent3.text);
    }

    void AccionVent4()
    {
        AbrirMenuVent(textaccVent4.text);
    }

    void AccionSaltar()
    {
        string desc = "Vinculada al atributo FUERZA. Simboliza la acción de saltar vertical o longitudinal una cierta distancia para poder superar un obstáculo, alcanzar algo en lo alto o caer sin hacerse daño.";
        Ventajaono(desc, "SALTAR");
    }

    void AccionIntimidar()
    {
        string desc = "Vinculada al atributo FUERZA. Simboliza la acción de hacer que alguien sienta miedo o temor para extorsionar o asustar.";
        Ventajaono(desc, "INTIMIDAR");
    }

    void AccionNadar()
    {
        string desc = "Vinculada al atributo RESISTENCIA. Simboliza la acción de moverse dentro del agua, incluyendo también el buceo.";
        Ventajaono(desc, "NADAR");
    }

    void AccionMedicina()
    {
        string desc = "Vinculada al atributo RESISTENCIA. Simboliza la acción de usar los propios conocimientos sobre la medicina y antropología para poder reconocer dolencias, síntomas y lesiones o para curar a alguien.";
        Ventajaono(desc, "MEDICINA");
    }

    void AccionTrepar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de subir o bajar por una superficie vertical ya sea una pared, un acantilado, un árbol…";
        Ventajaono(desc, "TREPAR");
    }

    void AccionRobar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de quitar a una persona algo que le pertenece de forma que no se dé cuenta.";
        Ventajaono(desc, "ROBAR");
    }

    void AccionSigilar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de mantenerse oculto o moverse sin ser detectado.";
        Ventajaono(desc, "SIGILAR");
    }

    void AccionDisfrazar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de modificar de alguna forma la apariencia de algo o alguien usando ropa, máscaras y/o maquillaje con el fin de ocultar su verdadera identidad.";
        Ventajaono(desc, "DISFRAZAR");
    }

    void AccionBailar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de mover el cuerpo al ritmo de la música.";
        Ventajaono(desc, "BAILAR");
    }

    void AccionCorrer()
    {
        string desc = "Vinculada al atributo VELOCIDAD. Simboliza la acción de correr o esprintar una cierta distancia o durante cierto tiempo ya sea durante una persecución o una competición.";
        Ventajaono(desc, "CORRER");
    }

    void AccionMagicologia()
    {
        string desc = "Vinculada al atributo PODER. Simboliza la acción de usar los propios conocimientos de la magia para detectar rastros de su uso o reconocer magias entre otras acciones que se relacionen con la magia y su historia.";
        Ventajaono(desc, "MAGICOLOGÍA");
    }

    void AccionPercibir()
    {
        string desc = "Vinculada al atributo SENTIDOS. Simboliza la acción de mirar a algo, vigilar, inspeccionar con la mirada o buscar algo por el entorno. Todo lo que sea usar la visión para algo en específico entra dentro de esta acción.";
        Ventajaono(desc, "PERCIBIR");
    }

    void AccionEscuchar()
    {
        string desc = "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el oído para tratar de oír algo, ya sean sonidos sospechosos, conversaciones…";
        Ventajaono(desc, "ESCUCHAR");
    }

    void AccionDegustar()
    {
        string desc = "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el sentido del gusto para poder detectar posibles trazas de ciertos elementos en comidas, bebidas o para identificar objetos.";
        Ventajaono(desc, "DEGUSTAR");
    }

    void AccionOler()
    {
        string desc = "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el olfato para poder detectar rastros de olores y así poder identificar trazas de ciertos elementos en cualquier cosa.";
        Ventajaono(desc, "OLER");
    }

    void AccionRecordar()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de traer a la memoria propia algo percibido, aprendido o conocido, o retener algo en la mente.";
        Ventajaono(desc, "RECORDAR");
    }

    void AccionHistoria()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre la historia del mundo para recordar acontecimientos del pasado o verificar la autenticidad y valor de un objeto.";
        Ventajaono(desc, "HISTORIA");
    }

    void AccionLegislacion()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos de las leyes para poder defender derechos o aprovechar huecos legales.";
        Ventajaono(desc, "LEGISLACIÓN");
    }

    void AccionZoologia()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre zoología para identificar animales ya sea viéndolos directamente o por rastros dejados por estos como pisadas, excrementos, etcétera.";
        Ventajaono(desc, "ZOOLOGÍA");
    }

    void AccionBotanica()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre botánica para identificar todo tipo de plantas y vegetación según su follaje, tipo de tierra en la que crecen, frutos, tallo, clima en el que se encuentran, etcétera.";
        Ventajaono(desc, "BOTÁNICA");
    }

    void AccionCiencia()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre cualquier otra ciencia no especificada anteriormente como física, química, astronomía, biología… Para detectar o crear algún químico, aprovechar fenómenos de la física, guiarse por las estrellas, etcétera.";
        Ventajaono(desc, "CIENCIA");
    }

    void AccionPersuadir()
    {
        string desc = "Vinculada al atributo PERSONALIDAD. Simboliza la acción de conversar con alguien para conseguir con razones y argumentos que actúe o piense de un modo determinado. Tranquilizar, encandilar o seducir son consideradas como técnicas de persuasión.";
        Ventajaono(desc, "PERSUADIR");
    }

    void AccionNegociar()
    {
        string desc = "Vinculada al atributo PERSONALIDAD. Simboliza la acción de hablar de un asunto para llegar a un acuerdo o solución.";
        Ventajaono(desc, "NEGOCIAR");
    }

    void AccionMentir()
    {
        string desc = "Vinculada al atributo PERSONALIDAD. Simboliza la acción de decir deliberadamente lo contrario de lo que se sabe, se cree o se piensa que es verdad con el fin de engañar a alguien.";
        Ventajaono(desc, "MENTIR");
    }

    void AccionCantar()
    {
        string desc = "Vinculada al atributo PERSONALIDAD. Simboliza la acción de crear una melodía musical usando la voz o haciendo sonidos con la boca.";
        Ventajaono(desc, "CANTAR");
    }

    void Ventajaono(string desc, string action)
    {
        if (action == textaccVent1.text) { AbrirMenuAccion(action, desc, bonoVent1); }
        else if (action == textaccVent2.text) { AbrirMenuAccion(action, desc, bonoVent2); }
        else if (action == textaccVent3.text) { AbrirMenuAccion(action, desc, bonoVent3); }
        else if (action == textaccVent4.text) { AbrirMenuAccion(action, desc, bonoVent4); }
        else { AbrirMenuAccion(action, desc, bonoPersonalidad); }
    }

    void HacerTirada()
    {
        int min = 1;
        int max = 21;
        int numDadoTirada = Random.Range(min, max);
        int bonoActual;
        int.TryParse(bonoNum.text, out bonoActual);
        int result = bonoActual + numDadoTirada;
        if (numDadoTirada == 1)
        {
            resultado.text = "¡Pifia! Acción Fallida";
            DesgloseResultado.text = numDadoTirada + " (d20)";
        }
        else if (numDadoTirada == 20)
        {
            resultado.text = "¡Milagro! Acción Asegurada";
            DesgloseResultado.text = numDadoTirada + " (d20) " + bonoNum.text + " (Bono " + tituloAccion.text + ")";
        }
        else
        {
            resultado.text = "Resultado: " + result;
            DesgloseResultado.text = numDadoTirada + " (d20) " + bonoNum.text + " (Bono " + tituloAccion.text + ")";
        }
        Debug.Log(result);
        resultado.enabled = true;
        DesgloseResultado.enabled = true;
    }

    void CerrarMenu()
    {
        resultado.enabled = false;
        DesgloseResultado.enabled = false;
        menuAcciones.SetActive(false);
    }

    void AbrirMenuAccion(string nombreAccion, string descripcionAccion, int bono)
    {
        tituloAccion.text = nombreAccion;
        descAccion.text = descripcionAccion;
        if (bono >= 0) { bonoNum.text = "+" + bono; }
        else { bonoNum.text = bono.ToString(); }
        menuAcciones.SetActive(true);
    }
   
}
