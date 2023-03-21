using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paso6_3 : MonoBehaviour, IDataPersistance
{
    public GameObject ProcesoAsig;
    public GameObject acc1;
    public GameObject acc3;
    public GameObject acc5;
    public GameObject acc7;
    public GameObject acc9;
    public GameObject acc11;
    public GameObject acc13;
    public GameObject acc15;
    public GameObject acc17;
    public GameObject acc19;
    public GameObject acc21;
    public GameObject acc23;
    public GameObject acc25;
    public Button BotonAcc1;
    public Button BotonAcc3;
    public Button BotonAcc5;
    public Button BotonAcc7;
    public Button BotonAcc9;
    public Button BotonAcc11;
    public Button BotonAcc13;
    public Button BotonAcc15;
    public Button BotonAcc17;
    public Button BotonAcc19;
    public Button BotonAcc21;
    public Button BotonAcc23;
    public Button BotonAcc25;

    public GameObject acc2;
    public GameObject acc4;
    public GameObject acc6;
    public GameObject acc8;
    public GameObject acc10;
    public GameObject acc12;
    public GameObject acc14;
    public GameObject acc16;
    public GameObject acc18;
    public GameObject acc20;
    public GameObject acc22;
    public GameObject acc24;
    public Button BotonAcc2;
    public Button BotonAcc4;
    public Button BotonAcc6;
    public Button BotonAcc8;
    public Button BotonAcc10;
    public Button BotonAcc12;
    public Button BotonAcc14;
    public Button BotonAcc16;
    public Button BotonAcc18;
    public Button BotonAcc20;
    public Button BotonAcc22;
    public Button BotonAcc24;

    public GameObject MenuAccion;
    public Text NombreAccion;
    public Text DescAccion;
    public Button SeleccAccion;
    public Text TextoBotonSelecc;
    public Button CerrarMenu;

    public GameObject ProcesoConf;
    public Text NombAccVent1;
    public Text NombAccVent2;
    public Text NombAccVent3;
    public Text NombAccVent4;
    public GameObject pregunta;
    public Button BotonContinuar;
    public Button BotonReiniciar;

    public Button botonAnterior;
    int numAcc;
    public GameObject ContinuarGO;
    public Personaje Personaje;
    GameObject botonAct;

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
        numAcc = 0;
        IniciarBotonesAcciones();
        SeleccAccion.onClick.AddListener(SeleccAccionVent);
        CerrarMenu.onClick.AddListener(CerrarMenuAccion);
        BotonContinuar.onClick.AddListener(AsignarAcciones);
        BotonReiniciar.onClick.AddListener(ReiniciarProceso);
        botonAnterior.onClick.AddListener(ReiniciarProceso);
    }

    void IniciarBotonesAcciones()
    {
        BotonAcc1.onClick.AddListener(Boton1);
        BotonAcc2.onClick.AddListener(Boton2);
        BotonAcc3.onClick.AddListener(Boton3);
        BotonAcc4.onClick.AddListener(Boton4);
        BotonAcc5.onClick.AddListener(Boton5);
        BotonAcc6.onClick.AddListener(Boton6);
        BotonAcc7.onClick.AddListener(Boton7);
        BotonAcc8.onClick.AddListener(Boton8);
        BotonAcc9.onClick.AddListener(Boton9);
        BotonAcc10.onClick.AddListener(Boton10);
        BotonAcc11.onClick.AddListener(Boton11);
        BotonAcc12.onClick.AddListener(Boton12);
        BotonAcc13.onClick.AddListener(Boton13);
        BotonAcc14.onClick.AddListener(Boton14);
        BotonAcc15.onClick.AddListener(Boton15);
        BotonAcc16.onClick.AddListener(Boton16);
        BotonAcc17.onClick.AddListener(Boton17);
        BotonAcc18.onClick.AddListener(Boton18);
        BotonAcc19.onClick.AddListener(Boton19);
        BotonAcc20.onClick.AddListener(Boton20);
        BotonAcc21.onClick.AddListener(Boton21);
        BotonAcc22.onClick.AddListener(Boton22);
        BotonAcc23.onClick.AddListener(Boton23);
        BotonAcc24.onClick.AddListener(Boton24);
        BotonAcc25.onClick.AddListener(Boton25);
    }

    void Boton1()
    {
        AbrirMenu   ("PERCIBIR", 
                    "Vinculada al atributo SENTIDOS. Simboliza la acción de mirar a algo, vigilar, inspeccionar con la mirada o buscar algo por el entorno. Todo lo que sea usar la visión para algo en específico entra dentro de esta acción.",
                    acc1
                    );
    }
    void Boton2()
    {
        AbrirMenu   ("ESCUCHAR",
                    "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el oído para tratar de oír algo, ya sean sonidos sospechosos, conversaciones…",
                    acc2
                    );
    }
    void Boton3()
    {
        AbrirMenu   ("DEGUSTAR",
                    "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el sentido del gusto para poder detectar posibles trazas de ciertos elementos en comidas, bebidas o para identificar objetos.",
                    acc3
                    );
    }
    void Boton4()
    {
        AbrirMenu   ("OLER",
                    "Vinculada al atributo SENTIDOS. Simboliza la acción de usar el olfato para poder detectar rastros de olores y así poder identificar trazas de ciertos elementos en cualquier cosa.",
                    acc4
                    );
    }
    void Boton5()
    {
        AbrirMenu   ("CORRER",
                    "Vinculada al atributo VELOCIDAD. Simboliza la acción de correr o esprintar una cierta distancia o durante cierto tiempo ya sea durante una persecución o una competición.",
                    acc5
                    );
    }
    void Boton6()
    {
        AbrirMenu   ("SALTAR",
                    "Vinculada al atributo FUERZA. Simboliza la acción de saltar vertical o longitudinal una cierta distancia para poder superar un obstáculo, alcanzar algo en lo alto o caer sin hacerse daño.",
                    acc6
                    );
    }
    void Boton7()
    {
        AbrirMenu   ("TREPAR",
                    "Vinculada al atributo AGILIDAD. Simboliza la acción de subir o bajar por una superficie vertical ya sea una pared, un acantilado, un árbol…",
                    acc7
                    );
    }
    void Boton8()
    {
        AbrirMenu   ("NADAR",
                    "Vinculada al atributo RESISTENCIA. Simboliza la acción de moverse dentro del agua, incluyendo también el buceo.",
                    acc8
                    );
    }
    void Boton9()
    {
        AbrirMenu   ("PERSUADIR",
                    "Vinculada al atributo PERSONALIDAD. Simboliza la acción de conversar con alguien para conseguir con razones y argumentos que actúe o piense de un modo determinado. Tranquilizar, encandilar o seducir son consideradas como técnicas de persuasión.",
                    acc9
                    );
    }
    void Boton10()
    {
        AbrirMenu   ("INTIMIDAR",
                    "Vinculada al atributo FUERZA. Simboliza la acción de hacer que alguien sienta miedo o temor para extorsionar o asustar.",
                    acc10
                    );
    }
    void Boton11()
    {
        AbrirMenu   ("NEGOCIAR",
                    "Vinculada al atributo PERSONALIDAD. Simboliza la acción de hablar de un asunto para llegar a un acuerdo o solución.",
                    acc11
                    );
    }
    void Boton12()
    {
        AbrirMenu   ("MENTIR",
                    "Vinculada al atributo PERSONALIDAD. Simboliza la acción de decir deliberadamente lo contrario de lo que se sabe, se cree o se piensa que es verdad con el fin de engañar a alguien.",
                    acc12
                    );
    }
    void Boton13()
    {
        AbrirMenu   ("ROBAR",
                    "Vinculada al atributo AGILIDAD. Simboliza la acción de quitar a una persona algo que le pertenece de forma que no se dé cuenta.",
                    acc13
                    );
    }
    void Boton14()
    {
        AbrirMenu   ("SIGILAR",
                    "Vinculada al atributo AGILIDAD. Simboliza la acción de mantenerse oculto o moverse sin ser detectado.",
                    acc14
                    );
    }
    void Boton15()
    {
        AbrirMenu   ("DISFRAZAR",
                    "Vinculada al atributo AGILIDAD. Simboliza la acción de modificar de alguna forma la apariencia de algo o alguien usando ropa, máscaras y/o maquillaje con el fin de ocultar su verdadera identidad.",
                    acc15
                    );
    }
    void Boton16()
    {
        AbrirMenu   ("RECORDAR",
                    "Vinculada al atributo MEMORIA. Simboliza la acción de traer a la memoria propia algo percibido, aprendido o conocido, o retener algo en la mente.",
                    acc16
                    );
    }
    void Boton17()
    {
        AbrirMenu   ("MAGICOLOGÍA",
                    "Vinculada al atributo PODER. Simboliza la acción de usar los propios conocimientos de la magia para detectar rastros de su uso o reconocer magias entre otras acciones que se relacionen con la magia y su historia.",
                    acc17
                    );
    }
    void Boton18()
    {
        AbrirMenu   ("MEDICINA",
                    "Vinculada al atributo RESISTENCIA. Simboliza la acción de usar los propios conocimientos sobre la medicina y antropología para poder reconocer dolencias, síntomas y lesiones o para curar a alguien.",
                    acc18
                    );
    }
    void Boton19()
    {
        AbrirMenu   ("HISTORIA",
                    "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre la historia del mundo para recordar acontecimientos del pasado o verificar la autenticidad y valor de un objeto.",
                    acc19
                    );
    }
    void Boton20()
    {
        AbrirMenu   ("LEGISLACIÓN",
                    "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos de las leyes para poder defender derechos o aprovechar huecos legales.",
                    acc20
                    );
    }
    void Boton21()
    {
        AbrirMenu   ("ZOOLOGÍA",
                    "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre zoología para identificar animales ya sea viéndolos directamente o por rastros dejados por estos como pisadas, excrementos, etcétera.",
                    acc21
                    );
    }
    void Boton22()
    {
        AbrirMenu   ("BOTÁNICA",
                    "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre botánica para identificar todo tipo de plantas y vegetación según su follaje, tipo de tierra en la que crecen, frutos, tallo, clima en el que se encuentran, etcétera.",
                    acc22
                    );
    }
    void Boton23()
    {
        AbrirMenu   ("CIENCIA",
                    "Vinculada al atributo MEMORIA. Simboliza la acción de usar los propios conocimientos sobre cualquier otra ciencia no especificada anteriormente como física, química, astronomía, biología… Para detectar o crear algún químico, aprovechar fenómenos de la física, guiarse por las estrellas, etcétera.",
                    acc23
                    );
    }
    void Boton24()
    {
        AbrirMenu   ("BAILAR",
                    "Vinculada al atributo AGILIDAD. Simboliza la acción de mover el cuerpo al ritmo de la música.",
                    acc24
                    );
    }
    void Boton25()
    {
        AbrirMenu   ("CANTAR",
                    "Vinculada al atributo PERSONALIDAD. Simboliza la acción de crear una melodía musical usando la voz o haciendo sonidos con la boca.",
                    acc25
                    );
    }

    void AbrirMenu(string nombre, string desc, GameObject boto)
    {
        NombreAccion.text = nombre;
        TextoBotonSelecc.text = "Seleccionar " + nombre + " como acción ventaja";
        DescAccion.text = desc;
        botonAct = boto;
        MenuAccion.SetActive(true);
    }

    void SeleccAccionVent()
    {
        if (numAcc == 0)
        {
            NombAccVent1.text = NombreAccion.text;
        }
        if (numAcc == 1)
        {
            NombAccVent2.text = NombreAccion.text;
        }
        if (numAcc == 2)
        {
            NombAccVent3.text = NombreAccion.text;
        }
        if (numAcc == 3)
        {
            NombAccVent4.text = NombreAccion.text;
            ProcesoAsig.SetActive(false);
            ProcesoConf.SetActive(true);
        }
        botonAct.SetActive(false);
        numAcc++;
        MenuAccion.SetActive(false);
    }

    void AsignarAcciones()
    {
        Personaje.accVent1 = NombAccVent1.text;
        Personaje.accVent2 = NombAccVent2.text;
        Personaje.accVent3 = NombAccVent3.text;
        Personaje.accVent4 = NombAccVent4.text;
        //DataPersistanceManager.instance.ActualizarPersonaje(Personaje);
        ContinuarGO.SetActive(true);
        pregunta.SetActive(false);
    }

    void ReiniciarProceso()
    {
        numAcc = 0;
        acc1.SetActive(true);
        acc3.SetActive(true);
        acc5.SetActive(true);
        acc7.SetActive(true);
        acc9.SetActive(true);
        acc11.SetActive(true);
        acc13.SetActive(true);
        acc15.SetActive(true);
        acc17.SetActive(true);
        acc19.SetActive(true);
        acc21.SetActive(true);
        acc23.SetActive(true);
        acc25.SetActive(true);
        acc2.SetActive(true);
        acc4.SetActive(true);
        acc6.SetActive(true);
        acc8.SetActive(true);
        acc10.SetActive(true);
        acc12.SetActive(true);
        acc14.SetActive(true);
        acc16.SetActive(true);
        acc18.SetActive(true);
        acc20.SetActive(true);
        acc22.SetActive(true);
        acc24.SetActive(true);
        pregunta.SetActive(true);
        MenuAccion.SetActive(false);
        ProcesoAsig.SetActive(true);
        ProcesoConf.SetActive(false);
        ContinuarGO.SetActive(false);
    }

    void CerrarMenuAccion()
    {
        MenuAccion.SetActive(false);
    }
}
