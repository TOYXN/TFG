using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso4_4 : MonoBehaviour
{
    public GameObject MenuSeleccion;
    public Button Aniquilador;
    public Button Protector;
    public Button Cazador;
    public Button Sombra;
    public Button Animatec;
    public Button Centinela;
    public Button Sabio;
    public Button Embaucador;

    public GameObject MenuClaseSelec;
    public Text NombreClase;
    public Text ValorClase;
    public Text MagiasClase;
    public Text ArmasClase;
    public Button BotonDescClase;
    public GameObject MenuDescClase;
    public Text DescClase;
    public Button CerrarDescClase;
    public Button BotonSeleccionarClase;
    public Button CerrarMenuClase;

    public Text TextoFinal;
    public GameObject TextoFinalGO;

    public GameObject ContinuarGO;
    public Personaje Personaje;
    // Start is called before the first frame update
    void Start()
    {
        IniciarBotonesClases();
        IniciarBotonesMenu();
    }

    void IniciarBotonesClases()
    {
        Aniquilador.onClick.AddListener(AbrirAniq);
        Protector.onClick.AddListener(AbrirProt);
        Cazador.onClick.AddListener(AbrirCaza);
        Sombra.onClick.AddListener(AbrirSomb);
        Animatec.onClick.AddListener(AbrirAnim);
        Centinela.onClick.AddListener(AbrirCent);
        Sabio.onClick.AddListener(AbrirSabio);
        Embaucador.onClick.AddListener(AbrirEmba);
    }

    void IniciarBotonesMenu()
    {
        BotonDescClase.onClick.AddListener(AbrirDesc);
        CerrarDescClase.onClick.AddListener(CerrarDesc);
        BotonSeleccionarClase.onClick.AddListener(SelecClase);
        CerrarMenuClase.onClick.AddListener(CerrarClase);
    }

    void AbrirAniq()
    {
        NombreClase.text = "Aniquilador";
        ValorClase.text = "Valor Vinculado: +2 a la Fuerza";
        MagiasClase.text = "Magias disponibles: Bala, Carga, Atq. Expansivo, Obliteración, Enfurecer, Aterrar, Grito de Guerra, Aligerar.";
        ArmasClase.text = "Armas disponibles: Cuerpo, Espada recta, Espadón, Alabarda, Hacha, Gran Hacha.";
        DescClase.text = "Viven por y para el combate cuerpo a cuerpo. Su extraordinaria fuerza y agresividad les permite destrozar a sus oponentes en devastadores ataques que diezman sus defensas. No hay protección posible ante un aniquilador.";
        MenuClaseSelec.SetActive(true);
    }

    void AbrirProt()
    {
        NombreClase.text = "Protector";
        ValorClase.text = "Valor Vinculado: +2 a la Resistencia";
        MagiasClase.text = "Magias disponibles: Barrera, Cura, Furia, Grito de Guerra, Aterrar, Inamovible, Atraer, Repeler.";
        ArmasClase.text = "Armas disponibles: Espada recta, Espada curva, Espadón, Hacha, Lanza, Bastón.";
        DescClase.text = "Gracias a su vitalidad y resistencia física los convierte en los personajes idóneos para hacer las funciones de muro en combate, absorbiendo todos los golpes de los enemigos mientras que sus compañeros terminan con ellos. Los hay que prefieren usar sus conocimientos de medicina, sus cuerpos entrenados y sus habilidades de manipular su propia alma para aplicar hechizos curativos en combate.";
        MenuClaseSelec.SetActive(true);
    }

    void AbrirCaza()
    {
        NombreClase.text = "Cazador";
        ValorClase.text = "Valor Vinculado: +2 a la Agilidad";
        MagiasClase.text = "Magias disponibles: Bala, Carga, Terataque, Acercamiento, Aligerar, Enfurecer, Entorpecer, Mimetizar.";
        ArmasClase.text = "Armas disponibles: Espada curva, Estoque, Lanza, Arco, Daga, Bastón.";
        DescClase.text = "Cuando tienen un objetivo, este solo está condenado a ser capturado, ya sea un objeto, un ser vivo o un elemento metafórico. Hacen uso de su increíble agilidad y destreza con las manos para atacar y moverse entre las filas enemigas grácilmente. Todos sus movimientos son óptimos, y eso los hacen perfectos para el subterfugio y el sigilo.";
        MenuClaseSelec.SetActive(true);
    }

    void AbrirSomb()
    {
        NombreClase.text = "Sombra";
        ValorClase.text = "Valor Vinculado: +2 a la Velocidad";
        MagiasClase.text = "Magias disponibles: Bala, Aligerar, Entorpecer, Enfurecer, Acercamiento, Separación, Terataque, Combo.";
        ArmasClase.text = "Armas disponibles: Cuerpo, Estoque, Espada curva, Hacha, Bastón, Daga.";
        DescClase.text = "Usan su extremadamente alta velocidad para arremeter contra el enemigo en un parpadeo sin posibilidad de respuesta o para someterlos con un torrente de ataques. Su rapidez deja a sus enemigos sin escapatoria.";
        MenuClaseSelec.SetActive(true);
    }

    void AbrirAnim()
    {
        NombreClase.text = "Animatec";
        ValorClase.text = "Valor Vinculado: +2 al Poder";
        MagiasClase.text = "Magias disponibles: Bala, Pulso, Láser, Artema, Cura, Barrera, Imbuír, Desalmar.";
        ArmasClase.text = "Armas disponibles: Cuerpo, Espada recta, Estoque, Gran Hacha, Bastón, Daga.";
        DescClase.text = "Conocedores absolutos sobre la manipulación almática, ya sea por genética o riguroso estudio, han perfeccionado su uso a tal punto que pueden usar la forma más pura y eficiente de su alma para proyectar hechizos. Solo así se consigue proyectar los hechizos más poderosos conocidos actualmente.";
        MenuClaseSelec.SetActive(true);
    }

    void AbrirCent()
    {
        NombreClase.text = "Centinela";
        ValorClase.text = "Valor Vinculado: +2 a los Sentidos";
        MagiasClase.text = "Magias disponibles: Bala, Barrera, Separación, Atq. Expansivo, Aclarar, Ofuscar, Entorpecer, Más Allá.";
        ArmasClase.text = "Armas disponibles: Espada recta, Espadón, Espada curva, Alabarda, Lanza, Arco.";
        DescClase.text = "Aclamados por sus capacidades a la hora de encontrar cualquier cosa gracias a sus agudizados sentidos, suelen dedicarse a ser los vigías de cualquier grupo. Suelen adelantarse a los acontecimientos porque se han percatado mucho antes gracias a esos increíbles sentidos.";
        MenuClaseSelec.SetActive(true);
    }

    void AbrirSabio()
    {
        NombreClase.text = "Sabio";
        ValorClase.text = "Valor Vinculado: +2 a la Memoria";
        MagiasClase.text = "Magias disponibles: Bala, Láser, Fortalecer, Debilitar, Apoderar, Comprometer, Cura, Desalmar.";
        ArmasClase.text = "Armas disponibles: Cuerpo, Espada recta, Lanza, Alabarda, Hacha, Gran hacha.";
        DescClase.text = "Años de estudios les han convertido en enciclopedias andantes de conocimientos. Puede que conozcan muchas cosas sobre una gran variedad de sujetos o que hayan dedicado sus vidas a desentrañar los misterios sobre algo en específico. No hay rama del conocimiento que les detenga para recopilar información e investigar sobre ellas.";
        MenuClaseSelec.SetActive(true);
    }

    void AbrirEmba()
    {
        NombreClase.text = "Embaucador";
        ValorClase.text = "Valor Vinculado: +2 a la Personalidad";
        MagiasClase.text = "Habilidades disponibles: Enfurecer, Aterrar, Aligerar, Entorpecer, Aclarar, Ofuscar, Clarividencia, Humillar.";
        ArmasClase.text = "Armas disponibles: Cuerpo, Estoque, Arco, Daga, Espadón, Gran hacha.";
        DescClase.text = "Temidos por su carisma y labia. Su capacidad de encandilar cualquier conversación hacen que sean capaces de conseguir lo que quieran con solo hablar. Los hay que han empezado y terminado guerras solo con un discurso suyo.";
        MenuClaseSelec.SetActive(true);
    }

    void AbrirDesc()
    {
        MenuDescClase.SetActive(true);
    }
    void CerrarDesc()
    {
        MenuDescClase.SetActive(false);
    }
    void CerrarClase()
    {
        MenuClaseSelec.SetActive(false);
    }

    void SelecClase()
    {
        Personaje._clase.nombreClase = NombreClase.text;
        if(NombreClase.text == "Aniquilador")
        {
            AsignarClase("Aniquilador", "FUERZA");
            EmpezarHechizAniquilador();
            EmpezarArmasAniquilador();
        }
        else if(NombreClase.text == "Protector")
        {
            AsignarClase("Protector", "RESISTENCIA");
            EmpezarHechizProtector();
            EmpezarArmasProtector();
        }
        else if (NombreClase.text == "Cazador")
        {
            AsignarClase("Cazador", "AGILIDAD");
            EmpezarHechizCazador();
            EmpezarArmasCazador();
        }
        else if (NombreClase.text == "Sombra")
        {
            AsignarClase("Sombra", "VELOCIDAD");
            EmpezarHechizSombra();
            EmpezarArmasSombra();
        }
        else if (NombreClase.text == "Animatec")
        {
            AsignarClase("Animatec", "PODER");
            EmpezarHechizAnimatec();
            EmpezarArmasAnimatec();
        }
        else if (NombreClase.text == "Centinela")
        {
            AsignarClase("Centinela", "SENTIDOS");
            EmpezarHechizCentinela();
            EmpezarArmasCentinela();
        }
        else if (NombreClase.text == "Sabio")
        {
            AsignarClase("Sabio", "MEMORIA");
            EmpezarHechizSabio();
            EmpezarArmasSabio();
        }
        else if (NombreClase.text == "Embaucador")
        {
            AsignarClase("Embaucador", "PERSONALIDAD");
            EmpezarHechizEmbaucador();
            EmpezarArmasEmbaucador();
        }
        MenuClaseSelec.SetActive(false);
        MenuSeleccion.SetActive(false);
        TextoFinalGO.SetActive(true);
        ContinuarGO.SetActive(true);
    }

    void AsignarClase(string nomClase, string valorClase)
    {
        Personaje._clase.valorClase = valorClase;
        Personaje.ActualizarValor(valorClase, 2);
        Personaje._clase.descClase = DescClase.text;
        TextoFinal.text = "Clase seleccionada: \n\n" + nomClase;
    }

    Arma CrearCuerpo()
    {
        return new Arma("Cuerpo", "El uso de puñetazos, codazos y patadas para atacar.", 6, "FUERZA");
    }
    Arma CrearEspRecta()
    {
        return new Arma("Espada recta", "Arma de doble filo equilibrada y versátil, útil para cortar o atravesar.", 8, "FUERZA");
    }
    Arma CrearEspCurva()
    {
        return new Arma("Espada curva", "Arma de un solo y afilado filo curvo para asestar precisos y profundos cortes.", 8, "AGILIDAD");
    }
    Arma CrearEstoque()
    {
        return new Arma("Estoque", "Arma larga y ligera de hoja dura y puntiaguda hecha para perforar pero capaz también de cortar.", 8, "AGILIDAD");
    }
    Arma CrearEspadon()
    {
        return new Arma("Espadón", "Gran espada pesada hecha para obliterar con fuerza bruta a los enemigos.", 12, "FUERZA");
    }
    Arma CrearHacha()
    {
        return new Arma("Hacha", "Arma versátil con una hoja gruesa y pesada unida a un mango capaz de realizar poderosos ataques gracias a su pesada hoja.", 8, "FUERZA");
    }
    Arma CrearGHacha()
    {
        return new Arma("Gran hacha", "Similar a una hacha pero más pesada y con un mango más largo para ataques de barrido devastadores.", 12, "FUERZA");
    }
    Arma CrearLanza()
    {
        return new Arma("Lanza", "Un arma perforante de largo alcance compuesta por una hoja unida a un mango largo.", 8, "AGILIDAD");
    }
    Arma CrearAlabarda()
    {
        return new Arma("Alabarda", "Arma de asta de mango largo que combina las funciones de hacha y lanza.", 8, "FUERZA");
    }
    Arma CrearBaston()
    {
        return new Arma("Bastón", "Arma sencilla de ataques contundentes muy versátil que consiste en un palo largo.", 6, "AGILIDAD");
    }
    Arma CrearArco()
    {
        return new Arma("Arco", "Arma para atacar a distancia disparando flechas.", 6, "AGILIDAD");
    }
    Arma CrearDaga()
    {
        return new Arma("Daga", "Arma ligera de corto alcance para cortes y puñaladas. Puede ser lanzada como ataque.", 6, "AGILIDAD");
    }

    Hechizo CrearBala()
    {
        return new Hechizo("Bala", "Concentra una pequeña parte de su alma en un punto y la dispara a alta velocidad para infringir daño a un enemigo.",
                            6, 6, "Magia");
    }
    Hechizo CrearPulso()
    {
        return new Hechizo("Pulso", "Lanza una parte de su alma a un enemigo para infringir daño.",
                            10, 10, "Magia");
    }
    Hechizo CrearLaser()
    {
        return new Hechizo("Láser", "Crea un haz con su alma dirigido a todos los enemigos y hace un barrido para infringir daño.",
                            10, 6, "Magia");
    }
    Hechizo CrearArtema()
    {
        return new Hechizo("Artema", "Utiliza una enorme cantidad de alma para provocar una explosión devastadora concentrada desde dentro de todos los enemigos para causar destructivos daños.",
                            50, 20, "Magia");
    }
    Hechizo CrearCura()
    {
        return new Hechizo("Cura", "Proyecta parte de su alma para sanar al objetivo.",
                            10, 10, "Magia");
    }
    Hechizo CrearBarrera()
    {
        return new Hechizo("Barrera", "Proyecta parte de su alma a un objetivo para crear una barrera que bloquea una cierta cantidad de daño enemigo.",
                            10, 10, "Magia");
    }
    Hechizo CrearImbuir()
    {
        return new Hechizo("Imbuir", "Incorpora parte de su alma en su arma para añadir daño a sus ataques. La imbuición dura el resto del combate y no se puede acumular, pero sí sustituir.",
                            10, 4, "Magia");
    }
    Hechizo CrearDesalmar()
    {
        return new Hechizo("Desalmar", "Canaliza parte de su alma para absorber parte del alma de un enemigo. Recupera los PA dañados al enemigo.",
                            16, 10, "Magia");
    }
    Hechizo CrearCarga()
    {
        return new Hechizo("Carga", "Concentra su alma para que su siguiente ataque con el arma haga daño adicional.",
                            6, 6, "Carga");
    }
    Hechizo CrearExpansivo()
    {
        return new Hechizo("Atq. Expansivo", "Concentra su alma y ataca con el arma provocando una onda expansiva que daña al resto de enemigos.",
                            6, 4, "Magia");
    }
    Hechizo CrearObliteracion()
    {
        return new Hechizo("Obliteración", "Dedica cuerpo y alma con el fin de destruir a un enemigo con un ataque demoledor. Ataca usando 4 dados más.",
                            32, 0, "Oblit");
    }
    Hechizo CrearAtraer()
    {
        return new Hechizo("Atraer", "Manipula su alma y la de un enemigo de tal forma que este se ve obligado a enfrentarse a él.",
                            12, 0, "Pasivo");
    }
    Hechizo CrearRepeler()
    {
        return new Hechizo("Repeler", "Proyecta una cantidad generosa de su alma para atacar a un enemigo y alejarlo del rango de ataque.",
                            12, 8, "Magia");
    }
    Hechizo CrearBiataque()
    {
        return new Hechizo("Biataque", "Se concentra en cuerpo y alma para atacar 2 veces consecutivas muy rápido a un enemigo.",
                            16, 0, "Bi");
    }
    Hechizo CrearAcercamiento()
    {
        return new Hechizo("Acercamiento", "Permite al usuario atacar a la vez que se enfrenta a un enemigo.",
                            8, 0, "Ataque");
    }
    Hechizo CrearSeparacion()
    {
        return new Hechizo("Separación", "Permite al usuario atacar a la vez que se enfrenta a un enemigo.",
                            8, 0, "Ataque");
    }
    Hechizo CrearMimetizar()
    {
        return new Hechizo("Mimetizar", "Manipula su alma de tal forma que se vuelve imperceptible a la vista. Los enemigos no podrán atacarte hasta que se pierde el efecto. Este efecto se pierde atacándolos, que un enemigo consiga superar una tirada Sobrehumana de Percibir o haciendo una acción que pueda alertarlos de tu presencia. El próximo ataque siempre hará daño doble.",
                            20, 0, "Mimet");
    }
    Hechizo CrearCombo()
    {
        return new Hechizo("Combo", "Utilizando una gran cantidad de su alma, provoca que su cuerpo se mueva a gran velocidad para atacar entre Nº de Dados y 8 veces con daño adicional. Cada ataque se puede repartir entre todos los enemigos a elección del jugador.",
                            28, 6, "Combo");
    }
    Hechizo CrearEnfurecer()
    {
        return new Hechizo("Enfurecer", "Mejora la Fuerza y Resistencia de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            14, 0, "Pasivo");
    }
    Hechizo CrearAligerar()
    {
        return new Hechizo("Aligerar", "Mejora la Agilidad y Velocidad de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            14, 0, "Pasivo");
    }
    Hechizo CrearAclarar()
    {
        return new Hechizo("Aclarar", "Mejora el Poder y Sentidos de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            14, 0, "Pasivo");
    }
    Hechizo CrearClarividencia()
    {
        return new Hechizo("Clarividencia", "Mejora la Memoria y Personalidad de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            14, 0, "Pasivo");
    }
    Hechizo CrearAterrar()
    {
        return new Hechizo("Aterrar", "Reduce la Fuerza y Resistencia de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            14, 0, "Pasivo");
    }
    Hechizo CrearEntorpecer()
    {
        return new Hechizo("Entorpecer", "Reduce la Agilidad y Velocidad de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            14, 0, "Pasivo");
    }
    Hechizo CrearOfuscar()
    {
        return new Hechizo("Ofuscar", "Reduce el Poder y Sentidos de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            14, 0, "Pasivo");
    }
    Hechizo CrearHumillar()
    {
        return new Hechizo("Humillar", "Mejora la Memoria y Personalidad de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            14, 0, "Pasivo");
    }
    Hechizo CrearGrito()
    {
        return new Hechizo("Grito de Guerra", "Mejora el Bono de Fuerza y el Bono de Resistencia de todo un grupo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            30, 0, "Pasivo");
    }
    Hechizo CrearInamovible()
    {
        return new Hechizo("Inamovible", "Mejora la Resistencia de sí mismo por 4 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            22, 0, "Pasivo");
    }
    Hechizo CrearMasAlla()
    {
        return new Hechizo("Más Allá", "Mejora los Sentidos de sí mismo por 6 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            30, 0, "Pasivo");
    }
    Hechizo CrearFortalecer()
    {
        return new Hechizo("Fortalecer", "Mejora la Fuerza, Resistencia, Agilidad y Velocidad de todo un grupo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            38, 0, "Pasivo");
    }
    Hechizo CrearDebilitar()
    {
        return new Hechizo("Debilitar", "Reduce la Fuerza, Resistencia, Agilidad y Velocidad de todo un grupo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            38, 0, "Pasivo");
    }
    Hechizo CrearApoderar()
    {
        return new Hechizo("Apoderar", "Mejora el Poder, Sentidos, Memoria y Personalidad de todo un grupo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            38, 0, "Pasivo");
    }
    Hechizo CrearComprometer()
    {
        return new Hechizo("Comprometer", "Reduce el Poder, Sentidos, Memoria y Personalidad de todo un grupo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.",
                            38, 0, "Pasivo");
    }

    void EmpezarArmasAniquilador()
    {
        Arma arma1 = CrearCuerpo();
        Arma arma2 = CrearEspRecta();
        Arma arma3 = CrearEspadon();
        Arma arma4 = CrearAlabarda();
        Arma arma5 = CrearHacha();
        Arma arma6 = CrearGHacha();
        Personaje._clase.listaArmasClase = new Arma[] { arma1, arma2, arma3, arma4, arma5, arma6 };
    }
    void EmpezarArmasProtector()
    {
        Arma arma1 = CrearEspRecta();
        Arma arma2 = CrearEspCurva();
        Arma arma3 = CrearEspadon();
        Arma arma4 = CrearHacha();
        Arma arma5 = CrearLanza();
        Arma arma6 = CrearBaston();
        Personaje._clase.listaArmasClase = new Arma[] { arma1, arma2, arma3, arma4, arma5, arma6 };
    }
    void EmpezarArmasCazador()
    {
        Arma arma1 = CrearEspCurva();
        Arma arma2 = CrearEstoque();
        Arma arma3 = CrearLanza();
        Arma arma4 = CrearArco();
        Arma arma5 = CrearDaga();
        Arma arma6 = CrearBaston();
        Personaje._clase.listaArmasClase = new Arma[] { arma1, arma2, arma3, arma4, arma5, arma6 };
    }
    void EmpezarArmasSombra()
    {
        Arma arma1 = CrearCuerpo();
        Arma arma2 = CrearEstoque();
        Arma arma3 = CrearEspCurva();
        Arma arma4 = CrearHacha();
        Arma arma5 = CrearBaston();
        Arma arma6 = CrearDaga();
        Personaje._clase.listaArmasClase = new Arma[] { arma1, arma2, arma3, arma4, arma5, arma6 };
    }
    void EmpezarArmasAnimatec()
    {
        Arma arma1 = CrearCuerpo();
        Arma arma2 = CrearEspRecta();
        Arma arma3 = CrearEstoque();
        Arma arma4 = CrearGHacha();
        Arma arma5 = CrearBaston();
        Arma arma6 = CrearDaga();
        Personaje._clase.listaArmasClase = new Arma[] { arma1, arma2, arma3, arma4, arma5, arma6 };
    }
    void EmpezarArmasCentinela()
    {
        Arma arma1 = CrearEspRecta();
        Arma arma2 = CrearEspadon();
        Arma arma3 = CrearEspCurva();
        Arma arma4 = CrearAlabarda();
        Arma arma5 = CrearLanza();
        Arma arma6 = CrearArco();
        Personaje._clase.listaArmasClase = new Arma[] { arma1, arma2, arma3, arma4, arma5, arma6 };
    }
    void EmpezarArmasSabio()
    {
        Arma arma1 = CrearCuerpo();
        Arma arma2 = CrearEspRecta();
        Arma arma3 = CrearLanza();
        Arma arma4 = CrearAlabarda();
        Arma arma5 = CrearHacha();
        Arma arma6 = CrearGHacha();
        Personaje._clase.listaArmasClase = new Arma[] { arma1, arma2, arma3, arma4, arma5, arma6 };
    }
    void EmpezarArmasEmbaucador()
    {
        Arma arma1 = CrearCuerpo();
        Arma arma2 = CrearEstoque();
        Arma arma3 = CrearArco();
        Arma arma4 = CrearDaga();
        Arma arma5 = CrearEspadon();
        Arma arma6 = CrearGHacha();
        Personaje._clase.listaArmasClase = new Arma[] { arma1, arma2, arma3, arma4, arma5, arma6 };
    }

    void EmpezarHechizAniquilador()
    {
        Hechizo hech1 = CrearBala();
        Hechizo hech2 = CrearCarga();
        Hechizo hech3 = CrearExpansivo();
        Hechizo hech4 = CrearObliteracion();
        Hechizo hech5 = CrearEnfurecer();
        Hechizo hech6 = CrearAterrar();
        Hechizo hech7 = CrearGrito();
        Hechizo hech8 = CrearAligerar();
        Personaje._clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }
    void EmpezarHechizProtector()
    {
        Hechizo hech1 = CrearBarrera();
        Hechizo hech2 = CrearCura();
        Hechizo hech3 = CrearEnfurecer();
        Hechizo hech4 = CrearGrito();
        Hechizo hech5 = CrearAterrar();
        Hechizo hech6 = CrearInamovible();
        Hechizo hech7 = CrearAtraer();
        Hechizo hech8 = CrearRepeler();
        Personaje._clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }
    void EmpezarHechizCazador()
    {
        Hechizo hech1 = CrearBala();
        Hechizo hech2 = CrearCarga();
        Hechizo hech3 = CrearBiataque();
        Hechizo hech4 = CrearAcercamiento();
        Hechizo hech5 = CrearAligerar();
        Hechizo hech6 = CrearEnfurecer();
        Hechizo hech7 = CrearEntorpecer();
        Hechizo hech8 = CrearMimetizar();
        Personaje._clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }
    void EmpezarHechizSombra()
    {
        Hechizo hech1 = CrearBala();
        Hechizo hech2 = CrearAligerar();
        Hechizo hech3 = CrearEntorpecer();
        Hechizo hech4 = CrearEnfurecer();
        Hechizo hech5 = CrearAcercamiento();
        Hechizo hech6 = CrearSeparacion();
        Hechizo hech7 = CrearBiataque();
        Hechizo hech8 = CrearCombo();
        Personaje._clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }
    void EmpezarHechizAnimatec()
    {
        Hechizo hech1 = CrearBala();
        Hechizo hech2 = CrearPulso();
        Hechizo hech3 = CrearLaser();
        Hechizo hech4 = CrearArtema();
        Hechizo hech5 = CrearCura();
        Hechizo hech6 = CrearBarrera();
        Hechizo hech7 = CrearImbuir();
        Hechizo hech8 = CrearDesalmar();
        Personaje._clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }
    void EmpezarHechizCentinela()
    {
        Hechizo hech1 = CrearBala();
        Hechizo hech2 = CrearBarrera();
        Hechizo hech3 = CrearSeparacion();
        Hechizo hech4 = CrearExpansivo();
        Hechizo hech5 = CrearAclarar();
        Hechizo hech6 = CrearOfuscar();
        Hechizo hech7 = CrearEntorpecer();
        Hechizo hech8 = CrearMasAlla();
        Personaje._clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }
    void EmpezarHechizSabio()
    {
        Hechizo hech1 = CrearBala();
        Hechizo hech2 = CrearLaser();
        Hechizo hech3 = CrearFortalecer();
        Hechizo hech4 = CrearDebilitar();
        Hechizo hech5 = CrearApoderar();
        Hechizo hech6 = CrearComprometer();
        Hechizo hech7 = CrearCura();
        Hechizo hech8 = CrearDesalmar();
        Personaje._clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }
    void EmpezarHechizEmbaucador()
    {
        Hechizo hech1 = CrearEnfurecer();
        Hechizo hech2 = CrearAterrar();
        Hechizo hech3 = CrearAligerar();
        Hechizo hech4 = CrearEntorpecer();
        Hechizo hech5 = CrearAclarar();
        Hechizo hech6 = CrearOfuscar();
        Hechizo hech7 = CrearClarividencia();
        Hechizo hech8 = CrearHumillar();
        Personaje._clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }
}
