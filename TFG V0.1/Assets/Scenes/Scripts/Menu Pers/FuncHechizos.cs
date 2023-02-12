using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuncHechizos : MonoBehaviour, IDataPersistance
{
    public Text nomHech1;
    public Text nomHech2;
    public Text nomHech3;
    public Text nomHech4;
    public Text nomHech5;
    public Text nomHech6;
    public Text nomHech7;
    public Text nomHech8;

    public Text costeHech1;
    public Text costeHech2;
    public Text costeHech3;
    public Text costeHech4;
    public Text costeHech5;
    public Text costeHech6;
    public Text costeHech7;
    public Text costeHech8;

    public Text dadosHech1;
    public Text dadosHech2;
    public Text dadosHech3;
    public Text dadosHech4;
    public Text dadosHech5;
    public Text dadosHech6;
    public Text dadosHech7;
    public Text dadosHech8;

    public Button usarHech1;
    public Button usarHech2;
    public Button usarHech3;
    public Button usarHech4;
    public Button usarHech5;
    public Button usarHech6;
    public Button usarHech7;
    public Button usarHech8;

    public GameObject menuHech;
    public Text nomHechMenu;
    public Text descHechMenu;
    public Text costeHechMenu;
    public Text dadosHechMenu;
    public Text PAPersMenu;
    public Button usarHech;
    public Button cerrarMenuHech;

    public GameObject resultadoHech;
    public Text resultHech;
    public Text desgloseResultHech;
    public Text infoResultHech;
    public Button cerrarMenuResultHech;

    public Text PAPers;

    int hechSelec;


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
        usarHech1.onClick.AddListener(Bypass1);
        usarHech2.onClick.AddListener(Bypass2);
        usarHech3.onClick.AddListener(Bypass3);
        usarHech4.onClick.AddListener(Bypass4);
        usarHech5.onClick.AddListener(Bypass5);
        usarHech6.onClick.AddListener(Bypass6);
        usarHech7.onClick.AddListener(Bypass7);
        usarHech8.onClick.AddListener(Bypass8);
        usarHech.onClick.AddListener(UsarHech);
        cerrarMenuHech.onClick.AddListener(CerrarMenuHech);
        cerrarMenuResultHech.onClick.AddListener(CerrarMenuResultHech);
        IniciarHechPers();
    }

    void IniciarHechPers()
    {
        int numHechPers = Personaje.hechizosGuard;
        if (numHechPers >= 1)
        {
            MeterNuevoHechizo(nomHech1, Personaje.listaHechizos[0].nombreHechizo, costeHech1, Personaje.listaHechizos[0].costeHechizo, dadosHech1, Personaje.listaHechizos[0].dadoHechizo);
            if (numHechPers >= 2)
            {
                MeterNuevoHechizo(nomHech2, Personaje.listaHechizos[1].nombreHechizo, costeHech2, Personaje.listaHechizos[1].costeHechizo, dadosHech2, Personaje.listaHechizos[1].dadoHechizo);
                if (numHechPers >= 3)
                {
                    MeterNuevoHechizo(nomHech3, Personaje.listaHechizos[2].nombreHechizo, costeHech3, Personaje.listaHechizos[2].costeHechizo, dadosHech3, Personaje.listaHechizos[2].dadoHechizo);
                    if (numHechPers >= 4)
                    {
                        MeterNuevoHechizo(nomHech4, Personaje.listaHechizos[3].nombreHechizo, costeHech4, Personaje.listaHechizos[3].costeHechizo, dadosHech4, Personaje.listaHechizos[3].dadoHechizo);
                        if (numHechPers >= 5)
                        {
                            MeterNuevoHechizo(nomHech5, Personaje.listaHechizos[4].nombreHechizo, costeHech5, Personaje.listaHechizos[4].costeHechizo, dadosHech5, Personaje.listaHechizos[4].dadoHechizo);
                            if (numHechPers >= 6)
                            {
                                MeterNuevoHechizo(nomHech6, Personaje.listaHechizos[5].nombreHechizo, costeHech6, Personaje.listaHechizos[5].costeHechizo, dadosHech6, Personaje.listaHechizos[5].dadoHechizo);
                                if (numHechPers >= 7)
                                {
                                    MeterNuevoHechizo(nomHech7, Personaje.listaHechizos[6].nombreHechizo, costeHech7, Personaje.listaHechizos[6].costeHechizo, dadosHech7, Personaje.listaHechizos[6].dadoHechizo);
                                    if (numHechPers >= 8)
                                    {
                                        MeterNuevoHechizo(nomHech8, Personaje.listaHechizos[7].nombreHechizo, costeHech8, Personaje.listaHechizos[7].costeHechizo, dadosHech8, Personaje.listaHechizos[7].dadoHechizo);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    void Bypass1()
    {
        hechSelec = 0;
        AbrirMenuHechizo(Personaje.listaHechizos[hechSelec].nombreHechizo, Personaje.listaHechizos[hechSelec].descHechizo,
                         Personaje.listaHechizos[hechSelec].costeHechizo, Personaje.listaHechizos[hechSelec].dadoHechizo);
    }

    void Bypass2()
    {
        hechSelec = 1;
        AbrirMenuHechizo(Personaje.listaHechizos[hechSelec].nombreHechizo, Personaje.listaHechizos[hechSelec].descHechizo,
                         Personaje.listaHechizos[hechSelec].costeHechizo, Personaje.listaHechizos[hechSelec].dadoHechizo);
    }

    void Bypass3()
    {
        hechSelec = 2;
        AbrirMenuHechizo(Personaje.listaHechizos[hechSelec].nombreHechizo, Personaje.listaHechizos[hechSelec].descHechizo,
                         Personaje.listaHechizos[hechSelec].costeHechizo, Personaje.listaHechizos[hechSelec].dadoHechizo);
    }

    void Bypass4()
    {
        hechSelec = 3;
        AbrirMenuHechizo(Personaje.listaHechizos[hechSelec].nombreHechizo, Personaje.listaHechizos[hechSelec].descHechizo,
                         Personaje.listaHechizos[hechSelec].costeHechizo, Personaje.listaHechizos[hechSelec].dadoHechizo);
    }

    void Bypass5()
    {
        hechSelec = 4;
        AbrirMenuHechizo(Personaje.listaHechizos[hechSelec].nombreHechizo, Personaje.listaHechizos[hechSelec].descHechizo,
                         Personaje.listaHechizos[hechSelec].costeHechizo, Personaje.listaHechizos[hechSelec].dadoHechizo);
    }

    void Bypass6()
    {
        hechSelec = 5;
        AbrirMenuHechizo(Personaje.listaHechizos[hechSelec].nombreHechizo, Personaje.listaHechizos[hechSelec].descHechizo,
                         Personaje.listaHechizos[hechSelec].costeHechizo, Personaje.listaHechizos[hechSelec].dadoHechizo);
    }

    void Bypass7()
    {
        hechSelec = 6;
        AbrirMenuHechizo(Personaje.listaHechizos[hechSelec].nombreHechizo, Personaje.listaHechizos[hechSelec].descHechizo,
                         Personaje.listaHechizos[hechSelec].costeHechizo, Personaje.listaHechizos[hechSelec].dadoHechizo);
    }

    void Bypass8()
    {
        hechSelec = 7;
        AbrirMenuHechizo(Personaje.listaHechizos[hechSelec].nombreHechizo, Personaje.listaHechizos[hechSelec].descHechizo,
                         Personaje.listaHechizos[hechSelec].costeHechizo, Personaje.listaHechizos[hechSelec].dadoHechizo);
    }

    void AbrirMenuHechizo(string nomHechizo, string descHechizo, int costeHechizo, int dadoHechizo)
    {
        nomHechMenu.text = nomHechizo;
        descHechMenu.text = descHechizo;
        costeHechMenu.text = "Coste: " + costeHechizo + " PA";
        if (dadoHechizo == 0)
        {
            dadosHechMenu.text = "-";
        }
        else
        {
            dadosHechMenu.text = "Dados: d" + dadoHechizo + " X" + Personaje._otros.numDados;
        }
        PAPersMenu.text = "PA Actuales: " + Personaje.Valor("ALMAACT") + "/" + Personaje.Valor("ALMAMAX");
        menuHech.SetActive(true);
    }

    void UsarHech()
    {
        if(Personaje.listaHechizos[hechSelec].tipoHechizo == "Magia")
        {
            UsarMagia(Personaje.listaHechizos[hechSelec].dadoHechizo);
        }
        else if (Personaje.listaHechizos[hechSelec].tipoHechizo == "Ataque")
        {
            UsarAtaque();
        }
        else if (Personaje.listaHechizos[hechSelec].tipoHechizo == "Carga")
        {
            UsarCarga(Personaje.listaHechizos[hechSelec].dadoHechizo);
        }
        else if (Personaje.listaHechizos[hechSelec].tipoHechizo == "Oblit")
        {
            UsarObliteracion();
        }
        else if (Personaje.listaHechizos[hechSelec].tipoHechizo == "Bi")
        {
            UsarBiataque();
        }
        else if (Personaje.listaHechizos[hechSelec].tipoHechizo == "Combo")
        {
            UsarCombo();
        }
        else if (Personaje.listaHechizos[hechSelec].tipoHechizo == "Mimet")
        {
            UsarMimetizar(Personaje.listaHechizos[hechSelec].descHechizo);
        }
        else if (Personaje.listaHechizos[hechSelec].tipoHechizo == "Pasivo")
        {
            UsarPasivo(Personaje.listaHechizos[hechSelec].descHechizo);
        }
        int PAAct = Personaje.Valor("ALMAACT");
        int valorRestar = Personaje.listaHechizos[hechSelec].costeHechizo;
        int resultado = PAAct - valorRestar;
        Personaje.ActualizarValor("ALMAACT", resultado);
        PAPersMenu.text = "PA Actuales: " + Personaje.Valor("ALMAACT") + "/" + Personaje.Valor("ALMAMAX");
        PAPers.text = Personaje.Valor("ALMAACT") + "/" + Personaje.Valor("ALMAMAX");
        resultadoHech.SetActive(true);

    }

    void UsarMagia(int dado)
    {
        int min = 1;
        int max = dado + 1;
        int numDadoTirada;
        int result = 0;
        int bonoActual = Personaje.BonoValor("PODER");
        for (int i = 0; i < Personaje._otros.numDados; i++)
        {
            numDadoTirada = Random.Range(min, max);
            result = result + numDadoTirada;
            desgloseResultHech.text += numDadoTirada + " (d" + dado + ") " + "+ ";
        }
        result = result + bonoActual;
        resultHech.text = "Resultado: " + result;
        desgloseResultHech.text += bonoActual + " (Bono PODER)";
    }

    void UsarAtaque()
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
            desgloseResultHech.text += numDadoTirada + " (" + Personaje.ArmaEquipada.dadoArma + ") " + "+ ";
        }
        result = result + bonoActual;
        if (Personaje.cargado)
        {
            result = result + Personaje.valorCargado;
            desgloseResultHech.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") + " + Personaje.valorCargado + " (Ataque cargado)";
            Personaje.valorCargado = 0;
            Personaje.cargado = false;
        }
        else
        {
            desgloseResultHech.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") ";
        }
        resultHech.text = "Resultado: " + result;
    }

    void UsarCarga(int dado)
    {
        int min = 1;
        int max = dado + 1;
        int numDadoTirada;
        int result = 0;
        int bonoActual = Personaje.BonoValor("PODER");
        for (int i = 0; i < Personaje._otros.numDados; i++)
        {
            numDadoTirada = Random.Range(min, max);
            result = result + numDadoTirada;
            desgloseResultHech.text += numDadoTirada + " (d" + dado + ") " + "+ ";
        }
        
        result = result + bonoActual;
        Personaje.cargado = true;
        Personaje.valorCargado = result;
        resultHech.text = "Resultado: " + result;
        desgloseResultHech.text += bonoActual + " (Bono PODER)";
    }

    void UsarObliteracion()
    {
        int min = 1;
        int max = Personaje.ArmaEquipada.dadoArma + 1;
        int numDadoTirada;
        int result = 0;
        int bonoActual = Personaje.BonoValor(Personaje.ArmaEquipada.tipoArma);
        for (int i = 0; i < Personaje._otros.numDados + 4; i++)
        {
            numDadoTirada = Random.Range(min, max);
            result = result + numDadoTirada;
            desgloseResultHech.text += numDadoTirada + " (" + Personaje.ArmaEquipada.dadoArma + ") " + "+ ";
        }
        result = result + bonoActual;
        if (Personaje.cargado)
        {
            result = result + Personaje.valorCargado;
            desgloseResultHech.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") + " + Personaje.valorCargado + " (Ataque cargado)";
            Personaje.valorCargado = 0;
            Personaje.cargado = false;
        }
        else
        {
            desgloseResultHech.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") ";
        }
        resultHech.text = "Resultado: " + result;
    }

    void UsarBiataque()
    {
        int min = 1;
        int max = Personaje.ArmaEquipada.dadoArma + 1;
        int numDadoTirada;
        int result = 0;
        int bonoActual = Personaje.BonoValor(Personaje.ArmaEquipada.tipoArma);
        for (int a = 0; a < 2; a++)
        {
            for (int i = 0; i < Personaje._otros.numDados; i++)
            {
                numDadoTirada = Random.Range(min, max);
                result = result + numDadoTirada;
                desgloseResultHech.text += numDadoTirada + " (" + Personaje.ArmaEquipada.dadoArma + ") " + "+ ";
            }
            result = result + bonoActual;

            if (Personaje.cargado)
            {
                result = result + Personaje.valorCargado;
                desgloseResultHech.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") + " + Personaje.valorCargado + " (Ataque cargado) ";
                Personaje.valorCargado = 0;
                Personaje.cargado = false;
            }
            else
            {
                desgloseResultHech.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") ";
            }
            desgloseResultHech.text += "| ";
        }
        resultHech.text = "Resultado: " + result;
    }

    void UsarMimetizar(string descripcion)
    {
        infoResultHech.text = descripcion;
        Personaje.oculto = true;
    }

    void UsarPasivo(string descripcion)
    {
        infoResultHech.text = descripcion;
    }

    void UsarCombo()
    {
        int minAtk = 1;
        int maxAtk = Personaje.ArmaEquipada.dadoArma + 1;
        int minBonus = 1;
        int maxBonus = 7;
        int minTimes = Personaje._otros.numDados;
        int maxTimes = 9;
        int numDadoAtaque;
        int numDadoBono;
        int result = 0;
        int bonoPoder = Personaje.BonoValor("PODER");
        int bonoActual = Personaje.BonoValor(Personaje.ArmaEquipada.tipoArma);
        numDadoAtaque = Random.Range(minTimes, maxTimes);
        for (int a = 0; a < numDadoAtaque; a++)
        {
            for (int i = 0; i < Personaje._otros.numDados; i++)
            {
                numDadoAtaque = Random.Range(minAtk, maxAtk);
                numDadoBono = Random.Range(minBonus, maxBonus);
                result = result + numDadoAtaque + numDadoBono;
                desgloseResultHech.text += numDadoAtaque + " (" + Personaje.ArmaEquipada.dadoArma + ")" + " + " + numDadoBono + " (Daño Adicional) ";
            }
            result = result + bonoActual;

            if (Personaje.cargado)
            {
                result = result + Personaje.valorCargado;
                desgloseResultHech.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") + " + Personaje.valorCargado + " (Ataque cargado) ";
                Personaje.valorCargado = 0;
                Personaje.cargado = false;
            }
            else
            {
                desgloseResultHech.text += bonoActual + " (Bono " + Personaje.ArmaEquipada.tipoArma + ") ";
            }
            desgloseResultHech.text += "| ";
        }
        resultHech.text = "Resultado: " + result;
    }

    public void ActHechiz(int num)
    {
        if(num == 0)
        {
            int dado = Personaje.listaHechizos[0].dadoHechizo;
            MeterNuevoHechizo(nomHech1, Personaje.listaHechizos[0].nombreHechizo,
                                costeHech1, Personaje.listaHechizos[0].costeHechizo,
                                dadosHech1, dado);
        }
        if (num == 1)
        {
            int dado = Personaje.listaHechizos[1].dadoHechizo;
            MeterNuevoHechizo(nomHech2, Personaje.listaHechizos[1].nombreHechizo,
                                costeHech2, Personaje.listaHechizos[1].costeHechizo,
                                dadosHech2, dado);
        }
        if (num == 2)
        {
            int dado = Personaje.listaHechizos[2].dadoHechizo;
            MeterNuevoHechizo(nomHech3, Personaje.listaHechizos[2].nombreHechizo,
                                costeHech3, Personaje.listaHechizos[2].costeHechizo,
                                dadosHech3, dado);
        }
        if (num == 3)
        {
            int dado = Personaje.listaHechizos[3].dadoHechizo;
            MeterNuevoHechizo(nomHech4, Personaje.listaHechizos[3].nombreHechizo,
                                costeHech4, Personaje.listaHechizos[3].costeHechizo,
                                dadosHech4, dado);
        }
        if (num == 4)
        {
            int dado = Personaje.listaHechizos[4].dadoHechizo;
            MeterNuevoHechizo(nomHech5, Personaje.listaHechizos[4].nombreHechizo,
                                costeHech5, Personaje.listaHechizos[4].costeHechizo,
                                dadosHech5, dado);
        }
        if (num == 5)
        {
            int dado = Personaje.listaHechizos[5].dadoHechizo;
            MeterNuevoHechizo(nomHech6, Personaje.listaHechizos[5].nombreHechizo,
                                costeHech6, Personaje.listaHechizos[5].costeHechizo,
                                dadosHech6, dado);
        }
        if (num == 6)
        {
            int dado = Personaje.listaHechizos[6].dadoHechizo;
            MeterNuevoHechizo(nomHech7, Personaje.listaHechizos[6].nombreHechizo,
                                costeHech7, Personaje.listaHechizos[6].costeHechizo,
                                dadosHech7, dado);
        }
        if (num == 7)
        {
            int dado = Personaje.listaHechizos[7].dadoHechizo;
            MeterNuevoHechizo(nomHech8, Personaje.listaHechizos[7].nombreHechizo,
                                costeHech8, Personaje.listaHechizos[7].costeHechizo,
                                dadosHech8, dado);
        }
    }

    void MeterNuevoHechizo(Text nombrePoner, string nombre, Text costePoner, int coste, Text dadosPoner, int dados)
    {
        nombrePoner.text = nombre;
        costePoner.text = coste + " PA";

        if (dados == 0)
        {
            dadosPoner.text = "-";
        }
        else
        {
            dadosPoner.text = "d" + dados + " X" + Personaje._otros.numDados;
        }
    }

    void CerrarMenuHech()
    {
        menuHech.SetActive(false);
    }

    void CerrarMenuResultHech()
    {
        resultHech.text = " ";
        desgloseResultHech.text = " ";
        infoResultHech.text = " ";
        resultadoHech.SetActive(false);
    }
}
