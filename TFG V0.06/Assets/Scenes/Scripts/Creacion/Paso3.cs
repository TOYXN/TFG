using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso3 : MonoBehaviour
{
    public GameObject Menu3_1;
    public GameObject Menu3_2;
    public GameObject Menu3_3;
    public GameObject Menu4_1;

    public Image imagenPaso3;
    public Image imagenPaso4;

    public Button continuar1;
    public Button atras1;
    public Button continuar2;
    public Button atras2;
    public Button continuar3;
    public GameObject continuar3GO;
    public Button atras3;

    public GameObject menuRazas;
    public Button humanos;
    public Button reptilianos;
    public Button felinos;
    public Button averios;
    public Button muses;

    public GameObject MenuRazaSelec;
    public Text NombreRaza;
    public Text DescRaza;
    public Text NombrePasiva;
    public Text ValoresOpcionales;
    public Button AbrirDesc;
    public Button SelecRaza;
    public Button CerrarMenuRaza;
    public GameObject MenuDescRaza;
    public Button CerrarMenuDescRaza;

    public GameObject MenuValoresSelecNormal;
    public Button botonValor1;
    public Text nomValor1;
    public Text numeroValor1;
    public Text bonoValor1;
    public Button botonValor2;
    public Text nomValor2;
    public Text numeroValor2;
    public Text bonoValor2;

    public Text ExplicacionPaso;
    public GameObject ExplicacionPasoGO;
    public Personaje Personaje;
    public SelValorHuman funcionHumano;

    int valorFuerza;
    int valorResist;
    int valorAgilid;
    int valorVeloci;
    int valorPoder;
    int valorSentid;
    int valorMemoria;
    int valorPerson;

    // Start is called before the first frame update
    void Start()
    {
        IniciarBotones1();
        IniciarBotones2();
        IniciarBotones3();
        IniciarBotones4();
    }

    void IniciarBotones1()
    {
        continuar1.onClick.AddListener(Siguiente1);
        atras1.onClick.AddListener(Atras1);
        continuar2.onClick.AddListener(Siguiente2);
        atras2.onClick.AddListener(Atras2);
        continuar3.onClick.AddListener(Siguiente3);
        atras3.onClick.AddListener(Atras3);
    }

    void IniciarBotones2()
    {
        humanos.onClick.AddListener(Bypass1);
        reptilianos.onClick.AddListener(Bypass2);
        felinos.onClick.AddListener(Bypass3);
        averios.onClick.AddListener(Bypass4);
        muses.onClick.AddListener(Bypass5);
    }

    void IniciarBotones3()
    {
        AbrirDesc.onClick.AddListener(AbrirDescripcion);
        SelecRaza.onClick.AddListener(RazaSeleccionada);
        CerrarMenuRaza.onClick.AddListener(CerrarRaza);
        CerrarMenuDescRaza.onClick.AddListener(CerrarDescRaza);
    }

    void IniciarBotones4()
    {
        botonValor1.onClick.AddListener(SelecValor1);
        botonValor2.onClick.AddListener(SelecValor2);
    }

    void guardarValoresPers()
    {
        valorFuerza = Personaje.Valor("FUERZA");
        valorResist = Personaje.Valor("RESISTENCIA");
        valorAgilid = Personaje.Valor("AGILIDAD");
        valorVeloci = Personaje.Valor("VELOCIDAD");
        valorPoder = Personaje.Valor("PODER");
        valorSentid = Personaje.Valor("SENTIDOS");
        valorMemoria = Personaje.Valor("MEMORIA");
        valorPerson = Personaje.Valor("PERSONALIDAD");
    }

    void SelecValor1()
    {
        Personaje._raza.valorTerciario = nomValor1.text;
        Personaje.ActualizarValor(nomValor1.text, 1);
        SeleccionRaza();
    }

    void SelecValor2()
    {
        Personaje._raza.valorTerciario = nomValor2.text;
        Personaje.ActualizarValor(nomValor2.text, 1);
        SeleccionRaza();
    }

    void SeleccionRaza()
    {
        Personaje._raza.nombreRaza = NombreRaza.text;
        Personaje._raza.descRaza = DescRaza.text;
        CerrarRaza();
        menuRazas.SetActive(false);
        ExplicacionPaso.text = "Raza seleccionada:\n\n " + NombreRaza.text;
        MenuValoresSelecNormal.SetActive(false);
        ExplicacionPasoGO.SetActive(true);
        continuar3GO.SetActive(true);
    }

    void Siguiente1()
    {
        Menu3_2.SetActive(true);
    }
    void Atras1()
    {
        Menu3_1.SetActive(false);
        imagenPaso3.color = new Vector4(255, 255, 255, 100);
    }

    void Siguiente2()
    {
        Menu3_3.SetActive(true);
        guardarValoresPers();
    }
    void Atras2()
    {
        Menu3_2.SetActive(false);
    }

    void Siguiente3()
    {
        Menu4_1.SetActive(true);
        imagenPaso4.color = new Vector4(0, 255, 0, 100);
    }
    void Atras3()
    {
        Menu3_3.SetActive(false);
        ReiniciarProceso();
    }

    void ReiniciarProceso()
    {
        CerrarRaza();
        MenuValoresSelecNormal.SetActive(false);
        MenuRazaSelec.SetActive(false);
        menuRazas.SetActive(true);
        ExplicacionPasoGO.SetActive(false);
        continuar3GO.SetActive(false);
        Personaje.ActualizarValores(valorFuerza, valorResist, valorAgilid, valorVeloci, valorPoder, valorSentid, valorMemoria, valorPerson);
    }

    void Bypass1()
    {
        string nombreRaza = "Humano";
        string descRaza = "Los seres más comunes del planeta, y los más versátiles. Pueden hacer de todo si se lo proponen. Se dice que eso es posible debido a que el potencial de la humanidad es infinito. Están esparcidos por todos los rincones del mundo y gobiernan la gran mayoría de la población. Su control sobre todas las sociedades es casi absoluto gracias a la capacidad que tienen para cooperar y negociar con el resto de razas a lo largo de la historia. Cuando la política no daba sus frutos, su gran capacidad de estratagemas en combate y sus avances en casi cada campo científico les aseguraba casi siempre la ventaja, así como su dominio en el campo de batalla. Se relacionan generalmente bien con todas las razas, viviendo en armonía en los centros urbanos, pero hay pequeños grupos que aún siguen teniendo rencor a otras razas debido a las diferencias de cultura y guerras del pasado.";
        string nombrePasiva = "Versatilidad";
        string descPasiva = "+2, +1 y +1 a 3 Valores diferentes.";
        string valoresOpc = "Cualquiera";
        AbrirMenuRaza(nombreRaza, descRaza, nombrePasiva, descPasiva, valoresOpc);
    }

    void Bypass2()
    {
        string nombreRaza = "Reptiliano";
        string descRaza = "La forma perfeccionada de los reptiles. Seres de gran dureza, longevidad y fuerza gracias a su piel escamada además de una gran ambición. Debido a su portento físico, suelen dedicarse a trabajos donde la fuerza reina, y sus sociedades suelen regirse por la ley del más fuerte. Muchos de ellos prefieren vivir en grupos exclusivos de reptilianos, pero hay algunos que prefieren alejarse de los nidos y mezclarse con el resto de culturas. Antiguamente solían mantener muchas guerras por control territorial contra el resto de razas. Debido a la multitud de guerras perdidas contra los humanos, suelen tener rencor hacia ellos, y mantienen una gran rivalidad hacia los felinos. No tienen grandes opiniones sobre los averios y muses, con los que a veces hasta han cooperado en el pasado. Se dice que hay un gran grupo de reptilianos que pretenden hacerse con el control mundial desde las sombras, aunque esto solo sean rumores con apenas fundamentos.";
        string nombrePasiva = "Piel Dura";
        string descPasiva = "+2 en RESISTENCIA y +1 en FUERZA";
        string valoresOpc = "+1 en AGILIDAD o en PERSONALIDAD";
        AbrirMenuRaza(nombreRaza, descRaza, nombrePasiva, descPasiva, valoresOpc);
    }

    void Bypass3()
    {
        string nombreRaza = "Felino";
        string descRaza = "Seres de gran agilidad, con rasgos parecidos a los gatos. Son conocidos por sus gráciles movimientos, sigilo y su enorme ego. Su forma de moverse les permite tener la ventaja a la hora de emboscar a sus enemigos o de evitar sus ataques. Los hay que prefieren vivir en manada cooperando entre ellos defendiendo su territorio, otros que prefieren buscar la compañía de alguien de diferente raza y otros que prefieren hacer las cosas en completa soledad. Su rivalidad con los reptilianos la consideran como una rivalidad infantil y una guerra de egos. En realidad su mayor rivalidad es hacia los averios seguida de la que tienen con los muses, quienes han estado cazando durante toda la historia por considerarlos como nada más que alimento. A los únicos que no ven como seres inferiores y que incluso tratan como iguales son los humanos, quienes han ayudado desde tiempos inmemoriales. Se dice que su alianza con los humanos es la más antigua de la historia.";
        string nombrePasiva = "Acrobático";
        string descPasiva = "+2 en AGILIDAD y +1 en PERSONALIDAD";
        string valoresOpc = "+1 en FUERZA o en VELOCIDAD";
        AbrirMenuRaza(nombreRaza, descRaza, nombrePasiva, descPasiva, valoresOpc);
    }

    void Bypass4()
    {
        string nombreRaza = "Averio";
        string descRaza = "Seres con la capacidad de volar y rasgos de pájaro. Su capacidad de volar les hace únicos. Destacan por su sensibilidad en varios sentidos como el oído o la vista. Eso les permite ser increíbles cazadores. Algunos grupos de averios guardan cierta rivalidad con los muses ya que los consideran como su principal alimento aunque la mayoría tengan buena relación con ellos, hasta el punto de tener cierta amistad y alianzas para defenderse de los felinos. Esto también los ha llevado a tener ciertos vínculos de amistad con algunos grupos de reptilianos para repeler el acoso de los felinos. Igual que el resto de razas, los averios suelen ser amistosos con los humanos, quienes les han ayudado para reducir las hostilidades entre ellos y los felinos.";
        string nombrePasiva = "Sensorial";
        string descPasiva = "+2 en SENTIDOS y +1 en VELOCIDAD";
        string valoresOpc = "+1 en MEMORIA o en PODER";
        AbrirMenuRaza(nombreRaza, descRaza, nombrePasiva, descPasiva, valoresOpc);
    }

    void Bypass5()
    {
        string nombreRaza = "Mus";
        string descRaza = "Pequeños seres peludos similares a los roedores. Guardan un gran vínculo con el alma, y son los seres que mayor capacidad tienen de manipularla igualados solo por ciertos humanos. Junto con los averios, se han visto obligados a cooperar con los reptilianos para defenderse de los felinos, a quienes guardan un gran odio. Son los seres más comunes en las ciudades junto a los humanos aunque también hay grandes poblaciones de ellos en zonas rurales. Son seres muy sociables y prefieren hacerlo todo en grupo, ya sea entre muses o otras razas. A estos seres les fascina aprender sobre todos los misterios que guarda la misma realidad, por eso cooperan de tú a tú con los humanos sobre todo en la gran mayoría de campos de la ciencia y la tecnología. Se dice que es gracias a ellos que los humanos han podido prosperar y desarrollar todas las invenciones que han creado, incluso que la manipulación almática fue una enseñanza de los muses hacia los humanos.";
        string nombrePasiva = "Gran Alma";
        string descPasiva = "+2 en PODER y +1 en MEMORIA";
        string valoresOpc = "+1 en RESISTENCIA o en SENTIDOS";
        AbrirMenuRaza(nombreRaza, descRaza, nombrePasiva, descPasiva, valoresOpc);
    }

    void AbrirMenuRaza(string nombreRaza, string descRaza, string nombrePasiva, string descPasiva, string valoresOpc)
    {
        NombreRaza.text = nombreRaza;
        DescRaza.text = descRaza;
        NombrePasiva.text = "Habilidad Pasiva: " + nombrePasiva + "\n" + descPasiva;
        ValoresOpcionales.text = "Valores opcionales:\n" + valoresOpc;
        MenuRazaSelec.SetActive(true);
    }

    void AbrirDescripcion()
    {
        MenuDescRaza.SetActive(true);
    }

    void RazaSeleccionada()
    {
        int valor1 = 0;
        int valor2 = 0;
        int bono1 = 0;
        int bono2 = 0;
        int valorSumado1 = 0;
        int bonoSumado1 = 0;
        int valorSumado2 = 0;
        int bonoSumado2 = 0;
        //Abrir menú de seleccion de Valores segun la raza seleccionada(NombreMenu)
        if (NombreRaza.text == "Reptiliano")
        {
            Personaje.ActualizarValor("RESISTENCIA", 2);
            Personaje.ActualizarValor("FUERZA", 1);
            CalcularValores(valor1, valor2, bono1, bono2, valorSumado1, valorSumado2, bonoSumado1, bonoSumado2, "AGILIDAD", "PERSONALIDAD");
        }
        else if (NombreRaza.text == "Felino")
        {
            Personaje.ActualizarValor("AGILIDAD", 2);
            Personaje.ActualizarValor("PERSONALIDAD", 1);
            CalcularValores(valor1, valor2, bono1, bono2, valorSumado1, valorSumado2, bonoSumado1, bonoSumado2, "FUERZA", "VELOCIDAD");
        }
        else if (NombreRaza.text == "Averio")
        {
            Personaje.ActualizarValor("SENTIDOS",  2);
            Personaje.ActualizarValor("VELOCIDAD", 1);
            CalcularValores(valor1, valor2, bono1, bono2, valorSumado1, valorSumado2, bonoSumado1, bonoSumado2, "MEMORIA", "PODER");
        }
        else if (NombreRaza.text == "Mus")
        {
            Personaje.ActualizarValor("PODER", 2);
            Personaje.ActualizarValor("MEMORIA", 1);
            CalcularValores(valor1, valor2, bono1, bono2, valorSumado1, valorSumado2, bonoSumado1, bonoSumado2, "RESISTENCIA", "SENTIDOS");
        }
        else if (NombreRaza.text == "Humano")
        {
            funcionHumano.SelecValores();
        }
    }

    void CalcularValores(int Val1, int Val2, int Bon1, int Bon2, int ValSum1, int ValSum2, int BonoSum1, int BonoSum2, string Valor1, string Valor2)
    {
        Personaje._raza.valorPrincipal = Valor1;
        Personaje._raza.valorSecundario = Valor2;
        Val1 = Personaje.Valor(Valor1);
        Val2 = Personaje.Valor(Valor2);
        Bon1 = Personaje.BonoValor(Valor1);
        Bon2 = Personaje.BonoValor(Valor2);
        ValSum1 = Val1 + 1;
        ValSum2 = Val2 + 1;
        if (ValSum1 >= 8) { BonoSum1 = (ValSum1 - 8) / 2; }
        else { BonoSum1 = (ValSum1 - 9) / 2; }
        if (ValSum2 >= 8) { BonoSum2 = (ValSum2 - 8) / 2; }
        else { BonoSum2 = (ValSum2 - 9) / 2; }

        numeroValor1.text = Val1 + " > " + ValSum1;
        bonoValor1.text = Bon1 + " > " + BonoSum1;
        numeroValor2.text = Val2 + " > " + ValSum2;
        bonoValor2.text = Bon2 + " > " + BonoSum2;

        nomValor1.text = Valor1;
        nomValor2.text = Valor2;
        MenuValoresSelecNormal.SetActive(true);
    }

    void CerrarRaza()
    {
        MenuRazaSelec.SetActive(false);
    }

    void CerrarDescRaza()
    {
        MenuDescRaza.SetActive(false);
    }
}
