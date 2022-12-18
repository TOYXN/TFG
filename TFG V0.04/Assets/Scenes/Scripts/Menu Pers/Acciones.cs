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
    public Button valor;

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
        if ("SALTAR" == textaccVent1.text) { AbrirMenuAccion("SALTAR", desc, bonoVent1); }
        else if ("SALTAR" == textaccVent2.text) { AbrirMenuAccion("SALTAR", desc, bonoVent2); }
        else if ("SALTAR" == textaccVent3.text) { AbrirMenuAccion("SALTAR", desc, bonoVent3); }
        else if ("SALTAR" == textaccVent4.text) { AbrirMenuAccion("SALTAR", desc, bonoVent4); }
        else { AbrirMenuAccion("SALTAR", desc, bonoFuerza); }
    }

    void AccionIntimidar()
    {
        string desc = "Vinculada al atributo FUERZA. Simboliza la acción de hacer que alguien sienta miedo o temor para extorsionar o asustar.";
        if ("INTIMIDAR" == textaccVent1.text) { AbrirMenuAccion("INTIMIDAR", desc, bonoVent1); }
        else if ("INTIMIDAR" == textaccVent2.text) { AbrirMenuAccion("INTIMIDAR", desc, bonoVent2); }
        else if ("INTIMIDAR" == textaccVent3.text) { AbrirMenuAccion("INTIMIDAR", desc, bonoVent3); }
        else if ("INTIMIDAR" == textaccVent4.text) { AbrirMenuAccion("INTIMIDAR", desc, bonoVent4); }
        else { AbrirMenuAccion("INTIMIDAR", desc, bonoFuerza); }
    }

    void AccionNadar()
    {
        string desc = "Vinculada al atributo RESISTENCIA. Simboliza la acción de moverse dentro del agua, incluyendo también el buceo.";
        if ("NADAR" == textaccVent1.text) { AbrirMenuAccion("NADAR", desc, bonoVent1); }
        else if ("NADAR" == textaccVent2.text) { AbrirMenuAccion("NADAR", desc, bonoVent2); }
        else if ("NADAR" == textaccVent3.text) { AbrirMenuAccion("NADAR", desc, bonoVent3); }
        else if ("NADAR" == textaccVent4.text) { AbrirMenuAccion("NADAR", desc, bonoVent4); }
        else { AbrirMenuAccion("NADAR", desc, bonoResistencia); }
    }

    void AccionMedicina()
    {
        string desc = "Vinculada al atributo RESISTENCIA. Simboliza la acción de usar los propios conocimientos sobre la medicina y antropología para poder reconocer dolencias, síntomas y lesiones o para curar a alguien.";
        if ("MEDICINA" == textaccVent1.text) { AbrirMenuAccion("MEDICINA", desc, bonoVent1); }
        else if ("MEDICINA" == textaccVent2.text) { AbrirMenuAccion("MEDICINA", desc, bonoVent2); }
        else if ("MEDICINA" == textaccVent3.text) { AbrirMenuAccion("MEDICINA", desc, bonoVent3); }
        else if ("MEDICINA" == textaccVent4.text) { AbrirMenuAccion("MEDICINA", desc, bonoVent4); }
        else { AbrirMenuAccion("MEDICINA", desc, bonoResistencia); }
    }

    void AccionTrepar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de subir o bajar por una superficie vertical ya sea una pared, un acantilado, un árbol…";
        if ("TREPAR" == textaccVent1.text) { AbrirMenuAccion("TREPAR", desc, bonoVent1); }
        else if ("TREPAR" == textaccVent2.text) { AbrirMenuAccion("TREPAR", desc, bonoVent2); }
        else if ("TREPAR" == textaccVent3.text) { AbrirMenuAccion("TREPAR", desc, bonoVent3); }
        else if ("TREPAR" == textaccVent4.text) { AbrirMenuAccion("TREPAR", desc, bonoVent4); }
        else { AbrirMenuAccion("TREPAR", desc, bonoAgilidad); }
    }

    void AccionRobar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de quitar a una persona algo que le pertenece de forma que no se dé cuenta.";
        if ("ROBAR" == textaccVent1.text) { AbrirMenuAccion("ROBAR", desc, bonoVent1); }
        else if ("ROBAR" == textaccVent2.text) { AbrirMenuAccion("ROBAR", desc, bonoVent2); }
        else if ("ROBAR" == textaccVent3.text) { AbrirMenuAccion("ROBAR", desc, bonoVent3); }
        else if ("ROBAR" == textaccVent4.text) { AbrirMenuAccion("ROBAR", desc, bonoVent4); }
        else { AbrirMenuAccion("ROBAR", desc, bonoAgilidad); }
    }

    void AccionSigilar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de mantenerse oculto o moverse sin ser detectado.";
        if ("SIGILAR" == textaccVent1.text) { AbrirMenuAccion("SIGILAR", desc, bonoVent1); }
        else if ("SIGILAR" == textaccVent2.text) { AbrirMenuAccion("SIGILAR", desc, bonoVent2); }
        else if ("SIGILAR" == textaccVent3.text) { AbrirMenuAccion("SIGILAR", desc, bonoVent3); }
        else if ("SIGILAR" == textaccVent4.text) { AbrirMenuAccion("SIGILAR", desc, bonoVent4); }
        else { AbrirMenuAccion("SIGILAR", desc, bonoAgilidad); }
    }

    void AccionDisfrazar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de modificar de alguna forma la apariencia de algo o alguien usando ropa, máscaras y/o maquillaje con el fin de ocultar su verdadera identidad.";
        if ("DISFRAZAR" == textaccVent1.text) { AbrirMenuAccion("DISFRAZAR", desc, bonoVent1); }
        else if ("DISFRAZAR" == textaccVent2.text) { AbrirMenuAccion("DISFRAZAR", desc, bonoVent2); }
        else if ("DISFRAZAR" == textaccVent3.text) { AbrirMenuAccion("DISFRAZAR", desc, bonoVent3); }
        else if ("DISFRAZAR" == textaccVent4.text) { AbrirMenuAccion("DISFRAZAR", desc, bonoVent4); }
        else { AbrirMenuAccion("DISFRAZAR", desc, bonoAgilidad); }
    }

    void AccionBailar()
    {
        string desc = "Vinculada al atributo AGILIDAD. Simboliza la acción de mover el cuerpo al ritmo de la música.";
        if ("BAILAR" == textaccVent1.text) { AbrirMenuAccion("BAILAR", desc, bonoVent1); }
        else if ("BAILAR" == textaccVent2.text) { AbrirMenuAccion("BAILAR", desc, bonoVent2); }
        else if ("BAILAR" == textaccVent3.text) { AbrirMenuAccion("BAILAR", desc, bonoVent3); }
        else if ("BAILAR" == textaccVent4.text) { AbrirMenuAccion("BAILAR", desc, bonoVent4); }
        else { AbrirMenuAccion("BAILAR", desc, bonoAgilidad); }
    }

    void AccionCorrer()
    {
        string desc = "Vinculada al atributo VELOCIDAD. Simboliza la acción de correr o esprintar una cierta distancia o durante cierto tiempo ya sea durante una persecución o una competición.";
        if ("CORRER" == textaccVent1.text) { AbrirMenuAccion("CORRER", desc, bonoVent1); }
        else if ("CORRER" == textaccVent2.text) { AbrirMenuAccion("CORRER", desc, bonoVent2); }
        else if ("CORRER" == textaccVent3.text) { AbrirMenuAccion("CORRER", desc, bonoVent3); }
        else if ("CORRER" == textaccVent4.text) { AbrirMenuAccion("CORRER", desc, bonoVent4); }
        else { AbrirMenuAccion("CORRER", desc, bonoVelocidad); }
    }

    void AccionMagicologia()
    {
        string desc = "Vinculada al atributo PODER. Simboliza la acción de usar los propios conocimientos de la magia para detectar rastros de su uso o reconocer magias entre otras acciones que se relacionen con la magia y su historia.";
        if ("MAGICOLOGÍA" == textaccVent1.text) { AbrirMenuAccion("MAGICOLOGÍA", desc, bonoVent1); }
        else if ("MAGICOLOGÍA" == textaccVent2.text) { AbrirMenuAccion("MAGICOLOGÍA", desc, bonoVent2); }
        else if ("MAGICOLOGÍA" == textaccVent3.text) { AbrirMenuAccion("MAGICOLOGÍA", desc, bonoVent3); }
        else if ("MAGICOLOGÍA" == textaccVent4.text) { AbrirMenuAccion("MAGICOLOGÍA", desc, bonoVent4); }
        else { AbrirMenuAccion("MAGICOLOGÍA", desc, bonoPoder); }
    }

    void AccionPercibir()
    {
        string desc = "Vinculada al atributo SENTIDOS. Simboliza la acción de mirar a algo, vigilar, inspeccionar con la mirada o buscar algo por el entorno. Todo lo que sea usar la visión para algo en específico entra dentro de esta acción.";
        if ("PERCIBIR" == textaccVent1.text) { AbrirMenuAccion("PERCIBIR", desc, bonoVent1); }
        else if ("PERCIBIR" == textaccVent2.text) { AbrirMenuAccion("PERCIBIR", desc, bonoVent2); }
        else if ("PERCIBIR" == textaccVent3.text) { AbrirMenuAccion("PERCIBIR", desc, bonoVent3); }
        else if ("PERCIBIR" == textaccVent4.text) { AbrirMenuAccion("PERCIBIR", desc, bonoVent4); }
        else { AbrirMenuAccion("PERCIBIR", desc, bonoSentidos); }
    }

    void AccionEscuchar()
    {
        string desc = "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el oído para tratar de oír algo, ya sean sonidos sospechosos, conversaciones…";
        if ("ESCUCHAR" == textaccVent1.text) { AbrirMenuAccion("ESCUCHAR", desc, bonoVent1); }
        else if ("ESCUCHAR" == textaccVent2.text) { AbrirMenuAccion("ESCUCHAR", desc, bonoVent2); }
        else if ("ESCUCHAR" == textaccVent3.text) { AbrirMenuAccion("ESCUCHAR", desc, bonoVent3); }
        else if ("ESCUCHAR" == textaccVent4.text) { AbrirMenuAccion("ESCUCHAR", desc, bonoVent4); }
        else { AbrirMenuAccion("ESCUCHAR", desc, bonoSentidos); }
    }

    void AccionDegustar()
    {
        string desc = "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el sentido del gusto para poder detectar posibles trazas de ciertos elementos en comidas, bebidas o para identificar objetos.";
        if ("DEGUSTAR" == textaccVent1.text) { AbrirMenuAccion("DEGUSTAR", desc, bonoVent1); }
        else if ("DEGUSTAR" == textaccVent2.text) { AbrirMenuAccion("DEGUSTAR", desc, bonoVent2); }
        else if ("DEGUSTAR" == textaccVent3.text) { AbrirMenuAccion("DEGUSTAR", desc, bonoVent3); }
        else if ("DEGUSTAR" == textaccVent4.text) { AbrirMenuAccion("DEGUSTAR", desc, bonoVent4); }
        else { AbrirMenuAccion("DEGUSTAR", desc, bonoSentidos); }
    }

    void AccionOler()
    {
        string desc = "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el olfato para poder detectar rastros de olores y así poder identificar trazas de ciertos elementos en cualquier cosa.";
        if ("OLER" == textaccVent1.text) { AbrirMenuAccion("OLER", desc, bonoVent1); }
        else if ("OLER" == textaccVent2.text) { AbrirMenuAccion("OLER", desc, bonoVent2); }
        else if ("OLER" == textaccVent3.text) { AbrirMenuAccion("OLER", desc, bonoVent3); }
        else if ("OLER" == textaccVent4.text) { AbrirMenuAccion("OLER", desc, bonoVent4); }
        else { AbrirMenuAccion("OLER", desc, bonoSentidos); }
    }

    void AccionRecordar()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de traer a la memoria propia algo percibido, aprendido o conocido, o retener algo en la mente.";
        if ("RECORDAR" == textaccVent1.text) { AbrirMenuAccion("RECORDAR", desc, bonoVent1); }
        else if ("RECORDAR" == textaccVent2.text) { AbrirMenuAccion("RECORDAR", desc, bonoVent2); }
        else if ("RECORDAR" == textaccVent3.text) { AbrirMenuAccion("RECORDAR", desc, bonoVent3); }
        else if ("RECORDAR" == textaccVent4.text) { AbrirMenuAccion("RECORDAR", desc, bonoVent4); }
        else { AbrirMenuAccion("RECORDAR", desc, bonoMemoria); }
    }

    void AccionHistoria()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre la historia del mundo para recordar acontecimientos del pasado o verificar la autenticidad y valor de un objeto.";
        if ("HISTORIA" == textaccVent1.text) { AbrirMenuAccion("HISTORIA", desc, bonoVent1); }
        else if ("HISTORIA" == textaccVent2.text) { AbrirMenuAccion("HISTORIA", desc, bonoVent2); }
        else if ("HISTORIA" == textaccVent3.text) { AbrirMenuAccion("HISTORIA", desc, bonoVent3); }
        else if ("HISTORIA" == textaccVent4.text) { AbrirMenuAccion("HISTORIA", desc, bonoVent4); }
        else { AbrirMenuAccion("HISTORIA", desc, bonoMemoria); }
    }

    void AccionLegislacion()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos de las leyes para poder defender derechos o aprovechar huecos legales.";
        if ("LEGISLACIÓN" == textaccVent1.text) { AbrirMenuAccion("LEGISLACIÓN", desc, bonoVent1); }
        else if ("LEGISLACIÓN" == textaccVent2.text) { AbrirMenuAccion("LEGISLACIÓN", desc, bonoVent2); }
        else if ("LEGISLACIÓN" == textaccVent3.text) { AbrirMenuAccion("LEGISLACIÓN", desc, bonoVent3); }
        else if ("LEGISLACIÓN" == textaccVent4.text) { AbrirMenuAccion("LEGISLACIÓN", desc, bonoVent4); }
        else { AbrirMenuAccion("LEGISLACIÓN", desc, bonoMemoria); }
    }

    void AccionZoologia()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre zoología para identificar animales ya sea viéndolos directamente o por rastros dejados por estos como pisadas, excrementos, etcétera.";
        if ("ZOOLOGÍA" == textaccVent1.text) { AbrirMenuAccion("ZOOLOGÍA", desc, bonoVent1); }
        else if ("ZOOLOGÍA" == textaccVent2.text) { AbrirMenuAccion("ZOOLOGÍA", desc, bonoVent2); }
        else if ("ZOOLOGÍA" == textaccVent3.text) { AbrirMenuAccion("ZOOLOGÍA", desc, bonoVent3); }
        else if ("ZOOLOGÍA" == textaccVent4.text) { AbrirMenuAccion("ZOOLOGÍA", desc, bonoVent4); }
        else { AbrirMenuAccion("ZOOLOGÍA", desc, bonoMemoria); }
    }

    void AccionBotanica()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre botánica para identificar todo tipo de plantas y vegetación según su follaje, tipo de tierra en la que crecen, frutos, tallo, clima en el que se encuentran, etcétera.";
        if ("BOTÁNICA" == textaccVent1.text) { AbrirMenuAccion("BOTÁNICA", desc, bonoVent1); }
        else if ("BOTÁNICA" == textaccVent2.text) { AbrirMenuAccion("BOTÁNICA", desc, bonoVent2); }
        else if ("BOTÁNICA" == textaccVent3.text) { AbrirMenuAccion("BOTÁNICA", desc, bonoVent3); }
        else if ("BOTÁNICA" == textaccVent4.text) { AbrirMenuAccion("BOTÁNICA", desc, bonoVent4); }
        else { AbrirMenuAccion("BOTÁNICA", desc, bonoMemoria); }
    }

    void AccionCiencia()
    {
        string desc = "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre cualquier otra ciencia no especificada anteriormente como física, química, astronomía, biología… Para detectar o crear algún químico, aprovechar fenómenos de la física, guiarse por las estrellas, etcétera.";
        if ("CIENCIA" == textaccVent1.text) { AbrirMenuAccion("CIENCIA", desc, bonoVent1); }
        else if ("CIENCIA" == textaccVent2.text) { AbrirMenuAccion("CIENCIA", desc, bonoVent2); }
        else if ("CIENCIA" == textaccVent3.text) { AbrirMenuAccion("CIENCIA", desc, bonoVent3); }
        else if ("CIENCIA" == textaccVent4.text) { AbrirMenuAccion("CIENCIA", desc, bonoVent4); }
        else { AbrirMenuAccion("CIENCIA", desc, bonoMemoria); }
    }

    void AccionPersuadir()
    {
        string desc = "Vinculada al atributo PERSONALIDAD. Simboliza la acción de conversar con alguien para conseguir con razones y argumentos que actúe o piense de un modo determinado. Tranquilizar, encandilar o seducir son consideradas como técnicas de persuasión.";
        if ("PERSUADIR" == textaccVent1.text) { AbrirMenuAccion("PERSUADIR", desc, bonoVent1); }
        else if ("PERSUADIR" == textaccVent2.text) { AbrirMenuAccion("PERSUADIR", desc, bonoVent2); }
        else if ("PERSUADIR" == textaccVent3.text) { AbrirMenuAccion("PERSUADIR", desc, bonoVent3); }
        else if ("PERSUADIR" == textaccVent4.text) { AbrirMenuAccion("PERSUADIR", desc, bonoVent4); }
        else { AbrirMenuAccion("PERSUADIR", desc, bonoPersonalidad); }
    }

    void AccionNegociar()
    {
        string desc = "Vinculada al atributo PERSONALIDAD. Simboliza la acción de hablar de un asunto para llegar a un acuerdo o solución.";
        if ("NEGOCIAR" == textaccVent1.text) { AbrirMenuAccion("NEGOCIAR", desc, bonoVent1); }
        else if ("NEGOCIAR" == textaccVent2.text) { AbrirMenuAccion("NEGOCIAR", desc, bonoVent2); }
        else if ("NEGOCIAR" == textaccVent3.text) { AbrirMenuAccion("NEGOCIAR", desc, bonoVent3); }
        else if ("NEGOCIAR" == textaccVent4.text) { AbrirMenuAccion("NEGOCIAR", desc, bonoVent4); }
        else { AbrirMenuAccion("NEGOCIAR", desc, bonoPersonalidad); }
    }

    void AccionMentir()
    {
        string desc = "Vinculada al atributo PERSONALIDAD. Simboliza la acción de decir deliberadamente lo contrario de lo que se sabe, se cree o se piensa que es verdad con el fin de engañar a alguien.";
        if ("MENTIR" == textaccVent1.text) { AbrirMenuAccion("MENTIR", desc, bonoVent1); }
        else if ("MENTIR" == textaccVent2.text) { AbrirMenuAccion("MENTIR", desc, bonoVent2); }
        else if ("MENTIR" == textaccVent3.text) { AbrirMenuAccion("MENTIR", desc, bonoVent3); }
        else if ("MENTIR" == textaccVent4.text) { AbrirMenuAccion("MENTIR", desc, bonoVent4); }
        else { AbrirMenuAccion("MENTIR", desc, bonoPersonalidad); }
    }

    void AccionCantar()
    {
        string desc = "Vinculada al atributo PERSONALIDAD. Simboliza la acción de crear una melodía musical usando la voz o haciendo sonidos con la boca.";
        if ("CANTAR" == textaccVent1.text) { AbrirMenuAccion("CANTAR", desc, bonoVent1); }
        else if ("CANTAR" == textaccVent2.text) { AbrirMenuAccion("CANTAR", desc, bonoVent2); }
        else if ("CANTAR" == textaccVent3.text) { AbrirMenuAccion("CANTAR", desc, bonoVent3); }
        else if ("CANTAR" == textaccVent4.text) { AbrirMenuAccion("CANTAR", desc, bonoVent4); }
        else { AbrirMenuAccion("CANTAR", desc, bonoPersonalidad); }
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
