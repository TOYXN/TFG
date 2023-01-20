using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValoresCuerpo
{
    public int fuerza;
    public int resist;
    public int agilidad;
    public int velocidad;
    public int extra_vida = 0;

    public int bono_fuerza;
    public int bono_resist;
    public int bono_agilidad;
    public int bono_velocidad;

    public int cuerpo_act;
    public int cuerpo_max;
    public float cuerpo_hora;

    public ValoresCuerpo() { }

    public ValoresCuerpo(int fuerza, int resist, int agilidad, int velocidad)
    {
        this.fuerza = fuerza;
        this.resist = resist;
        this.agilidad = agilidad;
        this.velocidad = velocidad;

        if (fuerza >= 8) { this.bono_fuerza = (fuerza - 8) / 2; }
        else { this.bono_fuerza = (fuerza - 9) / 2; }
        if (resist >= 8) { this.bono_resist = (resist - 8) / 2; }
        else { this.bono_resist = (resist - 9) / 2; }
        if (agilidad >= 8) { this.bono_agilidad = (agilidad - 8) / 2; }
        else { this.bono_agilidad = (agilidad - 9) / 2; }
        if (velocidad >= 8) { this.bono_velocidad = (velocidad - 8) / 2; }
        else { this.bono_velocidad = (velocidad - 9) / 2; }

        this.cuerpo_max = 20 + (bono_resist * 2);
        this.cuerpo_act = cuerpo_max;
        this.cuerpo_hora = (cuerpo_max * 10.0f) / 100.0f;
    }

    //Para settear los valores de cuerpo o al actualizar valores. 
    public void ActValoresCuerpo(int fuerza, int resist, int agilidad, int velocidad)
    {
        this.fuerza = fuerza;
        this.resist = resist;
        this.agilidad = agilidad;
        this.velocidad = velocidad;

        if (fuerza >= 8) { this.bono_fuerza = (fuerza - 8) / 2; }
        else { this.bono_fuerza = (fuerza - 9) / 2; }
        if (resist >= 8) { this.bono_resist = (resist - 8) / 2; }
        else { this.bono_resist = (resist - 9) / 2; }
        if (agilidad >= 8) { this.bono_agilidad = (agilidad - 8) / 2; }
        else { this.bono_agilidad = (agilidad - 9) / 2; }
        if (velocidad >= 8) { this.bono_velocidad = (velocidad - 8) / 2; }
        else { this.bono_velocidad = (velocidad - 9) / 2; }

        this.cuerpo_max = 20 + (bono_resist * 2) + extra_vida;
        this.cuerpo_act = cuerpo_max;
        this.cuerpo_hora = (cuerpo_max * 10.0f) / 100.0f;
    }

    public void ActFuerza(int numero)
    {
        fuerza = fuerza + numero;
        if (fuerza >= 8) { bono_fuerza = (fuerza - 8) / 2; }
        else { bono_fuerza = (fuerza - 9) / 2; }
    }
    public void ActResis(int numero)
    {
        resist = resist + numero;
        if (resist >= 8) { bono_resist = (resist - 8) / 2; }
        else { bono_resist = (resist - 9) / 2; }
        cuerpo_max = 20 + (bono_resist * 2) + extra_vida;
        cuerpo_act = cuerpo_max;
        cuerpo_hora = (cuerpo_max * 10.0f) / 100.0f;
    }

    public void ActResisBuff(int numero)
    {
        resist = resist + numero;
        if (resist >= 8) { bono_resist = (resist - 8) / 2; }
        else { bono_resist = (resist - 9) / 2; }
    }

    public void ActAgil(int numero)
    {
        agilidad = agilidad + numero;
        if (agilidad >= 8) { bono_agilidad = (agilidad - 8) / 2; }
        else { bono_agilidad = (agilidad - 9) / 2; }
    }
    public void ActVel(int numero)
    {
        velocidad = velocidad + numero;
        if (velocidad >= 8) { bono_velocidad = (velocidad - 8) / 2; }
        else { bono_velocidad = (velocidad - 9) / 2; }
    }
}

public class ValoresAlma
{
    public int poder;
    public int sentidos;
    public int memoria;
    public int persona;
    public int extra_mana = 0;

    public int bono_poder;
    public int bono_sentidos;
    public int bono_memoria;
    public int bono_persona;


    public int alma_act;
    public int alma_max;
    public float alma_hora;

    public ValoresAlma() { }

    public ValoresAlma(int poder, int sentidos, int memoria, int persona)
    {
        this.poder = poder;
        this.sentidos = sentidos;
        this.memoria = memoria;
        this.persona = persona;

        if (poder >= 8) { this.bono_poder = (poder - 8) / 2; }
        else { this.bono_poder = (poder - 9) / 2; }
        if (sentidos >= 8) { this.bono_sentidos = (sentidos - 8) / 2; }
        else { this.bono_sentidos = (sentidos - 9) / 2; }
        if (memoria >= 8) { this.bono_memoria = (memoria - 8) / 2; }
        else { this.bono_memoria = (memoria - 9) / 2; }
        if (persona >= 8) { this.bono_persona = (persona - 8) / 2; }
        else { this.bono_persona = (persona - 9) / 2; }

        this.alma_max = 30 + (bono_poder * 2);
        this.alma_act = alma_max;
        this.alma_hora = (alma_max * 10.0f) / 100.0f;
    }

    //Para settear los valores de alma o al actualizar valores. 
    public void ActValoresAlma(int poder, int sentidos, int memoria, int persona)
    {
        this.poder = poder;
        this.sentidos = sentidos;
        this.memoria = memoria;
        this.persona = persona;

        if (poder >= 8) { this.bono_poder = (poder - 8) / 2; }
        else { this.bono_poder = (poder - 9) / 2; }
        if (sentidos >= 8) { this.bono_sentidos = (sentidos - 8) / 2; }
        else { this.bono_sentidos = (sentidos - 9) / 2; }
        if (memoria >= 8) { this.bono_memoria = (memoria - 8) / 2; }
        else { this.bono_memoria = (memoria - 9) / 2; }
        if (persona >= 8) { this.bono_persona = (persona - 8) / 2; }
        else { this.bono_persona = (persona - 9) / 2; }

        this.alma_max = 30 + (bono_poder * 2) + extra_mana;
        this.alma_act = alma_max;
        this.alma_hora = (alma_max * 10.0f) / 100.0f;
    }

    public void ActPoder(int numero)
    {
        poder = poder + numero;
        if (poder >= 8) { bono_poder = (poder - 8) / 2; }
        else { bono_poder = (poder - 9) / 2; }
        alma_max = 30 + (bono_poder * 2) + extra_mana;
        alma_act = alma_max;
        alma_hora = (alma_max * 10.0f) / 100.0f;
    }

    public void ActPoderBuff(int numero)
    {
        poder = poder + numero;
        if (poder >= 8) { bono_poder = (poder - 8) / 2; }
        else { bono_poder = (poder - 9) / 2; }
    }

    public void ActSent(int numero)
    {
        sentidos = sentidos + numero;
        if (sentidos >= 8) { bono_sentidos = (sentidos - 8) / 2; }
        else { bono_sentidos = (sentidos - 9) / 2; }
    }
    public void ActMemo(int numero)
    {
        memoria = memoria + numero;
        if (memoria >= 8) { bono_memoria = (memoria - 8) / 2; }
        else { bono_memoria = (memoria - 9) / 2; }
    }
    public void ActPers(int numero)
    {
        persona = persona + numero;
        if (persona >= 8) { bono_persona = (persona - 8) / 2; }
        else { bono_persona = (persona - 9) / 2; }
    }
}

public class OtrosValores
{
    public int apt;
    public int numDados;
    public string estado;

    public OtrosValores() { }

    public OtrosValores(int apt, int numDados, string estado)
    {
        this.apt = apt;
        this.numDados = numDados;
        this.estado = estado;
    }

    //Para settear los valores o al actualizar valores. 
    public void ActOtrosValores(int apt, int numDados, string estado)
    {
        this.apt = apt;
        this.numDados = numDados;
        this.estado = estado;
    }
}


public class Raza
{
    public string nombreRaza;
    public string descRaza;
    public string valorPrincipal;
    public string valorSecundario;
    public string valorTerciario;

    public Raza() { }

    public Raza(string nombreRaza, string descRaza, string valorPrincipal, string valorSecundario, string valorTerciario)
    {
        this.nombreRaza = nombreRaza;
        this.descRaza = descRaza;
        this.valorPrincipal = valorPrincipal;
        this.valorSecundario = valorSecundario;
        this.valorTerciario = valorTerciario;
    }

    public string GetElemRaza(string elem)
    {
        string res = " ";
        if (elem == "nombre") { res = nombreRaza; }
        else if (elem == "valor1") { res = valorPrincipal; }
        else if (elem == "valor2") { res = valorSecundario; }
        else if (elem == "valor3") { res = valorTerciario; }
        else if (elem == "descripcion") { res = descRaza; }
        return res;
    }
}

public class Clase
{
    public string nombreClase;
    public string descClase;
    public string valorClase;

    public Hechizo[] listaHechizosClase;

    public Clase() { }

    public Clase(string nombreClase, string descClase, string valorClase)
    {
        this.nombreClase = nombreClase;
        this.descClase = descClase;
        this.valorClase = valorClase;
    }

    public string GetElemClase(string elem)
    {
        string res = " ";
        if (elem == "nombre") { res = nombreClase; }
        else if (elem == "valor") { res = valorClase; }
        else if (elem == "descripcion") { res = descClase; }
        return res;
    }
}

public class Hechizo
{
    public string nombreHechizo;
    public string descHechizo;
    public int costeHechizo;
    public int dadoHechizo;

    public Hechizo() { }

    public Hechizo(string nombreHechizo, string descHechizo, int costeHechizo, int dadoHechizo)
    {
        this.nombreHechizo = nombreHechizo;
        this.descHechizo = descHechizo;
        this.costeHechizo = costeHechizo;
        this.dadoHechizo = dadoHechizo;
    }
}


public class Personaje : MonoBehaviour
{
    public string nombre;
    public int nivel;
    public int exp;
    public int expProxNivel;
    public int hechizosGuard;
    public string accVent1;
    public string accVent2;
    public string accVent3;
    public string accVent4;

    public Hechizo[] listaHechizos;
    public int numHechiz;

    public Clase _clase;
    public Raza _raza;

    public ValoresCuerpo _cuerpo;
    public ValoresAlma _alma;
    public OtrosValores _otros;

    void Start()
    {
        nombre = "Antonio";
        nivel = 1;
        exp = 0;
        expProxNivel = 100;
        hechizosGuard = 0;
        numHechiz = 0;
        accVent1 = "PERCIBIR";
        accVent2 = "SALTAR";
        accVent3 = "BOTÁNICA";
        accVent4 = "SIGILAR";
        _clase = new Clase("Cazador", " ", "AGILIDAD");
        listaHechizos = new Hechizo[8];
        EmpezarHechizClase();
        _raza = new Raza("Humano", " ", "VELOCIDAD", "AGILIDAD", "PERSONALIDAD");     
        _cuerpo = new ValoresCuerpo(8, 8, 8, 8);
        _alma = new ValoresAlma(8, 8, 8, 8);
        _otros = new OtrosValores();
        _otros.numDados = 1 + (nivel / 2);
        _otros.apt = 2 + (_cuerpo.bono_velocidad / 2);
        _otros.estado = "ESTABLE";
    }

    void EmpezarHechizClase()
    {
        string nombre1 = "Bala";
        string desc1 = "Concentra una pequeña parte de su alma en un punto y la dispara a alta velocidad para infringir daño a un enemigo.";
        int coste1 = 6;
        int dado1 = 6;
        Hechizo hech1 = new Hechizo(nombre1, desc1, coste1, dado1);
        //_clase.listaHechizosClase[0].nombreHechizo = "Bala";
        //_clase.listaHechizosClase[0].descHechizo = "Concentra una pequeña parte de su alma en un punto y la dispara a alta velocidad para infringir daño a un enemigo.";
        //_clase.listaHechizosClase[0].costeHechizo = 6;
        //_clase.listaHechizosClase[0].dadoHechizo = 6;

        string nombre2 = "Carga";
        string desc2 = "Concentra su alma para que su siguiente ataque con el arma haga daño adicional.";
        int coste2 = 6;
        int dado2 = 6;
        Hechizo hech2 = new Hechizo(nombre2, desc2, coste2, dado2);

        string nombre3 = "Terataque";
        string desc3 = "Se concentra en cuerpo y alma para atacar 4 veces consecutivas muy rápido a un enemigo.";
        int coste3 = 16;
        int dado3 = 0;
        Hechizo hech3 = new Hechizo(nombre3, desc3, coste3, dado3);

        string nombre4 = "Acercamiento";
        string desc4 = "Permite al usuario atacar a la vez que se enfrenta a un enemigo.";
        int coste4 = 8;
        int dado4 = 0;
        Hechizo hech4 = new Hechizo(nombre4, desc4, coste4, dado4);

        string nombre5 = "Aligerar";
        string desc5 = "Mejora la Agilidad y Velocidad de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.";
        int coste5 = 14;
        int dado5 = 0;
        Hechizo hech5 = new Hechizo(nombre5, desc5, coste5, dado5);

        string nombre6 = "Enfurecer";
        string desc6 = "Mejora la Fuerza y Resistencia de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.";
        int coste6 = 14;
        int dado6 = 0;
        Hechizo hech6 = new Hechizo(nombre6, desc6, coste6, dado6);

        string nombre7 = "Entorpecer";
        string desc7 = "Reduce la Agilidad y Velocidad de un objetivo por 2 puntos. Este efecto dura para todo el combate o hasta 3 turnos de acciones fuera de combate. Se puede acumular.";
        int coste7 = 14;
        int dado7 = 0;
        Hechizo hech7 = new Hechizo(nombre7, desc7, coste7, dado7);

        string nombre8 = "Mimetizar";
        string desc8 = "Manipula su alma de tal forma que se vuelve imperceptible a la vista. Los enemigos no podrán atacarte hasta que se pierde el efecto. El próximo ataque siempre hará daño doble.";
        int coste8 = 20;
        int dado8 = 0;
        Hechizo hech8 = new Hechizo(nombre8, desc8, coste8, dado8);

        _clase.listaHechizosClase = new Hechizo[] { hech1, hech2, hech3, hech4, hech5, hech6, hech7, hech8 };
    }

    public void ActualizarValores(int fuerza, int resist, int agilidad, int velocidad, int poder, int sentidos, int memoria, int persona)
    {
        _cuerpo.ActValoresCuerpo(fuerza, resist, agilidad, velocidad);
        _alma.ActValoresAlma(poder, sentidos, memoria, persona);
        _otros.apt = 2 + (_cuerpo.bono_velocidad/2);
        _otros.numDados = 1 + (nivel/2);
    }

    public void ActualizarValor(string nombreValor, int numero)
    {
        if (nombreValor == "FUERZA") { _cuerpo.ActFuerza(numero); }
        else if (nombreValor == "RESISTENCIA") { _cuerpo.ActResis(numero); }
        else if (nombreValor == "AGILIDAD") { _cuerpo.ActAgil(numero); }
        else if (nombreValor == "VELOCIDAD") { _cuerpo.ActVel(numero); _otros.apt = 2 + (_cuerpo.bono_velocidad / 2); }

        else if (nombreValor == "PODER") { _alma.ActPoder(numero); }
        else if (nombreValor == "SENTIDOS") { _alma.ActSent(numero); }
        else if (nombreValor == "MEMORIA") { _alma.ActMemo(numero); }
        else if (nombreValor == "PERSONALIDAD") { _alma.ActPers(numero); }

        else if (nombreValor == "CUERPOACT") { _cuerpo.cuerpo_act = numero; }
        else if (nombreValor == "ALMAACT") { _alma.alma_act = numero; }
    }

    public void ActualizarValorBuff(string nombreValor, int numero)
    {
        if (nombreValor == "FUERZA") { _cuerpo.ActFuerza(numero); }
        else if (nombreValor == "RESISTENCIA") { _cuerpo.ActResisBuff(numero); }
        else if (nombreValor == "AGILIDAD") { _cuerpo.ActAgil(numero); }
        else if (nombreValor == "VELOCIDAD") { _cuerpo.ActVel(numero); _otros.apt = 2 + (_cuerpo.bono_velocidad / 2); }

        else if (nombreValor == "PODER") { _alma.ActPoderBuff(numero); }
        else if (nombreValor == "SENTIDOS") { _alma.ActSent(numero); }
        else if (nombreValor == "MEMORIA") { _alma.ActMemo(numero); }
        else if (nombreValor == "PERSONALIDAD") { _alma.ActPers(numero); }
    }

    public void ActualizarEstado(string estado)
    {
        _otros.estado = estado;
    }

    public void SubirNivel()
    {
        _cuerpo.extra_vida = 8 * nivel;
        _cuerpo.ActResis(0);
        _alma.extra_mana = 8 * nivel;
        _alma.ActPoder(0);
        nivel++;
        _otros.numDados = 1 + (nivel / 2);
    }

    public int Valor(string nombreValor)
    {
        int res = 0;
        if      (nombreValor == "FUERZA") { res = _cuerpo.fuerza; }
        else if (nombreValor == "RESISTENCIA") { res = _cuerpo.resist; }
        else if (nombreValor == "AGILIDAD") { res = _cuerpo.agilidad; }
        else if (nombreValor == "VELOCIDAD") { res = _cuerpo.velocidad; }

        else if (nombreValor == "PODER") { res = _alma.poder; }
        else if (nombreValor == "SENTIDOS") { res = _alma.sentidos; }
        else if (nombreValor == "MEMORIA") { res = _alma.memoria; }
        else if (nombreValor == "PERSONALIDAD") { res = _alma.persona; }

        else if (nombreValor == "CUERPOACT") { res = _cuerpo.cuerpo_act; }
        else if (nombreValor == "CUERPOMAX") { res = _cuerpo.cuerpo_max; }

        else if (nombreValor == "ALMAACT") { res = _alma.alma_act; }
        else if (nombreValor == "ALMAMAX") { res = _alma.alma_max; }
        return res;
    }

    public float PuntosHora(string nombreValor)
    {
        float res = 0.0f;
        if (nombreValor == "CUERPO") { res = _cuerpo.cuerpo_hora; }
        else if (nombreValor == "ALMA") { res = _alma.alma_hora; }
        return res;
    }

    public int BonoValor(string nombreValor)
    {
        int res = 0;
        if (nombreValor == "FUERZA") { res = _cuerpo.bono_fuerza; }
        else if (nombreValor == "RESISTENCIA") { res = _cuerpo.bono_resist; }
        else if (nombreValor == "AGILIDAD") { res = _cuerpo.bono_agilidad; }
        else if (nombreValor == "VELOCIDAD") { res = _cuerpo.bono_velocidad; }

        else if (nombreValor == "PODER") { res = _alma.bono_poder; }
        else if (nombreValor == "SENTIDOS") { res = _alma.bono_sentidos; }
        else if (nombreValor == "MEMORIA") { res = _alma.bono_memoria; }
        else if (nombreValor == "PERSONALIDAD") { res = _alma.bono_persona; }
        return res;
    }

    public int PCActual()
    {
        int res = _cuerpo.cuerpo_act;
        return res;
    }

    public int PCMaxima()
    {
        int res = _cuerpo.cuerpo_max;
        return res;
    }

    public int PAActual()
    {
        int res = _alma.alma_act;
        return res;
    }

    public int PAMaxima()
    {
        int res = _alma.alma_max;
        return res;
    }

    public string ElemRaza(string elem)
    {
        return _raza.GetElemRaza(elem);
    }

    public string ElemClase(string elem)
    {
        return _clase.GetElemClase(elem);
    }
}
